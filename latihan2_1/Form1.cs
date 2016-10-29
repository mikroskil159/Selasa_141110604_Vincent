using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = 2020;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = Bulan.SelectedIndex;

            int[] bulanLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (n >= 1996)
            {
                monthCalendar1.RemoveBoldedDate(new DateTime(n, bulanLengkap[bulan], tanggal));
                n--;
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 2020;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = Bulan.SelectedIndex;

            int[] bulanLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (n >= 1996)
            {
                monthCalendar1.AddBoldedDate(new DateTime(n, bulanLengkap[bulan], tanggal));
                n--;
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 1996;
            bool cek = true;
            while (cek)
            {
                DateTime awal = new DateTime(n, 1, 1);
                monthCalendar1.AddBoldedDate(new DateTime(n, 3, 18));

                n++;
                if (n == 2018)
                {
                    cek = false;
                }

            }

            DateTime tanggal = new DateTime(2016, 2, 3);
            for (double i = 0; i <= 6; i++)
            {
                tanggal = tanggal.AddDays(i);
                if (tanggal.DayOfWeek == DayOfWeek.Saturday || tanggal.DayOfWeek == DayOfWeek.Sunday)
                {
                    while (tanggal < new DateTime(2017, 1, 1))
                    {
                        monthCalendar1.AddBoldedDate(tanggal);
                        monthCalendar1.AddBoldedDate(tanggal.AddDays(1));
                        tanggal = tanggal.AddDays(7);
                        monthCalendar1.AddBoldedDate(new DateTime(n, 3, 18));

                    }

                }
            }

            monthCalendar1.UpdateBoldedDates();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
