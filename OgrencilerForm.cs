using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstProject
{
    public partial class OgrencilerForm : Form
    {
        public OgrencilerForm()
        {
            InitializeComponent();
        }

        private void OgrencilerForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbBolum.DataSource = db.Bolumlers.ToList();
            cmbBolum.DisplayMember = "bolumAd";
            cmbBolum.ValueMember = "bolumID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.Ogrencilers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbOgrenciNo.Text = row.Cells["ogrenciID"].Value.ToString();
            txbAd.Text = row.Cells["ad"].Value.ToString();
            txbSoyad.Text = row.Cells["soyad"].Value.ToString();
            cmbBolum.SelectedValue = row.Cells["bolumID"].Value;
        }

        public void clearAll()
        {
            txbOgrenciNo.Clear();
            txbAd.Clear();
            txbSoyad.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            ogrenci.ad = txbAd.Text;
            ogrenci.soyad = txbSoyad.Text;
            ogrenci.bolumID = (int)cmbBolum.SelectedValue;
            db.Ogrencilers.Add(ogrenci);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbOgrenciNo.Text);
            Ogrenciler guncellenecek_ogrenci = db.Ogrencilers.SingleOrDefault(ogrenci => ogrenci.ogrenciID == guncellenecek_id);
            guncellenecek_ogrenci.ogrenciID = Int16.Parse(txbOgrenciNo.Text);
            guncellenecek_ogrenci.ad = txbAd.Text;
            guncellenecek_ogrenci.soyad = txbSoyad.Text;
            guncellenecek_ogrenci.bolumID = (int)cmbBolum.SelectedValue;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbOgrenciNo.Text);
            Ogrenciler silinecek_ogrenci = db.Ogrencilers.SingleOrDefault(ogrenci => ogrenci.ogrenciID == silinecek_id);
            db.Ogrencilers.Remove(silinecek_ogrenci);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}
