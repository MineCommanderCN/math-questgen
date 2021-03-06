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
            webBrowser_preview.Url = new Uri(
                Application.StartupPath + Path.DirectorySeparatorChar + "resources" + Path.DirectorySeparatorChar + "markdownToHtmlConvert.html"
                );
        }
    }
}
