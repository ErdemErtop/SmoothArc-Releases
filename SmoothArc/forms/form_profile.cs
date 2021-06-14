using SmoothArc.forms;
using SmoothArc.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmoothArc
{
    public partial class form_profile : Form
    {
        DBconnection connection = new DBconnection();

        public form_profile()
        {
            InitializeComponent();
            textbox_name.Text = Properties.Settings.Default.Name;
            textbax_surname.Text = Properties.Settings.Default.Surname;
            textbox_phone.Text = Properties.Settings.Default.Phone;
            textbox_email.Text = emailName(Properties.Settings.Default.Email.ToString());
            string emaidomain = emailDomain(Properties.Settings.Default.Email.ToString());
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == emaidomain)
                {
                    comboBox1.SelectedIndex = i;
                }
                else comboBox1.Text = emaidomain;
            }
            Combobox_fill(Properties.Settings.Default.il);
            comboBox_il.SelectedIndex = Properties.Settings.Default.il - 1;
        }

        private string emailName(string email)
        {

            char[] charEmail = new char[email.Length];
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] != '@')
                {
                    charEmail[i] = email[i];
                }

            }
            string finalEmail = new string(charEmail);
            finalEmail.Trim();
            return finalEmail;
        }
        private string emailDomain(string email)
        {
            int index = 0;

            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@') index = i;
            }
            List<char> charEmail = new List<char>();

            for (int i = index + 1; i < email.Length; i++)
            {
                charEmail.Add(email[i]);

            }

            char[] chEmail = new char[charEmail.Count];
            for (int i = 0; i < charEmail.Count; i++)
            {
                chEmail[i] = charEmail[i];

            }



            string finalEmail = new string(chEmail);
            finalEmail.Replace("?", string.Empty);
            finalEmail.Trim();
            return finalEmail;
        }
        public void Combobox_fill(int index)
        {
            DataTable iller = new DataTable();
            DataTable ilceler = new DataTable();
            iller = connection.query("SELECT * FROM `il`");
            ilceler = connection.query("SELECT * FROM `ilce` WHERE `il_id`=" + index);
            for (int i = 0; i < iller.Rows.Count; i++)
            {
                comboBox_il.Items.Add(iller.Rows[i].ItemArray[1]);
            }
            comboBox_ilce.Items.Clear();
            for (int i = 0; i < ilceler.Rows.Count; i++)
            {
                comboBox_ilce.Items.Add(ilceler.Rows[i].ItemArray[2]);
                if (ilceler.Rows[i].ItemArray[0].ToString() == Properties.Settings.Default.ilce.ToString())
                {
                    comboBox_ilce.SelectedIndex = i;
                }
                else comboBox_ilce.SelectedIndex = 0;
            }


        }
        public int ilID()
        {
            DataTable il = connection.query("SELECT `id` FROM `il` WHERE `il_adi` = '" + comboBox_il.SelectedItem + "'");
            int id = int.Parse(il.Rows[0].ItemArray[0].ToString());
            return id;
        }
        public int ilceID()
        {
            DataTable ilce = connection.query("SELECT `id` FROM `ilce` WHERE `ilce_adi` = '" + comboBox_ilce.SelectedItem + "'");
            int id = int.Parse(ilce.Rows[0].ItemArray[0].ToString());
            return id;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string email = textbox_email.Text + "@" + comboBox1.Text;
            if (Properties.Settings.Default.TeacherMode == false)
            {
                connection.NonQuery("UPDATE `musteriler` SET `sorumlu_ad` = '" + textbox_name.Text + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `musteriler` SET `sorumlu_soyad` = '" + textbax_surname.Text + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `musteriler` SET `sorumlu_email` = '" + email + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `musteriler` SET `sorumlu_gsm` = '" + textbox_phone.Text + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `musteriler` SET `il_id` = '" + ilID().ToString() + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `musteriler` SET `ilce_id` = '" + ilceID().ToString() + "' WHERE `musteriler`.`id` =" + Properties.Settings.Default.id);

            }
            if (Properties.Settings.Default.TeacherMode == true)
            {
                connection.NonQuery("UPDATE `egitmenler` SET `sorumlu_ad` = '" + textbox_name.Text + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `egitmenler` SET `sorumlu_soyad` = '" + textbax_surname.Text + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `egitmenler` SET `sorumlu_email` = '" + email + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `egitmenler` SET `sorumlu_gsm` = '" + textbox_phone.Text + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `egitmenler` SET `il_id` = '" + ilID().ToString() + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
                connection.NonQuery("UPDATE `egitmenler` SET `ilce_id` = '" + ilceID().ToString() + "' WHERE `egitmenler`.`id` =" + Properties.Settings.Default.id);
            }
            Properties.Settings.Default.Name = textbox_name.Text;
            Properties.Settings.Default.Surname = textbax_surname.Text;
            Properties.Settings.Default.Email = email;
            Properties.Settings.Default.Phone = textbox_phone.Text;
            Properties.Settings.Default.il = ilID();
            Properties.Settings.Default.ilce = ilceID();
            new form_message("Profiliniz Güncellendi!", false).Show();
            this.Refresh();






        }
        private void comboBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_fill(comboBox_il.SelectedIndex + 1);
        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable pass = new DataTable();
            DataTable ogrenciler = new DataTable();
            String password;
            if (Properties.Settings.Default.TeacherMode==true)
            {
                pass = connection.query("SELECT `sorumlu_parola` FROM `egitmenler` WHERE `id`= '" + Properties.Settings.Default.id + "'");
                password = textbox_pass.Text;
            }
            else
            {
                pass = connection.query("SELECT `sorumlu_parola` FROM `musteriler` WHERE `id`= '" + Properties.Settings.Default.id + "'");
                password = MD5Hash(MD5Hash(textbox_pass.Text));
            }
            if (pass.Rows[0].ItemArray[0].ToString() == password)
            {
                if(textbox_newpass.Text==textbox_newpass2.Text) 
                {
                    if(textbox_pass.Text.Length>=6)
                    {
                        if (Properties.Settings.Default.TeacherMode == true)
                        {
                            connection.NonQuery("UPDATE `egitmenler` SET `sorumlu_parola`='" + textbox_newpass.Text + "' WHERE `id`=" + Properties.Settings.Default.id);
                            textbox_pass.Text = "";
                            textbox_newpass.Text = "";
                            textbox_newpass2.Text = "";
                            new form_message("Parolanız Değiştirildi", false).Show();
                        }
                        else
                        {
                            connection.NonQuery("UPDATE `musteriler` SET `sorumlu_parola`='" + MD5Hash(MD5Hash(textbox_newpass.Text)) + "' WHERE `id`=" + Properties.Settings.Default.id);
                            textbox_pass.Text = "";
                            textbox_newpass.Text = "";
                            textbox_newpass2.Text = "";
                            new form_message("Parolanız Değiştirildi", false).Show();
                        }
                    }
                    else new form_message("Parola 6 karakter veya daha uzun olmalıdır", false).Show();



                }
                else
                {
                    new form_message("Parolalar Aynı Değil!", false).Show();
                }
            }
            else new form_message("Parola Doğru Değil!", false).Show();

        }
    }
}