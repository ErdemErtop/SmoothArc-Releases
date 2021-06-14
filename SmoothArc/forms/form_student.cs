using DevExpress.XtraBars.Localization;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler.Localization;
using SmoothArc.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPressPCL;
using WordPressPCL.Models;
using SmoothArc.tools;

namespace SmoothArc
{
    

    public partial class form_student : Form
    {
        private Form activeForm;
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
        public form_student()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
            label_name.Text = Properties.Settings.Default.Name.ToUpper() + " " + Properties.Settings.Default.Surname.ToUpper().First() + ".";
        }
        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.Transparent;
        }
        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }
        private static async Task<WordPressClient> GetClient()
        {
            // JWT authentication
            var client = new WordPressClient("https://www.smoothacademy.org/wp-json");
            client.AuthMethod = AuthMethod.JWT;
            await client.RequestJWToken("emirr", "%xtHF7MEdcz@Mbi$RdTmuQ6*");
            return client;
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            pictureBox2.Show();
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_selectedForm.Controls.Add(childForm);
            this.panel_selectedForm.Tag = childForm;
            labelTitle.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();

        }
        private void panel_profile_MouseMove(object sender, MouseEventArgs e)
        {
            panel_profile_logo.BackColor = Color.DimGray;
        }
        private void panel_profile_MouseLeave(object sender, EventArgs e)
        {
            panel_profile_logo.BackColor = Color.Transparent;
        }
        private void circlePicturebox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel_profile_logo.BackColor = Color.DimGray;
        }
        private void circlePicturebox1_MouseLeave(object sender, EventArgs e)
        {
            panel_profile_logo.BackColor = Color.Transparent;
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            panel_profile_logo.BackColor = Color.DimGray;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel_profile_logo.BackColor = Color.Transparent;
        }
        private void btn_announce_close_Click(object sender, EventArgs e)
        {
            panel_announce.Hide();
            btn_announce_open.Show();

        }
        private void btn_announce_open_Click(object sender, EventArgs e)
        {
            btn_announce_open.Hide();
            panel_announce.Show();
        }
        private void panel_profile_logo_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new form_profile(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;


        }
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new form_profile(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;
        }
        private void circlePicturebox1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new form_profile(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;
        }
        private void button_name_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_questions(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;
        }
        private void button_calendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_calendar(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;
        }
        private void button_student_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_lectures(), sender);
            if (Properties.Settings.Default.TeacherMode == true)
            {
                panel1.Visible = true;
                ToggleSwitch.Checked=false;
            }

        }
        List<string> links = new List<string>();
        private async void form_student_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://tawk.to/chat/602cddc3918aa261273fac00/1eunk4gsp");
            try
            {
                WordPressClient client = await GetClient();
                var posts = await client.Posts.GetAll();
                for (int i = 0; i < posts.ToList().Count; i++)
                {
                    listBox.Items.Add(posts.ToList()[i].Title.Rendered);
                    links.Add(posts.ToList()[i].Link);

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(links[listBox.SelectedIndex]);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            if (panel_help.Visible == true) panel_help.Visible = false;
            else panel_help.Visible = true;
        }

        private void chromiumWebBrowser1_Paint(object sender, PaintEventArgs e)
        {

            chromiumWebBrowser1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, chromiumWebBrowser1.Width, chromiumWebBrowser1.Height, 25, 25));
        }



        private void btn_allLectures_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form_lecturesAll(), sender);
        }

        private void button_exit_MouseHover(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.Transparent;
        }

        private void button_exit_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void form_student_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel_sidemenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelDesktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel_selectedForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Picture_profile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new form_profile(), sender);
            if (Properties.Settings.Default.TeacherMode == true) panel1.Visible = false;
        }

        private void Picture_profile_MouseMove(object sender, MouseEventArgs e)
        {
            panel_profile_logo.BackColor = Color.DimGray;
        }

        private void Picture_profile_MouseLeave(object sender, EventArgs e)
        {
            panel_profile_logo.BackColor = Color.Transparent;
        }




        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if(ToggleSwitch.Checked)
            {
                OpenChildForm(new form_lecturesAll(), sender);
            }
            else
            {
                OpenChildForm(new Form_lectures(), sender);
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }

}


