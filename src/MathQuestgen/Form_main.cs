using Markdig;
using System;
using YamlDotNet;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
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
                var pipeline = new MarkdownPipelineBuilder().UseMathematics().Build();
                //       string html = Markdown.ToHtml(GeneralData.Instance.questionTemplates[comboBox_selectTemplate.SelectedIndex]
                //           .questionStems[0] //默认显示第一个题干
                //          , pipeline);
                string html = Markdown.ToHtml("Selected ID " + GeneralData.Instance.selectedTemplateID.ToString()
                         , pipeline);
                html = GeneralData.HTML_Preset + html; //将预设前缀连接到生成的HTML代码前面（别去看HTML_Preset，巨长巨长）

                string path = GeneralData.TempDirectory + Path.DirectorySeparatorChar + "preview.html";
                File.WriteAllText(path, html); //将HTML文档写入缓存目录文件
                webBrowser_preview.Url = new Uri(path); //刷新webBrowser

                return;
            }
            FileInfo[] templates = (new DirectoryInfo(Application.StartupPath + Path.DirectorySeparatorChar + "templates")).GetFiles("*.mqt");
            Directory.CreateDirectory(GeneralData.TempDirectory);
            int id = 0;
            foreach (var file in templates)
            {
                GeneralData.Instance.questionTemplates.Add(id, Tools.LoadTemplate(file.FullName, id));
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
                else if (item.GetType() == typeof(CalculaionQuestionTemplate))
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
