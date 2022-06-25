using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            dataGrid_report.Rows.Clear();
            try
            {
                string[] temps = tb_tempratures.Text.Split();
                DateTime time = DateTime.Parse(mtb_date.Text, culture);
                int maxTemp = int.Parse(tb_maxTemp.Text);
                int minTemp = int.Parse(tb_minTemp.Text);
                int maxViolationsTime = 0;
                int minViolationsTime = 0;

                foreach (var temp in temps)
                {
                    int currentTemp = int.Parse(temp);

                    if (currentTemp > maxTemp)
                    {
                        string[] row = new string[] { $"{time}", $"{temp}", $"{maxTemp}",
                        $"{maxTemp - currentTemp}"};

                        time = time.AddMinutes(10);
                        dataGrid_report.Rows.Add(row);
                        maxViolationsTime += 10;
                    }
                    else if (currentTemp < minTemp)
                    {
                        string[] row = new string[] { $"{time}", $"{temp}", $"{minTemp}",
                        $"{minTemp - currentTemp}"};

                        time = time.AddMinutes(10);
                        dataGrid_report.Rows.Add(row);
                        minViolationsTime += 10;
                    }
                }
                if(maxViolationsTime > int.Parse(mtb_maxTime.Text))
                {
                    tb_maxViolations.Text = $"Порог максимально допустимой температуры превышен на " +
                        $"{maxViolationsTime / 60} часов, {maxViolationsTime % 60} минут";

                    MessageBox.Show("Порог максимально допустимой t превышен!", "Предупреждение", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(minViolationsTime > int.Parse(mtb_minTime.Text))
                {
                    tb_minViolations.Text = $"Порог минимально допустимой температуры превышен на " +
                        $"{minViolationsTime / 60} часов, {minViolationsTime % 60} минут";

                    MessageBox.Show("Порог минимально допустимой t превышен!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(mtb_date.Text);
                sw.WriteLine(tb_tempratures.Text);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                mtb_date.Text = sr.ReadLine();
                tb_tempratures.Text =  sr.ReadLine();
            }
        }
    }
}
