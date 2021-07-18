using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GecmisNotDefteriApp_Json_Linq
{
    public partial class Form1 : Form
    {
        private List<Mesaj> _mesajlar;
        private BindingList<Mesaj> _blMesajlar;
        public Form1()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            lstMesajlar.DataSource = _blMesajlar;
        }

        private void VerileriOku()
        {
            _mesajlar = new List<Mesaj>();
            _blMesajlar = new BindingList<Mesaj>(_mesajlar);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var icerik = txtMesaj.Text;

            if (icerik=="")
            {
                MessageBox.Show("Lütfen bir mesaj giriniz.");
                return;
            }
            _blMesajlar.Add(new Mesaj(icerik));
            txtMesaj.Clear();
        }

        private void txtMesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEkle.PerformClick();
            }
        }
    }
}
