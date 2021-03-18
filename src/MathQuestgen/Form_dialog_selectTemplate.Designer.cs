
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
            this.dataGridView_templates = new System.Windows.Forms.DataGridView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_templates)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(8, 540);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(485, 80);
            this.label_tip.TabIndex = 0;
            this.label_tip.Text = "选择需要使用或预览的题目模板。\r\n题目模板储存了题目的题干信息和解题过程的描述数据，供给程序自动出题。\r\n你可以将扩展名为.mqt的模板文件放入程序所在的temp" +
    "late文件夹内读取，\r\n也可以拖拽到此窗口内立即加载。\r\n";
            // 
            // checkBox_hideTip
            // 
            this.checkBox_hideTip.AutoSize = true;
            this.checkBox_hideTip.Location = new System.Drawing.Point(549, 601);
            this.checkBox_hideTip.Name = "checkBox_hideTip";
            this.checkBox_hideTip.Size = new System.Drawing.Size(72, 16);
            this.checkBox_hideTip.TabIndex = 1;
            this.checkBox_hideTip.Text = "关闭提示";
            this.checkBox_hideTip.UseVisualStyleBackColor = true;
            this.checkBox_hideTip.CheckedChanged += new System.EventHandler(this.checkBox_hideTip_CheckedChanged);
            this.checkBox_hideTip.MouseHover += new System.EventHandler(this.checkBox_hideTip_MouseHover);
            // 
            // dataGridView_templates
            // 
            this.dataGridView_templates.AllowUserToAddRows = false;
            this.dataGridView_templates.AllowUserToDeleteRows = false;
            this.dataGridView_templates.AllowUserToOrderColumns = true;
            this.dataGridView_templates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_templates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_name,
            this.Column_tags});
            this.dataGridView_templates.Location = new System.Drawing.Point(12, 70);
            this.dataGridView_templates.Name = "dataGridView_templates";
            this.dataGridView_templates.ReadOnly = true;
            this.dataGridView_templates.RowHeadersVisible = false;
            this.dataGridView_templates.RowTemplate.Height = 23;
            this.dataGridView_templates.ShowCellToolTips = false;
            this.dataGridView_templates.ShowEditingIcon = false;
            this.dataGridView_templates.Size = new System.Drawing.Size(609, 467);
            this.dataGridView_templates.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_search.Location = new System.Drawing.Point(12, 21);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(423, 26);
            this.textBox_search.TabIndex = 3;
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_select.Location = new System.Drawing.Point(542, 19);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(79, 31);
            this.button_select.TabIndex = 5;
            this.button_select.Text = "选定";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_search.Location = new System.Drawing.Point(457, 19);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(79, 31);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "ID";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            this.Column_id.Width = 75;
            this.Column_id.ValueType = typeof(int);
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "名称";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 250;
            this.Column_id.ValueType = typeof(string);
            // 
            // Column_tags
            // 
            this.Column_tags.HeaderText = "标签";
            this.Column_tags.Name = "Column_tags";
            this.Column_tags.ReadOnly = true;
            this.Column_tags.Width = 300;
            this.Column_id.ValueType = typeof(string);
            // 
            // Form_dialog_selectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 629);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_templates);
            this.Controls.Add(this.checkBox_hideTip);
            this.Controls.Add(this.label_tip);
            this.Name = "Form_dialog_selectTemplate";
            this.Text = "选择模板";
            this.Load += new System.EventHandler(this.Form_dialog_selectTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_templates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.CheckBox checkBox_hideTip;
        private System.Windows.Forms.DataGridView dataGridView_templates;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tags;
    }
}