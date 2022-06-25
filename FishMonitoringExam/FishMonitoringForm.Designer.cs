
namespace FishMonitoringExam
{
    partial class FishMonitoring
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
            this.mtb_typeOfFish = new System.Windows.Forms.MaskedTextBox();
            this.lb_typeOfFish = new System.Windows.Forms.Label();
            this.lb_tempTitle = new System.Windows.Forms.Label();
            this.lb_timeTitle = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.tb_maxTemp = new System.Windows.Forms.TextBox();
            this.tb_minTemp = new System.Windows.Forms.TextBox();
            this.mtb_maxTime = new System.Windows.Forms.MaskedTextBox();
            this.mtb_minTime = new System.Windows.Forms.MaskedTextBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.mtb_date = new System.Windows.Forms.MaskedTextBox();
            this.tb_tempratures = new System.Windows.Forms.TextBox();
            this.lb_tempratures = new System.Windows.Forms.Label();
            this.lb_report = new System.Windows.Forms.Label();
            this.dataGrid_report = new System.Windows.Forms.DataGridView();
            this.btn_makeReport = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_report)).BeginInit();
            this.SuspendLayout();
            // 
            // mtb_typeOfFish
            // 
            this.mtb_typeOfFish.Location = new System.Drawing.Point(96, 32);
            this.mtb_typeOfFish.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.mtb_typeOfFish.Name = "mtb_typeOfFish";
            this.mtb_typeOfFish.Size = new System.Drawing.Size(100, 23);
            this.mtb_typeOfFish.TabIndex = 0;
            // 
            // lb_typeOfFish
            // 
            this.lb_typeOfFish.AutoSize = true;
            this.lb_typeOfFish.Location = new System.Drawing.Point(28, 35);
            this.lb_typeOfFish.Name = "lb_typeOfFish";
            this.lb_typeOfFish.Size = new System.Drawing.Size(62, 15);
            this.lb_typeOfFish.TabIndex = 1;
            this.lb_typeOfFish.Text = "Вид рыбы";
            // 
            // lb_tempTitle
            // 
            this.lb_tempTitle.AutoSize = true;
            this.lb_tempTitle.Location = new System.Drawing.Point(96, 77);
            this.lb_tempTitle.Name = "lb_tempTitle";
            this.lb_tempTitle.Size = new System.Drawing.Size(78, 15);
            this.lb_tempTitle.TabIndex = 2;
            this.lb_tempTitle.Text = "Температура";
            // 
            // lb_timeTitle
            // 
            this.lb_timeTitle.AutoSize = true;
            this.lb_timeTitle.Location = new System.Drawing.Point(216, 77);
            this.lb_timeTitle.Name = "lb_timeTitle";
            this.lb_timeTitle.Size = new System.Drawing.Size(42, 15);
            this.lb_timeTitle.TabIndex = 3;
            this.lb_timeTitle.Text = "Время";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Location = new System.Drawing.Point(28, 113);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(30, 15);
            this.lb_max.TabIndex = 4;
            this.lb_max.Text = "Max";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(28, 144);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(28, 15);
            this.lb_min.TabIndex = 5;
            this.lb_min.Text = "Min";
            // 
            // tb_maxTemp
            // 
            this.tb_maxTemp.Location = new System.Drawing.Point(96, 104);
            this.tb_maxTemp.Name = "tb_maxTemp";
            this.tb_maxTemp.Size = new System.Drawing.Size(100, 23);
            this.tb_maxTemp.TabIndex = 6;
            this.tb_maxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TempsAdd_KeyPress);
            // 
            // tb_minTemp
            // 
            this.tb_minTemp.Location = new System.Drawing.Point(96, 136);
            this.tb_minTemp.Name = "tb_minTemp";
            this.tb_minTemp.Size = new System.Drawing.Size(100, 23);
            this.tb_minTemp.TabIndex = 7;
            this.tb_minTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TempsAdd_KeyPress);
            // 
            // mtb_maxTime
            // 
            this.mtb_maxTime.Location = new System.Drawing.Point(216, 103);
            this.mtb_maxTime.Mask = "000";
            this.mtb_maxTime.Name = "mtb_maxTime";
            this.mtb_maxTime.Size = new System.Drawing.Size(26, 23);
            this.mtb_maxTime.TabIndex = 8;
            // 
            // mtb_minTime
            // 
            this.mtb_minTime.Location = new System.Drawing.Point(216, 136);
            this.mtb_minTime.Mask = "000";
            this.mtb_minTime.Name = "mtb_minTime";
            this.mtb_minTime.Size = new System.Drawing.Size(26, 23);
            this.mtb_minTime.TabIndex = 9;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(30, 178);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(32, 15);
            this.lb_date.TabIndex = 10;
            this.lb_date.Text = "Дата";
            // 
            // mtb_date
            // 
            this.mtb_date.Location = new System.Drawing.Point(96, 178);
            this.mtb_date.Mask = "00/00/0000 90:00";
            this.mtb_date.Name = "mtb_date";
            this.mtb_date.Size = new System.Drawing.Size(100, 23);
            this.mtb_date.TabIndex = 11;
            this.mtb_date.ValidatingType = typeof(System.DateTime);
            // 
            // tb_tempratures
            // 
            this.tb_tempratures.Location = new System.Drawing.Point(96, 219);
            this.tb_tempratures.Name = "tb_tempratures";
            this.tb_tempratures.Size = new System.Drawing.Size(692, 23);
            this.tb_tempratures.TabIndex = 12;
            this.tb_tempratures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Temps_KeyPress);
            // 
            // lb_tempratures
            // 
            this.lb_tempratures.AutoSize = true;
            this.lb_tempratures.Location = new System.Drawing.Point(12, 222);
            this.lb_tempratures.Name = "lb_tempratures";
            this.lb_tempratures.Size = new System.Drawing.Size(78, 15);
            this.lb_tempratures.TabIndex = 13;
            this.lb_tempratures.Text = "Температура";
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_report.Location = new System.Drawing.Point(30, 258);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(63, 25);
            this.lb_report.TabIndex = 14;
            this.lb_report.Text = "Отчёт";
            // 
            // dataGrid_report
            // 
            this.dataGrid_report.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Fact,
            this.Norm,
            this.normDeviation});
            this.dataGrid_report.Location = new System.Drawing.Point(30, 295);
            this.dataGrid_report.Name = "dataGrid_report";
            this.dataGrid_report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrid_report.RowHeadersWidth = 60;
            this.dataGrid_report.RowTemplate.Height = 25;
            this.dataGrid_report.Size = new System.Drawing.Size(661, 211);
            this.dataGrid_report.TabIndex = 15;
            // 
            // btn_makeReport
            // 
            this.btn_makeReport.Location = new System.Drawing.Point(644, 249);
            this.btn_makeReport.Name = "btn_makeReport";
            this.btn_makeReport.Size = new System.Drawing.Size(144, 34);
            this.btn_makeReport.TabIndex = 16;
            this.btn_makeReport.Text = "Создать отчёт";
            this.btn_makeReport.UseVisualStyleBackColor = true;
            this.btn_makeReport.Click += new System.EventHandler(this.btn_makeReport_Click);
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // Fact
            // 
            this.Fact.HeaderText = "Факт";
            this.Fact.Name = "Fact";
            this.Fact.Width = 150;
            // 
            // Norm
            // 
            this.Norm.HeaderText = "Норма";
            this.Norm.Name = "Norm";
            this.Norm.Width = 150;
            // 
            // normDeviation
            // 
            this.normDeviation.HeaderText = "Отклонение от нормы";
            this.normDeviation.Name = "normDeviation";
            this.normDeviation.Width = 150;
            // 
            // FishMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btn_makeReport);
            this.Controls.Add(this.dataGrid_report);
            this.Controls.Add(this.lb_report);
            this.Controls.Add(this.lb_tempratures);
            this.Controls.Add(this.tb_tempratures);
            this.Controls.Add(this.mtb_date);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.mtb_minTime);
            this.Controls.Add(this.mtb_maxTime);
            this.Controls.Add(this.tb_minTemp);
            this.Controls.Add(this.tb_maxTemp);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.lb_timeTitle);
            this.Controls.Add(this.lb_tempTitle);
            this.Controls.Add(this.lb_typeOfFish);
            this.Controls.Add(this.mtb_typeOfFish);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "FishMonitoring";
            this.Text = "Fish monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_typeOfFish;
        private System.Windows.Forms.Label lb_typeOfFish;
        private System.Windows.Forms.Label lb_tempTitle;
        private System.Windows.Forms.Label lb_timeTitle;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.TextBox tb_maxTemp;
        private System.Windows.Forms.TextBox tb_minTemp;
        private System.Windows.Forms.MaskedTextBox mtb_maxTime;
        private System.Windows.Forms.MaskedTextBox mtb_minTime;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.MaskedTextBox mtb_date;
        private System.Windows.Forms.TextBox tb_tempratures;
        private System.Windows.Forms.Label lb_tempratures;
        private System.Windows.Forms.Label lb_report;
        private System.Windows.Forms.DataGridView dataGrid_report;
        private System.Windows.Forms.Button btn_makeReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn normDeviation;
    }
}

