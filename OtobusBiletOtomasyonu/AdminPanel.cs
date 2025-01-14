using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletOtomasyonu
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Admin paneldeki çıkış butonunun fonksiyonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("ADMİN PANEL kapanacak, onaylıyor musunuz ?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    throw new AccessViolationException();
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    throw new AggregateException();
                }
                if (dialogResult == DialogResult.None)
                {
                    throw new AggregateException();
                }
            }
            catch (AccessViolationException ex)
            {
                this.Close();
            }
            catch (AggregateException ex)
            {

            }
        }

        private void cmbOtobusSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            YolcuBilgileriniGetir();
        }

        // Listviewdan seçilen yolcuların bilgilerinin getirilmesini sağlar
        public void YolcuBilgileriniGetir()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtAIsim.Text = selectedItem.Text;
                mskdATelefon.Text = selectedItem.SubItems[1].Text;
                txtACinsiyet.Text = selectedItem.SubItems[2].Text;
                txtANereden.Text = selectedItem.SubItems[3].Text;
                txtAKoltukNo.Text = selectedItem.SubItems[4].Text;
                dtpATarih.Text = selectedItem.SubItems[5].Text;
                txtAFiyat.Text = selectedItem.SubItems[6].Text;
                txtAFirma.Text = selectedItem.SubItems[7].Text;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void txtAKoltukNo_TextChanged(object sender, EventArgs e)
        {

        }


        //Admin Paneldeki kullanıcılardan silme işlemi yapmamızı sağlar
        private void silBttn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult onay = MessageBox.Show(
                    "Seçili kullanıcıyı silmek istediğinizden emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (onay == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    listView1.Items.Remove(selectedItem);
                    MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtAFirma.Text = "";
            txtAIsim.Text = "";
            txtANereden.Text = "";
            txtACinsiyet.Text = "";
            txtAKoltukNo.Text = "";
            txtAFiyat.Text = "";
            dtpATarih.Format = DateTimePickerFormat.Custom;
            dtpATarih.CustomFormat = " ";
            dtpATarih.Value = DateTime.Now; 
            mskdATelefon.Text = "";
        }
    }
}
