using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti;
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        void listele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C://Users//duygu//Desktop//Gelir_Gider.accdb;Persist Security Info=False");

            try
            {
                baglanti.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatasi " + ex.Message);
                throw;
            }

            OleDbDataAdapter adtr = new OleDbDataAdapter("Select *from Gelir_Gider" + where, baglanti);

            ds.Clear();
            adtr.Fill(ds, "Gelir_Gider");
            dataGridView1.DataSource = ds.Tables["Gelir_Gider"];
            baglanti.Close();

        }

        string tip()
        {
            string tip = "";
            if (rd_btn_gelir.Checked == true)
            {
                tip = "Gelir";
            }
            if (rd_btn_gider.Checked == true)
            {
                tip = "Gider";
            }
            return tip;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string insert = "Insert Into Gelir_Gider (ID,ISLEMTIPI,TARIH,GIDERTIPI,CARI,Tutar,ACIKLAMA) values (@id,@islemtipi,@tarih,@gidertipi,@cari,@tutar,@aciklama)";

            using (OleDbCommand cmd = new OleDbCommand(insert, baglanti))

            {
                cmd.Parameters.AddWithValue("@id", txt_id.Text.ToString());
                if (rd_btn_gelir.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@islemtipi", rd_btn_gelir.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@islemtipi", rd_btn_gider.Text);
                }
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@gidertip", cmb_gdr_tip.Text);
                cmd.Parameters.AddWithValue("@cari", txt_cari.Text);
                cmd.Parameters.AddWithValue("@tutar", txt_tutar.Text.ToString());
                cmd.Parameters.AddWithValue("@aciklama", txt_aciklama.Text);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }

            DataRow newRow = ds.Tables["Gelir_Gider"].NewRow();
            newRow["ID"] = txt_id.Text.ToString();
            newRow["ISLEMTIPI"] = rd_btn_gelir.Checked ? rd_btn_gelir.Text : rd_btn_gider.Text;
            newRow["TARIH"] = dateTimePicker1.Value;
            newRow["GIDERTIPI"] = cmb_gdr_tip.Text;
            newRow["CARI"] = txt_cari.Text;
            newRow["Tutar"] = txt_tutar.Text.ToString();
            newRow["ACIKLAMA"] = txt_aciklama.Text;

            ds.Tables["Gelir_Gider"].Rows.Add(newRow);


            txt_id.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rd_btn_gelir.Checked = false;
            rd_btn_gider.Checked = false;
            cmb_gdr_tip.Text = string.Empty;
            txt_cari.Clear();
            txt_tutar.Clear();
            txt_aciklama.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Dispose();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu " + tip() + " kaydını silmek istediğinzden emin misiniz?", "Onay Verin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "Delete from Gelir_Gider where ID=@id";

                cmd = new OleDbCommand(delete, baglanti);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string update = "Update Gelir_Gider set ISLEMTIPI=@islemtipi, TARIH=@tarih, GIDERTIPI=@gidertip, CARI=@cari, Tutar=@tutar, ACIKLAMA=@acıklama where ID=@id";

            using (OleDbCommand cmd = new OleDbCommand(update, baglanti))
            {
                cmd.Parameters.Add("@islemtipi", OleDbType.VarChar).Value = rd_btn_gelir.Checked ? rd_btn_gelir.Text : rd_btn_gider.Text;
                cmd.Parameters.Add("@tarih", OleDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@gidertip", OleDbType.VarChar).Value = cmb_gdr_tip.SelectedItem?.ToString() ?? string.Empty;
                cmd.Parameters.Add("@cari", OleDbType.VarChar).Value = txt_cari.Text;
                cmd.Parameters.Add("@tutar", OleDbType.Decimal).Value = Convert.ToDecimal(txt_tutar.Text);
                cmd.Parameters.Add("@aciklama", OleDbType.VarChar).Value = txt_aciklama.Text;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = Convert.ToInt32(txt_id.Text);

                baglanti.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip kayıt bulunamadı.");
                }
                baglanti.Close();
            }


        }

       
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;

            string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string islemTip = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string tarih = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string giderTip = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string cari = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string tutar = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string aciklama = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();

            txt_id.Text = id;
            switch (islemTip)
            {
                case "Gelir":
                    rd_btn_gelir.Checked = true;
                    break;
                case "Gider":
                    rd_btn_gider.Checked = true;
                    break;
                default:
                    rd_btn_gelir.Checked = false;
                    rd_btn_gider.Checked = false;
                    break;
            }
            dateTimePicker1.Text = tarih;
            cmb_gdr_tip.Text = giderTip;
            txt_cari.Text = cari;
            txt_tutar.Text = tutar;
            txt_aciklama.Text = aciklama;
        }

        string where = " ";
        private void rd_f_hepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_f_gelir.Checked == true)
            {
                where = " where ISLEMTIPI = 'Gelir'  ";
            }
            if (rd_f_gider.Checked == true)
            {
                where = " where ISLEMTIPI = 'Gider'  ";
            }
            if (rd_f_hepsi.Checked == true)
            {
                where = "   ";
            }
            listele();
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        
        private void btn_filtrele_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Gelir_Gider WHERE 1=1";
            List<OleDbParameter> parameters = new List<OleDbParameter>();

            if (dateTimePicker1.Checked)
            {
                query += " AND TARIH = @tarih";
                parameters.Add(new OleDbParameter("@tarih", dateTimePicker1.Value.Date));
            }

            if (!string.IsNullOrEmpty(cmb_gdr_tip.Text))
            {
                query += " AND GIDERTIPI = @gidertip";
                parameters.Add(new OleDbParameter("@gidertip", cmb_gdr_tip.Text));
            }

            if (!string.IsNullOrEmpty(txt_cari.Text))
            {
                query += " AND CARI = @cari";
                parameters.Add(new OleDbParameter("@cari", txt_cari.Text));
            }

            if (!string.IsNullOrEmpty(txt_tutar.Text))
            {
                query += " AND Tutar = @tutar";
                parameters.Add(new OleDbParameter("@tutar", txt_tutar.Text));
            }

            if (!string.IsNullOrEmpty(txt_aciklama.Text))
            {
                query += " AND ACIKLAMA = @aciklama";
                parameters.Add(new OleDbParameter("@aciklama", txt_aciklama.Text));
            }

            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                query += " AND ID = @id";
                parameters.Add(new OleDbParameter("@id", txt_id.Text));
            }

            using (OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C://Users//duygu//Desktop//Gelir_Gider.accdb;Persist Security Info=False"))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, baglanti);
                foreach (var param in parameters)
                {
                    adapter.SelectCommand.Parameters.Add(param);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }

        private void btn_hatırlatıcı_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.Title = "PDF Dosyası Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPdf(dataGridView1, saveFileDialog.FileName);
                }
            }
        }

        private void ExportDataGridViewToPdf(DataGridView dgv, string fileName)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString());
                    }
                }


                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
            yeni.DataSent += Form2_DataSent;
            this.Hide();
        }

        private void Form2_DataSent(object sender, string data)
        {
            cmb_gdr_tip.Items.Add(data);
        }
    }
}

