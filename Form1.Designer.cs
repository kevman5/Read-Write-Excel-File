
namespace Read_Write_ExcelFile
{
    partial class Form1
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.lb_sum = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(12, 59);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 20);
            this.tb_input.TabIndex = 0;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(12, 109);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(100, 23);
            this.btn_input.TabIndex = 1;
            this.btn_input.Text = "Input Number";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // lb_1
            // 
            this.lb_1.FormattingEnabled = true;
            this.lb_1.Location = new System.Drawing.Point(12, 162);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(120, 95);
            this.lb_1.TabIndex = 2;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(152, 189);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 3;
            this.btn_sum.Text = "Sum";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(168, 244);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(0, 13);
            this.lb_sum.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(13, 285);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create File";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(13, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 6;
            this.btn_import.Text = "Import File";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.tb_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lb_1;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_import;
    }
}

