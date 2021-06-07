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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEkran1_Click(object sender, EventArgs e)
        {
            OgrencilerForm ogrencilerForm = new OgrencilerForm();
            ogrencilerForm.ShowDialog();
        }

        private void btnEkran2_Click(object sender, EventArgs e)
        {
            DerslerForm derslerForm = new DerslerForm();
            derslerForm.ShowDialog();
        }

        private void btnEkran3_Click(object sender, EventArgs e)
        {
            BolumlerForm bolumlerForm = new BolumlerForm();
            bolumlerForm.ShowDialog();
        }

        private void btnEkran4_Click(object sender, EventArgs e)
        {
            Ekran4Form ekran4Form = new Ekran4Form();
            ekran4Form.ShowDialog();
        }

        private void btnEkran5_Click(object sender, EventArgs e)
        {
            Ekran5Form ekran5Form = new Ekran5Form();
            ekran5Form.ShowDialog();
        }

        private void btnEkran6_Click(object sender, EventArgs e)
        {
            Ekran6Form ekran6Form = new Ekran6Form();
            ekran6Form.ShowDialog();
        }
    }
}
