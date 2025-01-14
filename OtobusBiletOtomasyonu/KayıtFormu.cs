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
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void KayıtFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen ana ekrandan yolcuyu kaydetmeyi unutmayınız !" , "UYARI",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
