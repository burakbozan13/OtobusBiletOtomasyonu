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
    public partial class AdminPanelLoginPage : Form
    {

        //Bu public değişkeni tanımlamamın amacı form1deki admin panelin açılmasına yardımcı olması
       
        public Boolean girisBasarilimi = false;

        public AdminPanelLoginPage()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        //Admin panelde hakkında butonuna tıklayınca oluşacak fonksiyon
        private void aboutBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Paneline Giriş Yapıyorsunuz.\n" 
                , "ADMİN PANEL HAKKINDA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        //Admin panelde çıkış butonuna tıklayınca oluşacak fonksiyon
        private void exitBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bu ekranı kapatmak İstiyor musunuz ?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

                girisBasarilimi = false;
                this.Close();
            }
            catch (AggregateException ex)
            {
                girisBasarilimi = false;
            }
        }


        //Admin panelde giriş yap butonuna tıklayınca çalışacak fonksiyon
        private void loginBttn_Click(object sender, EventArgs e)
        {
            String name = usernameTxtBos.Text;
            String password = passwordTxtBox.Text;

            //Kullanıcı adı ve parola textboxları kontrol eder
            Boolean BoxControl(String namee, String passsword)
            {
                namee = name.Trim();
                passsword = password.Trim();
                try
                {
                    if (String.IsNullOrEmpty(namee))
                    {
                        throw new AccessViolationException();
                    }
                    if (String.IsNullOrEmpty(passsword))
                    {
                        throw new AggregateException();
                    }
                }
                catch (AccessViolationException ex)
                {
                    MessageBox.Show("Kullanıcı adı kısmını lütfen doldurunuz !", "KULLANICI ADI GİRİN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (AggregateException ex)
                {
                    MessageBox.Show("Parola kısmını lütfen doldurunuz !", "PAROLA GİRİN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;

            }


            //Kullanıcın doğru bilgileri girip girmediğini kontrol etmek
            
            
            Boolean UserControl(String namee, String passsword)
            {
                namee = name.Trim();
                passsword = password.Trim();
                try
                {
                    if (!BoxControl(name, password))
                    {
                        throw new AccessViolationException();
                    }
                    // aşağıdaki bilgiler değiştirilerek kullanıcı adı ve şifre değiştirilebilir
                    if (namee == /*Kullanıcı Adı Değiştirmek için yandaki yazıyı değiştir*/"burak"
                        && passsword == /*Parola Değiştirmek için yandaki yazıyı değiştir*/"12345")
                    {
                        throw new AggregateException();
                    }
                }
                catch (AccessViolationException ex)
                {
                    girisBasarilimi = false;
                }
                catch (AggregateException ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Başarılı Giriş", "ADMİN PANEL", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        girisBasarilimi = true;
                        this.Close();
                    }
                    if (dialogResult == DialogResult.None)
                    {
                        girisBasarilimi = true;
                        this.Close();
                    }
                }
                return true;
            }
            UserControl(name, password);
        }
    }
}
