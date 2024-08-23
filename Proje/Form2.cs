using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C://Users//duygu//Desktop//Gelir_Gider.accdb;Persist Security Info=False");

            using (baglanti)
            {
                baglanti.Open();

                string queryGelirGider = "SELECT ISLEMTIPI, SUM(TUTAR) AS TUTAR FROM Gelir_Gider GROUP BY ISLEMTIPI";

                OleDbDataAdapter daGelirGider = new OleDbDataAdapter(queryGelirGider, baglanti);
                DataTable dtGelirGider = new DataTable();
                daGelirGider.Fill(dtGelirGider);

                string queryGelirTipleri = "SELECT GIDERTIPI, SUM(TUTAR) AS TUTAR FROM Gelir_Gider WHERE ISLEMTIPI = 'Gider' GROUP BY GIDERTIPI";
                OleDbDataAdapter daGelirTipleri = new OleDbDataAdapter(queryGelirTipleri, baglanti);
                DataTable dtGelirTipleri = new DataTable();
                daGelirTipleri.Fill(dtGelirTipleri);

                chart1.Series.Clear();
                Series gelirGiderOranlari = new Series("Gelir-Gider Oranları");
                gelirGiderOranlari.ChartType = SeriesChartType.Pie; // Pasta grafik
                foreach (DataRow row in dtGelirGider.Rows)
                {
                    gelirGiderOranlari.Points.AddXY(row["ISLEMTIPI"].ToString(), Convert.ToDouble(row["TUTAR"]));
                }
                chart1.Series.Add(gelirGiderOranlari);
                chart1.Titles.Clear();
                chart1.Titles.Add("Gelir-Gider Oranları");


                Series giderTipleriSerisi = new Series("Gider Tipleri");
                giderTipleriSerisi.ChartType = SeriesChartType.Column; // Çubuk grafik
                foreach (DataRow row in dtGelirTipleri.Rows)
                {
                    giderTipleriSerisi.Points.AddXY(row["GIDERTIPI"].ToString(), Convert.ToDouble(row["TUTAR"]));
                }

                ChartArea chartArea2 = new ChartArea();
                chart2.ChartAreas.Add(chartArea2);
                chart2.Series.Add(giderTipleriSerisi);
                chart2.Titles.Add("Gider Tipleri");

                chart2.ChartAreas[0].AxisX.Title = "Gider Tipleri";
                chart2.ChartAreas[0].AxisY.Title = "Tutar";
            }
        }
    }
}
    
