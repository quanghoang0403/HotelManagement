namespace QuanLyKhachSan
{
    partial class ucRevenue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvIncome = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dateMonth = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvIncome
            // 
            this.dtgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIncome.Location = new System.Drawing.Point(81, 167);
            this.dtgvIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvIncome.Name = "dtgvIncome";
            this.dtgvIncome.RowHeadersWidth = 51;
            this.dtgvIncome.RowTemplate.Height = 24;
            this.dtgvIncome.Size = new System.Drawing.Size(808, 234);
            this.dtgvIncome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Báo cáo doanh thu";
            // 
            // dateMonth
            // 
            this.dateMonth.CustomFormat = "MM/yyyy";
            this.dateMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMonth.Location = new System.Drawing.Point(564, 122);
            this.dateMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateMonth.Name = "dateMonth";
            this.dateMonth.Size = new System.Drawing.Size(99, 20);
            this.dateMonth.TabIndex = 11;
            this.dateMonth.ValueChanged += new System.EventHandler(this.dateMonth_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(496, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tháng:";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(968, 239);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(151, 76);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Xuất báo cáo ";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ucRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateMonth);
            this.Controls.Add(this.dtgvIncome);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucRevenue";
            this.Size = new System.Drawing.Size(1212, 782);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvIncome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExport;
    }
}
