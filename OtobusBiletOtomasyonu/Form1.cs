using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OtobusBiletOtomasyonu
{
    public partial class Form1 : Form
    {
        AdminPanelLoginPage adminPanelLoginPage = new AdminPanelLoginPage();
        AdminPanel adminPanel = new AdminPanel();

        private Dictionary<string, List<string>> otobusData = new Dictionary<string, List<string>>()
        {
            { "Metro Turizm", new List<string> { "Mercedes", "MAN", "Otokar" } },
            { "Kamil Koç", new List<string> { "Renault", "BMC", "GMC" } },
            { "Pamukkale Turizm", new List<string> { "Neoplan", "Isuzu", "Temsa" } },
            { "Varan Turizm", new List<string> { "Mercedes", "MAN", "Otokar" } },
            { "Ulusoy Turizm", new List<string> { "Renault", "BMC", "GMC" } },
            { "Nilüfer Turizm", new List<string> { "Neoplan", "Isuzu", "Temsa" } }
        };

        private Dictionary<string, List<string>> plakaData = new Dictionary<string, List<string>>()
        {
            { "Mercedes", new List<string> { "34AB1234", "34DE4569", "34GH7891" } },
            { "MAN", new List<string> { "35JK0125", "35MN3457", "35PA6781" } },
            { "Otokar", new List<string> { "36ST9012", "36VY2349", "36YZ5674" } },
            { "Renault", new List<string> { "37AC1231", "37DF4562", "37YS7894" } },
            { "BMC", new List<string> { "38JL0129", "38MO3455", "38PA6782" } },
            { "GMC", new List<string> { "39SU9018", "39MN2347", "39YA5671" } },
            { "Neoplan", new List<string> { "40AO1237", "40DM4562", "40HT7897" } },
            { "Isuzu", new List<string> { "41KL0125", "41NO3454", "41RS6788" } },
            { "Temsa", new List<string> { "42SU9019", "42YT2342", "42GS5671" } }
        };

        private Dictionary<string, List<string>> rotalar = new Dictionary<string, List<string>>()
        {
            { "34AB1234", new List<string> { "İstanbul - İzmir" } },
            { "34DE4569", new List<string> { "İstanbul - Bursa" } },
            { "34GH7891", new List<string> { "İstanbul - Ankara" } },
            { "35JK0125", new List<string> { "Ankara - Samsun" } },
            { "35MN3457", new List<string> { "Ankara - Adana" } },
            { "35PA6781", new List<string> { "Ankara - Gaziantep" } },
            { "36ST9012", new List<string> { "İzmir - Fethiye" } },
            { "36VY2349", new List<string> { "İzmir - Kayseri" } },
            { "36YZ5674", new List<string> { "İzmir - Aydın" } },
            { "37AC1231", new List<string> { "Çanakkale - Tekirdağ" } },
            { "37DF4562", new List<string> { "Çanakkale - Sakarya" } },
            { "37YS7894", new List<string> { "Çanakkale - Kocaeli" } },
            { "38JL0129", new List<string> { "Amasya - Kırıkkale" } },
            { "38MO3455", new List<string> { "Amasya - Çankırı" } },
            { "38PA6782", new List<string> { "Amasya - Aksaray" } },
            { "39SU9018", new List<string> { "Mersin - Düzce" } },
            { "39MN2347", new List<string> { "Mersin - Bolu" } },
            { "39YA5671", new List<string> { "Mersin - Sakarya" } },
            { "40AO1237", new List<string> { "Mersin - Antalya" } },
            { "40DM4562", new List<string> { "Trabzon - Bodrum" } },
            { "40HT7897", new List<string> { "Trabzon - Muğla" } },
            { "41KL0125", new List<string> { "Trabzon - Mersin" } },
            { "41NO3454", new List<string> { "Trabzon - Gaziantep" } },
            { "41RS6788", new List<string> { "İstanbul - Adana" } },
            { "42SU9019", new List<string> { "İstanbul - Kayseri" } },
            { "42YT2342", new List<string> { "İstanbul - Konya" } },
            { "42GS5671", new List<string> { "İstanbul - Eskişehir" } }
        };

        public Form1()
        {
            InitializeComponent();
            LoadOtobusModel();
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            cmbPlaka.SelectedIndexChanged += cmbPlaka_SelectedIndexChanged;
            cmbOtobusMarka.SelectedIndexChanged += cmbOtobusMarka_SelectedIndexChanged;
            cmbNereye.SelectedIndexChanged += cmbNereye_SelectedIndexChanged;
        }

        private void LoadOtobusModel()
        {
            cmbFirma.Items.Clear();
            foreach (var company in otobusData.Keys)
            {
                if (!cmbFirma.Items.Contains(company)) 
                {
                    cmbFirma.Items.Add(company);
                }
            }
        }

        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlaka.Items.Clear();
            cmbNereye.Items.Clear();
            listView1.Items.Clear();
            cmbOtobusMarka.Items.Clear();

            if (cmbFirma.SelectedItem != null)
            {
                string selectedBus = cmbFirma.SelectedItem.ToString();

                HashSet<string> addedModels = new HashSet<string>();

                foreach (var model in otobusData[selectedBus])
                {
                    if (!addedModels.Contains(model))
                    {
                        cmbOtobusMarka.Items.Add(model);
                        addedModels.Add(model);
                    }
                }

                switch (selectedBus)
                {
                    case "Metro Turizm": KoltukDoldur(10, false); break;
                    case "Kamil Koç": KoltukDoldur(12, true); break;
                    case "Pamukkale Turizm": KoltukDoldur(8, false); break;
                    case "Varan Turizm": KoltukDoldur(10, false); break;
                    case "Ulusoy Turizm": KoltukDoldur(12, true); break;
                    case "Nilüfer Turizm": KoltukDoldur(8, false); break;
                }
            }
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNereye.Items.Clear();
            listView1.Items.Clear();

            if (cmbPlaka.SelectedItem != null)
            {
                string selectedPlate = cmbPlaka.SelectedItem.ToString();
                if (rotalar.ContainsKey(selectedPlate))
                {
                    foreach (var route in rotalar[selectedPlate])
                    {
                        string destination = route.Trim();
                        if (!cmbNereye.Items.Contains(destination))
                        {
                            cmbNereye.Items.Add(destination);
                        }
                    }
                }
            }
        }

        private void KoltukDoldur(int sira, bool arkaBesliMi)
        {
            foreach (Control ctrl in this.Controls.OfType<Button>().Where(b => b.Text != "KAYDET" && b.Text != "ADMİN PANEL").ToList())
            {
                this.Controls.Remove(ctrl);
            }

            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arkaBesliMi && i != sira - 1 && j == 2) continue;
                    if (!arkaBesliMi && j == 2) continue;

                    Button koltuk = new Button
                    {
                        Height = 40,
                        Width = 40,
                        Top = 30 + (i * 45),
                        Left = 5 + (j * 45),
                        Text = koltukNo.ToString()
                    };
                    koltukNo++;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += Koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }

        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbFirma.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz");
                return;
            }
            KayıtFormu kf = new KayıtFormu();
            ListViewItem yolcular = new ListViewItem();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                yolcular.Text = string.Format("{0} {1}", kf.txtIsim.Text, kf.txtSoyisim.Text);
                yolcular.SubItems.Add(kf.mskdTelefon.Text);
                if (kf.rdbBay.Checked)
                {
                    yolcular.SubItems.Add("BAY");
                    tiklanan.BackColor = Color.Blue;
                }
                if (kf.rdbBayan.Checked)
                {
                    yolcular.SubItems.Add("BAYAN");
                    tiklanan.BackColor = Color.Red;
                }
                yolcular.SubItems.Add(cmbNereye.Text);
                yolcular.SubItems.Add(tiklanan.Text); 
                yolcular.SubItems.Add(dtpTarih.Text);
                yolcular.SubItems.Add(nudFiyat.Value.ToString());
                yolcular.SubItems.Add(cmbFirma.Text.ToString());
                yolcular.SubItems.Add(cmbOtobusMarka.Text.ToString());
                yolcular.SubItems.Add(cmbPlaka.Text.ToString());
                listView1.Items.Add(yolcular);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanelLoginPage.ShowDialog();
            if (adminPanelLoginPage.girisBasarilimi == true)
            {
                adminPanel.ShowDialog();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlaka.Items.Clear();
            cmbNereye.Items.Clear();
            listView1.Items.Clear();
            cmbOtobusMarka.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen kaydetmek istediğiniz kullanıcıyı yan menüden seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                adminPanel.listView1.Items.Add((ListViewItem)selectedItem.Clone());
            }
        }

        private void cmbOtobusMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlaka.Items.Clear();
            listView1.Items.Clear();

            if (cmbOtobusMarka.SelectedItem != null)
            {
                string selectedBusModel = cmbOtobusMarka.SelectedItem.ToString();
                foreach (var plate in plakaData[selectedBusModel])
                {
                    cmbPlaka.Items.Add(plate);
                }
            }
        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlaka.Items.Clear();
            listView1.Items.Clear();
            cmbOtobusMarka.Items.Clear();

            if (cmbNereye.SelectedItem != null)
            {
                string selectedDestination = cmbNereye.SelectedItem.ToString();

                HashSet<string> addedModels = new HashSet<string>();
                HashSet<string> addedPlates = new HashSet<string>();

                foreach (var company in otobusData.Keys)
                {
                    foreach (var model in otobusData[company])
                    {
                        foreach (var plate in plakaData[model])
                        {
                            if (rotalar.ContainsKey(plate))
                            {
                                foreach (var route in rotalar[plate])
                                {
                                    if (route.Contains(selectedDestination))
                                    {
                                        if (!addedModels.Contains(model))
                                        {
                                            cmbOtobusMarka.Items.Add(model);
                                            addedModels.Add(model);
                                        }
                                        if (!addedPlates.Contains(plate))
                                        {
                                            cmbPlaka.Items.Add(plate);
                                            addedPlates.Add(plate);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}