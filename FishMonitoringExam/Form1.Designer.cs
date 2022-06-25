
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
            this.tb_maxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Temps_KeyPress);
            // 
            // tb_minTemp
            // 
            this.tb_minTemp.Location = new System.Drawing.Point(96, 136);
            this.tb_minTemp.Name = "tb_minTemp";
            this.tb_minTemp.Size = new System.Drawing.Size(100, 23);
            this.tb_minTemp.TabIndex = 7;
            this.tb_minTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Temps_KeyPress);
            // 
            // FishMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_minTemp);
            this.Controls.Add(this.tb_maxTemp);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.lb_timeTitle);
            this.Controls.Add(this.lb_tempTitle);
            this.Controls.Add(this.lb_typeOfFish);
            this.Controls.Add(this.mtb_typeOfFish);
            this.Name = "FishMonitoring";
            this.Text = "Fish monitoring";
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
    }
}

