
namespace Load_Data_Gridview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Seach = new System.Windows.Forms.Button();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(997, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Seach
            // 
            this.btn_Seach.BackColor = System.Drawing.Color.Yellow;
            this.btn_Seach.Location = new System.Drawing.Point(565, 29);
            this.btn_Seach.Name = "btn_Seach";
            this.btn_Seach.Size = new System.Drawing.Size(118, 36);
            this.btn_Seach.TabIndex = 2;
            this.btn_Seach.Text = "Tim kiếm";
            this.btn_Seach.UseVisualStyleBackColor = false;
            this.btn_Seach.Click += new System.EventHandler(this.btn_Seach_Click);
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.BackColor = System.Drawing.Color.Blue;
            this.btn_xuatfile.Location = new System.Drawing.Point(436, 467);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(140, 42);
            this.btn_xuatfile.TabIndex = 3;
            this.btn_xuatfile.Text = "In file excel";
            this.btn_xuatfile.UseVisualStyleBackColor = false;
            this.btn_xuatfile.Click += new System.EventHandler(this.btn_xuatfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo ngày";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(366, 37);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(151, 23);
            this.txt_date.TabIndex = 4;
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_date_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 531);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_xuatfile);
            this.Controls.Add(this.btn_Seach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Seach;
        private System.Windows.Forms.Button btn_xuatfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_date;
    }
}

