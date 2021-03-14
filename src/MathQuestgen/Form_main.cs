using Markdig;
using System;
using YamlDotNet;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using System.Text;

namespace MathQuestgen
{
    public partial class Form_main : Form
    {
        private void Form_main_Load(object sender, EventArgs e)
        {
            FileInfo[] templates = (new DirectoryInfo(Application.StartupPath + Path.DirectorySeparatorChar + "templates")).GetFiles("*.mqt");
            Directory.CreateDirectory(GeneralData.TempDirectory);
            var serializer = new Serializer();
            foreach (var file in templates)
            {
                var templateZipFile = ZipFile.OpenRead(file.FullName);
                QuestionTemplate template = new QuestionTemplate();
                foreach (var fileInZip in templateZipFile.Entries)
                {
                    if (fileInZip.FullName == "metadata.yml")
                    {
                        //MessageBox.Show("Got metadata!");
                        Dictionary<string, string> metadataDict =
                            (new Deserializer()).Deserialize<Dictionary<string, string>>(Tools.ReadStringFromStream(
                                fileInZip.Open(), 1024 * 1024 * 4 /*文件最大不超过4M*/, Encoding.UTF8
                                ));
                        template.metadata = new QuestionTemplate.Metadata
                        {
                            name = metadataDict["name"],
                            type = (QuestionTemplate.TemplateTypes)Enum.Parse(typeof(QuestionTemplate.TemplateTypes), metadataDict["type"])
                        };
                    }
                    else if (fileInZip.FullName == "question_stem.txt")
                    {
                        string[] fileLines =
                            Tools.ReadStringFromStream(fileInZip.Open(), 1024 * 1024 * 4 /*文件最大不超过4M*/, Encoding.UTF8)
                            .Split('\n');
                        //blablabla
                    }
                }
                GeneralData.generalData.questionTemplates.Add(template);
            }
            foreach (var item in GeneralData.generalData.questionTemplates)
            {
                //生成显示在菜单中的模板名称
                string tmp = item.metadata.name + " - ";
                switch (item.metadata.type)
                {
                    case QuestionTemplate.TemplateTypes.choice: tmp = tmp + "选择题"; break;
                    case QuestionTemplate.TemplateTypes.fillingblank: tmp = tmp + "填空题"; break;
                    case QuestionTemplate.TemplateTypes.calculation: tmp = tmp + "计算题"; break;
                }
                comboBox_selectTemplate.Items.Add(tmp);
            }
        }
        public Form_main()
        {
            InitializeComponent();
        }

        private void comboBox_selectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pipeline = new MarkdownPipelineBuilder().UseMathematics().Build();
            string html = Markdown.ToHtml(@"$$
\begin{equation}
  \int_0^\infty \frac{x^3}{e^x-1}\,dx = \frac{\pi^4}{15}
  \label{eq:sample}
\end{equation}
$$", pipeline); //测试用的LaTeX公式
            html = GeneralData.HTML_Preset + html; //将预设前缀连接到生成的HTML代码前面（别去看HTML_Preset，巨长巨长）

            string path = GeneralData.TempDirectory + Path.DirectorySeparatorChar + "preview.html";
            File.WriteAllText(path, html); //将HTML文档写入缓存目录文件
            webBrowser_preview.Url = new Uri(path); //刷新webBrowser
        }
    }
}
