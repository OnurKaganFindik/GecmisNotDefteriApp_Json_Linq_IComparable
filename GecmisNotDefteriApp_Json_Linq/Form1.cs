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
        public Form1()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            string ara = txtAra.Text.Trim().ToLower();
            bool sadeceFav = chkSadeceFavoriler.Checked;

                lstMesajlar.DataSource = _mesajlar
                    .Where(x => (!sadeceFav|| x.YildizliMi) && 
                                (ara=="" ||x.Icerik.ToLower().Contains(ara)))
                                .ToList();
            
        }

        private void VerileriOku()
        {
            _mesajlar = new List<Mesaj>();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var icerik = txtMesaj.Text.Trim();

            if (icerik == "")
            {
                MessageBox.Show("Lütfen bir mesaj giriniz.");
                return;
            }
            _mesajlar.Add(new Mesaj(icerik));
            _mesajlar.Sort();
            txtMesaj.Clear();
            Listele();
        }

        private void txtMesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEkle.PerformClick();
            }
        }

        private void lstMesajlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                SeciliyiSil();
            }
        }

        private void SeciliyiSil()
        {
            if (lstMesajlar.SelectedIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Seçili mesajı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    Mesaj mesaj = (Mesaj)lstMesajlar.SelectedItem;
                    _mesajlar.Remove(mesaj);
                }
            }
        }

        private void lstMesajlar_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lstMesajlar.IndexFromPoint(e.Location);
            if (index > -1 && e.Button == MouseButtons.Right)
            {
                lstMesajlar.SelectedIndex = index;
                Mesaj mesaj = (Mesaj)lstMesajlar.Items[index];
                tsmiFavori.Text = mesaj.YildizliMi ? "Favorilerden Kaldır" : "Favorilere Ekle";
                cmsMesajlar.Show(Cursor.Position);
            }


        }

        private void cmsMesajlar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem == tsmiSil)
            {
                SeciliyiSil();
            }
            else if (e.ClickedItem==tsmiFavori)
            {
                SeciliFavoriGuncelle();
            }
            else if (e.ClickedItem==tsmiDuzenle)
            {
                SeciliyiDuzenle();
            }

        }

        private void SeciliFavoriGuncelle()
        {
            if (lstMesajlar.SelectedIndex>-1)
            {
                Mesaj mesaj = (Mesaj)lstMesajlar.SelectedItem;
                mesaj.YildizliMi = !mesaj.YildizliMi;
                Listele();
            }
        }

        private void chkSadeceFavoriler_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void lstMesajlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstMesajlar.IndexFromPoint(e.Location);

            if (index>-1&& e.Button==MouseButtons.Left)
            {
                SeciliyiDuzenle();
            }
        }

        private void SeciliyiDuzenle()
        {
            if (lstMesajlar.SelectedIndex>-1)
            {
                Mesaj mesaj = (Mesaj)lstMesajlar.SelectedItem;
                new DuzenleForm(mesaj).ShowDialog();
                Listele();
            }
        }
    }
}
