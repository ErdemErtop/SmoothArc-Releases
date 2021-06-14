using SmoothArc.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothArc.forms
{
    public partial class form_message : Form
    {
        DBconnection connection = new DBconnection();
        public form_message(string s, bool b)
        {
            InitializeComponent();
            label2.Text = s;
            if (b) label2.Text = "Ders Linki :";
            textbox_teachermode.Visible = b;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable ogrenci = connection.query("SELECT `musteriler`.`ad`,`musteriler`.`sorumlu_gsm`  FROM `musteriler` INNER JOIN `siparisler` ON `musteriler`.`id`=`siparisler`.`musteri_id` WHERE `siparisler`.`egitim_id`= 3 AND `siparisler`.`durum`= 1");
            if (Properties.Settings.Default.TeacherMode==true)
            {
                if(!(String.IsNullOrEmpty(textbox_teachermode.Text)))
                {
                    connection.NonQuery("UPDATE `egitimler` SET `dersLink`='" + textbox_teachermode.Text + "' WHERE `id`= '" + Properties.Settings.Default.egitimID + "'");
                    DataTable ders = connection.query("SELECT `baslik` FROM `egitimler` WHERE `id`=" + Properties.Settings.Default.egitimID);
                    string Ders = ders.Rows[0].ItemArray[0].ToString();
                    for (int i = 0; i < ogrenci.Rows.Count; i++)
                    {
                        string testXml = "<SingleTextSMS><UserName>5528319755</UserName><PassWord>5310104877</PassWord><Action>1</Action><Mesgbody>" + "Sayın " + ogrenci.Rows[i].ItemArray[0].ToString() + " " + Ders + " dersiniz başlamak üzere.</Mesgbody><Numbers>" + ogrenci.Rows[i].ItemArray[1].ToString() + "</Numbers><Originator>SMOOTH</Originator></SingleTextSMS>";
                        this.XmlPost("https://www.mesajpaketi.com/api/mesaj_gonder", "data=" + testXml);
                    }
                }
            }
            Properties.Settings.Default.lectureURL = textbox_teachermode.Text;
            Properties.Settings.Default.Save();
            this.Hide();
        }
        private string XmlPost(string PostAddress, string xmlData)

        {

            using (WebClient wUpload = new WebClient())

            {

                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);

                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);

                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);

                string sWebPage = new string(sReturnChars);

                return sWebPage;

            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void form_message_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
