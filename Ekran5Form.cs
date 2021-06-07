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
    public partial class Ekran5Form : Form
    {
        public Ekran5Form()
        {
            InitializeComponent();
        }

        private void Ekran5Form_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            VeriListele2();
            cmbYil.SelectedIndex = 3;
            cmbYariyil.SelectedIndex = 0;
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            var veriler = db.Notlars.Select(not => new { ogrenciID = not.ogrenciID, dersID = not.dersID });
            dataGridView1.DataSource = veriler.ToList();
        }

        public void VeriListele2()
        {
            Model1 db = new Model1();
            var veriler = db.Notlars.Select(not => new { dersID = not.dersID, 
                ogrenciID = not.ogrenciID, yil = not.yil, yariyil = not.yariyil });
            dataGridView2.DataSource = veriler.ToList();
        }

        private void btnOgrenciGoster_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            if(txbOgrenciNo.Text != "")
            {
                int ogrenci_no = Int16.Parse(txbOgrenciNo.Text);
                var veriler = db.Notlars.Select(not => new { ogrenciID = not.ogrenciID, 
                    dersID = not.dersID }).Where(not => not.ogrenciID == ogrenci_no);
                dataGridView1.DataSource = veriler.ToList();
            }
        }

        private void btnHepsiniGoster_Click(object sender, EventArgs e)
        {
            txbOgrenciNo.Clear();
            VeriListele();
        }

        private void btnDersGoster_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string yil = cmbYil.Text;
            string yariyil = cmbYariyil.Text;
            var veriler = db.Notlars.Select(not => new { 
                dersID = not.dersID, 
                ogrenciID = not.ogrenciID, 
                yil = not.yil, 
                yariyil = not.yariyil }).Where(not => not.yil == yil && not.yariyil == yariyil);
            var deneme = veriler.GroupBy(x => x.dersID).Select(x => new { dersID = x.Key,
                ogrenciSayisi = x.Count().ToString() }).ToList();
            dataGridView2.DataSource = deneme.ToList();
        }

        private void btnHepsiniGoster2_Click(object sender, EventArgs e)
        {
            VeriListele2();
        }
    }
}
