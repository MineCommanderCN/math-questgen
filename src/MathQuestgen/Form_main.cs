using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using Markdig.Extensions;

namespace MathQuestgen
{
    public partial class Form_main : Form
    {
        private void Form_main_Load(object sender, EventArgs e)
        {
            foreach (var item in GeneralData.generalData.questionTemplates)
            {
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
$$", pipeline);
            html = GeneralData.HTML_Preset + html; //将预设前缀连接到生成的HTML代码前面（别去看HTML_Preset，巨长巨长）
            string path = Environment.GetEnvironmentVariable("TEMP") + Path.DirectorySeparatorChar + "mathQuestgen-htmlTemp";
            Directory.CreateDirectory(path);
            path = path + Path.DirectorySeparatorChar + "preview.html";
            File.WriteAllText(path, html); //将HTML文档写入缓存目录文件
            webBrowser_preview.Url = new Uri(path); //刷新webBrowser
        }
    }
}
