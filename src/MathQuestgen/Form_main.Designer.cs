namespace MathQuestgen
{
    partial class Form_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_selectTemplate = new System.Windows.Forms.Label();
            this.comboBox_selectTemplate = new System.Windows.Forms.ComboBox();
            this.label_preview = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_singleQuestion = new System.Windows.Forms.TabPage();
            this.tabPage_batchGenerate = new System.Windows.Forms.TabPage();
            this.webBrowser_preview = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage_singleQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_selectTemplate
            // 
            this.label_selectTemplate.AutoSize = true;
            this.label_selectTemplate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_selectTemplate.Location = new System.Drawing.Point(11, 15);
            this.label_selectTemplate.Name = "label_selectTemplate";
            this.label_selectTemplate.Size = new System.Drawing.Size(56, 17);
            this.label_selectTemplate.TabIndex = 0;
            this.label_selectTemplate.Text = "选择模板";
            // 
            // comboBox_selectTemplate
            // 
            this.comboBox_selectTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_selectTemplate.FormattingEnabled = true;
            this.comboBox_selectTemplate.Location = new System.Drawing.Point(73, 12);
            this.comboBox_selectTemplate.Name = "comboBox_selectTemplate";
            this.comboBox_selectTemplate.Size = new System.Drawing.Size(279, 25);
            this.comboBox_selectTemplate.TabIndex = 1;
            this.comboBox_selectTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectTemplate_SelectedIndexChanged);
            // 
            // label_preview
            // 
            this.label_preview.AutoSize = true;
            this.label_preview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_preview.Location = new System.Drawing.Point(11, 85);
            this.label_preview.Name = "label_preview";
            this.label_preview.Size = new System.Drawing.Size(56, 17);
            this.label_preview.TabIndex = 2;
            this.label_preview.Text = "题目预览";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_singleQuestion);
            this.tabControl1.Controls.Add(this.tabPage_batchGenerate);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 449);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_singleQuestion
            // 
            this.tabPage_singleQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_singleQuestion.Controls.Add(this.webBrowser_preview);
            this.tabPage_singleQuestion.Controls.Add(this.comboBox_selectTemplate);
            this.tabPage_singleQuestion.Controls.Add(this.label_preview);
            this.tabPage_singleQuestion.Controls.Add(this.label_selectTemplate);
            this.tabPage_singleQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_singleQuestion.Name = "tabPage_singleQuestion";
            this.tabPage_singleQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_singleQuestion.Size = new System.Drawing.Size(789, 423);
            this.tabPage_singleQuestion.TabIndex = 0;
            this.tabPage_singleQuestion.Text = "单题生成&模板预览";
            // 
            // tabPage_batchGenerate
            // 
            this.tabPage_batchGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_batchGenerate.Location = new System.Drawing.Point(4, 22);
            this.tabPage_batchGenerate.Name = "tabPage_batchGenerate";
            this.tabPage_batchGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_batchGenerate.Size = new System.Drawing.Size(789, 423);
            this.tabPage_batchGenerate.TabIndex = 1;
            this.tabPage_batchGenerate.Text = "批量出题";
            // 
            // webBrowser_preview
            // 
            this.webBrowser_preview.Location = new System.Drawing.Point(14, 106);
            this.webBrowser_preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_preview.Name = "webBrowser_preview";
            this.webBrowser_preview.Size = new System.Drawing.Size(455, 283);
            this.webBrowser_preview.TabIndex = 3;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_main";
            this.Text = "MathQuestgen - 批量数学出题工具";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_singleQuestion.ResumeLayout(false);
            this.tabPage_singleQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_selectTemplate;
        private System.Windows.Forms.ComboBox comboBox_selectTemplate;
        private System.Windows.Forms.Label label_preview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_singleQuestion;
        private System.Windows.Forms.TabPage tabPage_batchGenerate;
        private CefSharp.WinForms.ChromiumWebBrowser webBrowser_preview;
    }
}

