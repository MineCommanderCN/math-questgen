using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuestgen
{
    public partial class Form_dialog_selectTemplate : Form
    {
        public Form_dialog_selectTemplate()
        {
            InitializeComponent();
        }

        private void checkBox_hideTip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_hideTip_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.checkBox_hideTip, "你可以按下F2键来重新显示提示。");
        }
    }
}
