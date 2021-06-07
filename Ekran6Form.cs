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
    public partial class Ekran6Form : Form
    {
        public Ekran6Form()
        {
            InitializeComponent();
        }

        private void Ekran6Form_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbDers.DataSource = db.Derslers.ToList();
            cmbDers.DisplayMember = "dersAd";
            cmbDers.ValueMember = "dersID";

            cmbOgrenciNo.DataSource = db.Ogrencilers.ToList();
            cmbOgrenciNo.DisplayMember = "ogrenciAd";
            cmbOgrenciNo.ValueMember = "ogrenciID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            var veriler = db.Notlars.Select(not => new { dersID = not.dersID, 
                ogrenciID = not.ogrenciID, vize = not.vize, final = not.final });
            dataGridView1.DataSource = veriler.ToList();
        }

        public void VeriListele2()
        {
            int ders_id = (int)cmbDers.SelectedValue;
            Model1 db = new Model1();
            var veriler = db.Notlars.Select(not => new { dersID = not.dersID, 
                ogrenciID = not.ogrenciID, vize = not.vize, 
                final = not.final }).Where(not => not.dersID == ders_id);
            dataGridView1.DataSource = veriler.ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            VeriListele2();
        }

        private void btnHepsiniGoster_Click(object sender, EventArgs e)
        {
            VeriListele();
        }

        public void clearAll()
        {
            txbVize.Clear();
            txbFinal.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Notlar not = new Notlar();
            not.dersID = (int)cmbDers.SelectedValue;
            not.ogrenciID = (int)cmbOgrenciNo.SelectedValue;
            not.vize = Int16.Parse(txbVize.Text);
            not.final = Int16.Parse(txbFinal.Text);
            db.Notlars.Add(not);
            db.SaveChanges();
            VeriListele2();
            clearAll();
        }
        /*
        public void sil()
        {
            Model1 db = new Model1();
            Notlar silinecek_ogrenci = db.Notlars.SingleOrDefault(ogrenci => ogrenci.vize == 95 && ogrenci.final == 10);
            db.Notlars.Remove(silinecek_ogrenci);
            db.SaveChanges();
        }*/
    }
}
