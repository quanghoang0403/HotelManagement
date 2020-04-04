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
            this.dtgvIncome.Location = new System.Drawing.Point(108, 206);
            this.dtgvIncome.Name = "dtgvIncome";
            this.dtgvIncome.RowHeadersWidth = 51;
            this.dtgvIncome.RowTemplate.Height = 24;
            this.dtgvIncome.Size = new System.Drawing.Size(1078, 288);
            this.dtgvIncome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 51);
            this.label7.TabIndex = 10;
            this.label7.Text = "Báo cáo doanh thu";
            // 
            // dateMonth
            // 
            this.dateMonth.CustomFormat = "MM/yyyy";
            this.dateMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMonth.Location = new System.Drawing.Point(752, 150);
            this.dateMonth.Name = "dateMonth";
            this.dateMonth.Size = new System.Drawing.Size(131, 22);
            this.dateMonth.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(662, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tháng:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1290, 294);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(201, 94);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Xuất báo cáo ";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ucRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateMonth);
            this.Controls.Add(this.dtgvIncome);
            this.Controls.Add(this.label7);
            this.Name = "ucRevenue";
            this.Size = new System.Drawing.Size(1616, 962);
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
