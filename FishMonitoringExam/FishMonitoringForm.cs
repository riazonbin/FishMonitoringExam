using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace FishMonitoringExam
{
    public partial class FishMonitoring : Form
    {
        private static CultureInfo culture = new CultureInfo("ru-RU");
        public FishMonitoring()
        {
            InitializeComponent();
        }

        private void tb_TempsAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_Temps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == (char)8)
            {
                return;
            }

            e.Handled = true;
        }

        private void btn_makeReport_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temps = tb_tempratures.Text.Split();
                DateTime time = DateTime.Parse(mtb_date.Text, culture);
                int maxTemp = int.Parse(tb_maxTemp.Text);
                int minTemp = int.Parse(tb_minTemp.Text);

                foreach (var temp in temps)
                {
                    int currentTemp = int.Parse(temp);

                    if (currentTemp > maxTemp)
                    {
                        string[] row = new string[] { $"{time}", $"{temp}", $"{maxTemp}",
                        $"{maxTemp - currentTemp}"};
                        time = time.AddMinutes(10);
                        dataGrid_report.Rows.Add(row);
                    }
                    else if (currentTemp < minTemp)
                    {
                        string[] row = new string[] { $"{time}", $"{temp}", $"{minTemp}",
                        $"{minTemp - currentTemp}"};
                        time = time.AddMinutes(10);
                        dataGrid_report.Rows.Add(row);
                    }
                }
            }
            catch { }
        }
    }
}
