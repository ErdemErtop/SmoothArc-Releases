using SmoothArc.tools;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmoothArc
{

    public partial class form_login : Form
    {
        DBconnection connection = new DBconnection();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

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
        private void LoginError()
        {
            label3.Show();
            textbox_username.BorderColor = Color.Red;
            textbox_pass.BorderColor = Color.Red;
        }
 

        public form_login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            CheckForUpdates();
        }


        void rememberCheck()
        {
            if (check_remember.Checked)
            {
                Properties.Settings.Default.username = textbox_username.Text;
                Properties.Settings.Default.password = textbox_pass.Text;
            }
        }
        void Login()
        {
            string pass = MD5Hash(MD5Hash(textbox_pass.Text));
            form_loading loading = new form_loading();
            this.Cursor = Cursors.WaitCursor;
            DataTable ogrenciler = new DataTable();
            DataTable egitmenler = new DataTable();
            if(String.IsNullOrEmpty(textbox_pass.Text) || String.IsNullOrEmpty(textbox_username.Text))
            {
                LoginError();
            }
            else
            {
                egitmenler = connection.query("SELECT * FROM `egitmenler` WHERE `sorumlu_email`= '" + textbox_username.Text + "' AND `sorumlu_parola`= '" + textbox_pass.Text + "'");
                ogrenciler = connection.query("SELECT * FROM `musteriler` WHERE `sorumlu_email`= '" + textbox_username.Text + "' AND `sorumlu_parola`= '" + pass + "'");
            }
            if (egitmenler.Rows.Count == 1)
            {
                this.Hide();
                rememberCheck();
                Properties.Settings.Default.TeacherMode = true;
                Properties.Settings.Default.id = egitmenler.Rows[0].ItemArray[0].ToString();
                Properties.Settings.Default.Name = egitmenler.Rows[0].ItemArray[9].ToString();
                Properties.Settings.Default.Surname = egitmenler.Rows[0].ItemArray[10].ToString();
                Properties.Settings.Default.Email = egitmenler.Rows[0].ItemArray[12].ToString();
                Properties.Settings.Default.Phone = egitmenler.Rows[0].ItemArray[15].ToString();
                Properties.Settings.Default.il = int.Parse(egitmenler.Rows[0].ItemArray[17].ToString());
                Properties.Settings.Default.ilce = int.Parse(egitmenler.Rows[0].ItemArray[18].ToString());
                Properties.Settings.Default.Save();
                loading.label1.Text = Properties.Settings.Default.Name.ToUpper() + " " + Properties.Settings.Default.Surname.ToUpper().First() + ".";
                loading.Show();
                loading.ShowMenu();

            }
            else if (ogrenciler.Rows.Count == 1)
            {
                this.Hide();
                rememberCheck();
                Properties.Settings.Default.TeacherMode = false;
                Properties.Settings.Default.id = ogrenciler.Rows[0].ItemArray[0].ToString();
                Properties.Settings.Default.Name = ogrenciler.Rows[0].ItemArray[9].ToString();
                Properties.Settings.Default.Surname = ogrenciler.Rows[0].ItemArray[10].ToString();
                Properties.Settings.Default.Email = ogrenciler.Rows[0].ItemArray[12].ToString();
                Properties.Settings.Default.Phone = ogrenciler.Rows[0].ItemArray[15].ToString();
                Properties.Settings.Default.il = int.Parse(ogrenciler.Rows[0].ItemArray[17].ToString());
                Properties.Settings.Default.ilce = int.Parse(ogrenciler.Rows[0].ItemArray[18].ToString());
                Properties.Settings.Default.Save();
                loading.label1.Text = Properties.Settings.Default.Name.ToUpper() + " " + Properties.Settings.Default.Surname.ToUpper().First() + ".";
                loading.Show();
                loading.ShowMenu();
            }
            else
            {
                loading.Hide();
                LoginError();
                this.Cursor = Cursors.Default;
            }
        }
    
        private void LinkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void textbox_pass_IconRightClick(object sender, EventArgs e)
        {
            if (textbox_pass.UseSystemPasswordChar == true)
            {
                textbox_pass.UseSystemPasswordChar = false;
                textbox_pass.IconRight = Properties.Resources.göz;
            }
            else
            {
                textbox_pass.UseSystemPasswordChar = true;
                textbox_pass.IconRight = Properties.Resources.göz_closed;

            }
        }
        private void textbox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) Login();
        }

        private  void Form_login_Load(object sender, EventArgs e)
        {
            
            textbox_username.Text = Properties.Settings.Default.username;
            textbox_pass.Text = Properties.Settings.Default.password;
        }
        private async Task CheckForUpdates()
        {
            try
            {
                using (var manager = UpdateManager.GitHubUpdateManager("https://github.com/ErdemErtop/SmoothAcademy/blob/main/Releases"))
                {
                    using (var res = manager.Result)
                    {
                        Console.WriteLine(res);
                        await manager.Result.UpdateApp();

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
  
        }

        private void linkLabel_forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://online.smoothacademy.org/index.php?p=sifremi-unuttum");
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://online.smoothacademy.org/index.php?p=kayit-ol");
        }

        private void textbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((Guna.UI2.WinForms.Guna2TextBox)sender).SelectAll();
            }
        }

        private void textbox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((Guna.UI2.WinForms.Guna2TextBox)sender).SelectAll();
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void form_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }


}



