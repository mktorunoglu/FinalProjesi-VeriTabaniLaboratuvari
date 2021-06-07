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
    public partial class Ekran4Form : Form
    {
        int not_id = 0;

        public Ekran4Form()
        {
            InitializeComponent();
        }

        private void Ekran4Form_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbOgrenciNo.DataSource = db.Ogrencilers.ToList();
            cmbOgrenciNo.DisplayMember = "ogrenciID";
            cmbOgrenciNo.ValueMember = "ogrenciID";

            cmbBolum.DataSource = db.Bolumlers.ToList();
            cmbBolum.DisplayMember = "bolumAd";
            cmbBolum.ValueMember = "bolumID";

            cmbYil.SelectedIndex = 3;
            cmbYariyil.SelectedIndex = 0;

            cmbBolum.SelectedIndex = 0;
            int bolum_id = (int)cmbBolum.SelectedValue;
            var gosterilecek_dersler = db.Derslers.Where(ders => ders.bolumID == bolum_id);
            cmbDers.DataSource = gosterilecek_dersler.ToList();
            cmbDers.DisplayMember = "dersAd";
            cmbDers.ValueMember = "dersID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            var veriler = db.Notlars.Select(not => new { ogrenciID = not.ogrenciID, dersID = not.dersID, yil = not.yil, yariyil = not.yariyil, notID = not.notID });
            dataGridView1.DataSource = veriler.ToList();
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string bolum_ad = cmbBolum.Text;
            var bolum_id_db = db.Bolumlers.Where(bolum => bolum.bolumAd == bolum_ad);
            cmbDers.DataSource = bolum_id_db.ToList();
            cmbDers.DisplayMember = "bolumID";
            cmbDers.ValueMember = "bolumID";
            string bolum_id_str = cmbDers.Text;
            int bolum_id = 0;
            Int32.TryParse(bolum_id_str, out bolum_id);
            var gosterilecek_dersler = db.Derslers.Where(ders => ders.bolumID == bolum_id);
            cmbDers.DataSource = gosterilecek_dersler.ToList();
            cmbDers.DisplayMember = "dersAd";
            cmbDers.ValueMember = "dersID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            not_id = (int)row.Cells["notID"].Value;
            cmbOgrenciNo.SelectedValue = row.Cells["ogrenciID"].Value;
            cmbYil.SelectedValue = row.Cells["yil"].Value;
            cmbYariyil.SelectedValue = row.Cells["yariyil"].Value;
            cmbDers.SelectedValue = row.Cells["dersID"].Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Notlar not = new Notlar();
            not.ogrenciID = (int)cmbOgrenciNo.SelectedValue;
            not.dersID = (int)cmbDers.SelectedValue;
            not.yil = cmbYil.Text;
            not.yariyil = cmbYariyil.Text;
            db.Notlars.Add(not);
            db.SaveChanges();
            VeriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Notlar guncellenecek_not = db.Notlars.SingleOrDefault(not => not.notID == not_id);
            guncellenecek_not.ogrenciID = (int)cmbOgrenciNo.SelectedValue;
            guncellenecek_not.dersID = (int)cmbDers.SelectedValue;
            guncellenecek_not.yil = cmbYil.Text;
            guncellenecek_not.yariyil = cmbYariyil.Text;
            db.SaveChanges();
            VeriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Notlar silinecek_not = db.Notlars.SingleOrDefault(not => not.notID == not_id);
            db.Notlars.Remove(silinecek_not);
            db.SaveChanges();
            VeriListele();
        }
    }
}
