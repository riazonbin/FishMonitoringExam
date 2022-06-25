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
            var tempratures = new List<int>();

            string[] temps = tb_tempratures.Text.Split();
            DateTime time = DateTime.Parse(mtb_date.Text, culture);

            foreach (var temp in temps)
            {
                string[] row = new string[] { $"{time}", $"{temp}" };
                time = time.AddMinutes(10);
                dataGrid_report.Rows.Add(row);
            }

        }
    }
}
