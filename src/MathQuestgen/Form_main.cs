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
        private void Form_main_Activated(object sender, EventArgs e)
        {
            if (!GeneralData.Instance.firstLoad)
            {
                return;
            }
            FileInfo[] templates = (new DirectoryInfo(Application.StartupPath + Path.DirectorySeparatorChar + "templates")).GetFiles("*.mqt");
            Directory.CreateDirectory(GeneralData.TempDirectory);
            var serializer = new Serializer();
            int id = 0;
            foreach (var file in templates)
            {
                var templateZipFile = ZipFile.OpenRead(file.FullName);
                QuestionTemplate template = new QuestionTemplate();
                foreach (var fileInZip in templateZipFile.Entries)
                {
                    if (fileInZip.FullName == "metadata.yml")
                    {
                        QuestionTemplate.YamlMetadataFormat metadata =
                            (new Deserializer()).Deserialize<QuestionTemplate.YamlMetadataFormat>(Tools.ReadStringFromStream(
                                fileInZip.Open(), 1024 * 1024 * 4 /*文件最大不超过4M*/, Encoding.UTF8
                                ));
                        switch (metadata.type)
                        //简单工厂模式
                        {
                            case "choice":
                                template = new ChoiceQuestionTemplate(); break;
                            case "fillingblank":
                                template = new FillingblankQuestionTemplate(); break;
                            case "calculation":
                                template = new CalcultaionQuestionTemplate(); break;
                            default:
                                throw new UnknownTemplateTypeException(metadata.type,
                           "未知的模板类型'" + metadata.type + "'。");
                        }
                        template.name = metadata.name;
                        template.tags = metadata.tags;
                    }
                    else if (fileInZip.FullName == "question_text.txt")
                    {
                        string[] fileLines =
                            Tools.ReadStringFromStream(fileInZip.Open(), 1024 * 1024 * 4 /*文件最大不超过4M*/, Encoding.UTF8)
                            .Split('\n'); //将文件分行“切片”
                        List<string> questionTexts = new List<string>();
                        string textTmp = "";
                        foreach (var line in fileLines)
                        {
                            if (line.Trim() == "----") //检测到分割线
                            {
                                questionTexts.Add(textTmp);
                                textTmp = "";
                                //将缓存内的字符串压入题干列表并清空
                            }
                            else
                            {
                                textTmp += line + "\n";
                                //以换行符间隔连接行内容
                            }
                        }
                    }
                }
                GeneralData.Instance.questionTemplates.Add(id, template);
                id++;
            }
            foreach (var item in GeneralData.Instance.questionTemplates.Values)
            {
                //生成显示在菜单中的模板名称
                string tmp = item.name + " - ";
                if (item.GetType() == typeof(ChoiceQuestionTemplate))
                {
                    tmp += "选择题";
                }
                else if (item.GetType() == typeof(FillingblankQuestionTemplate))
                {
                    tmp += "填空题";
                }
                else if (item.GetType() == typeof(CalcultaionQuestionTemplate))
                {
                    tmp += "计算题";
                }
                //comboBox_selectTemplate.Items.Add(tmp);
            }

            this.Text = "MathQuestgen - 数学出题工具";
            GeneralData.Instance.firstLoad = false;
        }
        public Form_main()
        {
            InitializeComponent();
        }

        /*
        private void comboBox_selectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pipeline = new MarkdownPipelineBuilder().UseMathematics().Build();

            MessageBox.Show(comboBox_selectTemplate.SelectedIndex.ToString());

            string html = Markdown.ToHtml(GeneralData.Instance.questionTemplates[comboBox_selectTemplate.SelectedIndex]
                .questionStems[0] //默认显示第一个题干
                , pipeline);
            html = GeneralData.HTML_Preset + html; //将预设前缀连接到生成的HTML代码前面（别去看HTML_Preset，巨长巨长）

            string path = GeneralData.TempDirectory + Path.DirectorySeparatorChar + "preview.html";
            File.WriteAllText(path, html); //将HTML文档写入缓存目录文件
            webBrowser_preview.Url = new Uri(path); //刷新webBrowser
        }
        */

        private void button_selectTemplate_Click(object sender, EventArgs e)
        {
            (new Form_dialog_selectTemplate()).ShowDialog();
        }
    }
}
