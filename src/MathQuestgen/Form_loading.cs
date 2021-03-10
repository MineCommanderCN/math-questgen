using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace MathQuestgen
{
    public partial class Form_loading : Form
    {
        public Form_loading()
        {
            InitializeComponent();
        }

        private void Form_loading_Activated(object sender, EventArgs e)
        {
            label_loadingInfo.Text = "创建缓存文件...";
            progressBar_loading.Maximum = 1;
            progressBar_loading.Minimum = 0;
            FileInfo[] templates = (new DirectoryInfo("templates")).GetFiles("*.mpt");
            Directory.CreateDirectory(GeneralData.TempDirectory);
            progressBar_loading.Maximum = templates.Length;
            label_loadingInfo.Text = "初始化模板...";

            foreach (var file in templates)
            {
                label_loadingInfo.Text = "加载模板\"" + file.Name + "\"...";
            }
            label_loadingInfo.Text = "完成！";
            this.Close();
        }
    }
}
