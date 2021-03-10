
namespace MathQuestgen
{
    partial class Form_loading
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
            this.progressBar_loading = new System.Windows.Forms.ProgressBar();
            this.label_loadingInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_loading
            // 
            this.progressBar_loading.Location = new System.Drawing.Point(12, 12);
            this.progressBar_loading.Name = "progressBar_loading";
            this.progressBar_loading.Size = new System.Drawing.Size(449, 23);
            this.progressBar_loading.TabIndex = 0;
            // 
            // label_loadingInfo
            // 
            this.label_loadingInfo.AutoSize = true;
            this.label_loadingInfo.Location = new System.Drawing.Point(12, 50);
            this.label_loadingInfo.Name = "label_loadingInfo";
            this.label_loadingInfo.Size = new System.Drawing.Size(77, 12);
            this.label_loadingInfo.TabIndex = 1;
            this.label_loadingInfo.Text = "载入模板 ...";
            // 
            // Form_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 74);
            this.Controls.Add(this.label_loadingInfo);
            this.Controls.Add(this.progressBar_loading);
            this.MaximizeBox = false;
            this.Name = "Form_loading";
            this.ShowIcon = false;
            this.Text = "MathQuestgen - 加载中...";
            this.Activated += new System.EventHandler(this.Form_loading_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_loading;
        private System.Windows.Forms.Label label_loadingInfo;
    }
}