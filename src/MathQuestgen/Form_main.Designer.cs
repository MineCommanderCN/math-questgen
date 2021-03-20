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
            this.label_preview = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_singleQuestion = new System.Windows.Forms.TabPage();
            this.button_selectTemplate = new System.Windows.Forms.Button();
            this.webBrowser_preview = new System.Windows.Forms.WebBrowser();
            this.tabPage_batchGenerate = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_singleQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_preview
            // 
            this.label_preview.AutoSize = true;
            this.label_preview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_preview.Location = new System.Drawing.Point(11, 73);
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
            this.tabControl1.Size = new System.Drawing.Size(690, 449);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_singleQuestion
            // 
            this.tabPage_singleQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_singleQuestion.Controls.Add(this.button_selectTemplate);
            this.tabPage_singleQuestion.Controls.Add(this.webBrowser_preview);
            this.tabPage_singleQuestion.Controls.Add(this.label_preview);
            this.tabPage_singleQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_singleQuestion.Name = "tabPage_singleQuestion";
            this.tabPage_singleQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_singleQuestion.Size = new System.Drawing.Size(682, 423);
            this.tabPage_singleQuestion.TabIndex = 0;
            this.tabPage_singleQuestion.Text = "单题生成&模板预览";
            // 
            // button_selectTemplate
            // 
            this.button_selectTemplate.Location = new System.Drawing.Point(14, 23);
            this.button_selectTemplate.Name = "button_selectTemplate";
            this.button_selectTemplate.Size = new System.Drawing.Size(108, 31);
            this.button_selectTemplate.TabIndex = 4;
            this.button_selectTemplate.Text = "选择模板";
            this.button_selectTemplate.UseVisualStyleBackColor = true;
            this.button_selectTemplate.Click += new System.EventHandler(this.button_selectTemplate_Click);
            // 
            // webBrowser_preview
            // 
            this.webBrowser_preview.Location = new System.Drawing.Point(14, 93);
            this.webBrowser_preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_preview.Name = "webBrowser_preview";
            this.webBrowser_preview.Size = new System.Drawing.Size(455, 312);
            this.webBrowser_preview.TabIndex = 3;
            // 
            // tabPage_batchGenerate
            // 
            this.tabPage_batchGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_batchGenerate.Location = new System.Drawing.Point(4, 22);
            this.tabPage_batchGenerate.Name = "tabPage_batchGenerate";
            this.tabPage_batchGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_batchGenerate.Size = new System.Drawing.Size(682, 429);
            this.tabPage_batchGenerate.TabIndex = 1;
            this.tabPage_batchGenerate.Text = "批量出题";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 462);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.Text = "MathQuestgen - 加载中...";
            this.Activated += new System.EventHandler(this.Form_main_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_singleQuestion.ResumeLayout(false);
            this.tabPage_singleQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_preview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_singleQuestion;
        private System.Windows.Forms.TabPage tabPage_batchGenerate;
        private System.Windows.Forms.WebBrowser webBrowser_preview;
        private System.Windows.Forms.Button button_selectTemplate;
    }
}

