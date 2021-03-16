
namespace MathQuestgen
{
    partial class Form_dialog_selectTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_tip = new System.Windows.Forms.Label();
            this.checkBox_hideTip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(12, 418);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(485, 80);
            this.label_tip.TabIndex = 0;
            this.label_tip.Text = "选择需要使用或预览的题目模板。\r\n题目模板储存了题目的题干信息和解题过程的描述数据，供给程序自动出题。\r\n你可以将扩展名为.mqt的模板文件放入程序所在的temp" +
    "late文件夹内读取，\r\n也可以拖拽到此窗口内立即加载。\r\n";
            // 
            // checkBox_hideTip
            // 
            this.checkBox_hideTip.AutoSize = true;
            this.checkBox_hideTip.Location = new System.Drawing.Point(543, 481);
            this.checkBox_hideTip.Name = "checkBox_hideTip";
            this.checkBox_hideTip.Size = new System.Drawing.Size(72, 16);
            this.checkBox_hideTip.TabIndex = 1;
            this.checkBox_hideTip.Text = "关闭提示";
            this.checkBox_hideTip.UseVisualStyleBackColor = true;
            this.checkBox_hideTip.CheckedChanged += new System.EventHandler(this.checkBox_hideTip_CheckedChanged);
            this.checkBox_hideTip.MouseHover += new System.EventHandler(this.checkBox_hideTip_MouseHover);
            // 
            // Form_dialog_selectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 507);
            this.Controls.Add(this.checkBox_hideTip);
            this.Controls.Add(this.label_tip);
            this.Name = "Form_dialog_selectTemplate";
            this.Text = "选择模板";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.CheckBox checkBox_hideTip;
    }
}