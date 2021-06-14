using SmoothArc.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothArc
{
    public partial class form_loading : Form
    {

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
        public form_loading()
        {
            InitializeComponent();
            Console.WriteLine(Properties.Settings.Default.TeacherMode);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 100, 100));
        }
        public void ShowMenu()
        {
            guna2Panel2.Visible = true;
            panel_profile_logo.Visible = true;
            button_calendar.Visible = true;
            button_lessons.Visible = true;
            button_questions.Visible = true;
            button_exit.Visible = true;
            guna2Panel1.Visible = true;

        }
        private void form_loading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            timer1.Interval = 2000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
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
        private void panel_profile_logo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_profile(), sender);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_profile(), sender);
  
        }

        private void circlePicturebox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_profile(), sender);

        }

        private void button_lessons_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            if (Properties.Settings.Default.TeacherMode == true)
            {
                student.panel1.Visible = true;
                student.ToggleSwitch.Checked = false;
            }
            student.Show();
            student.OpenChildForm(new Form_lectures(), sender);
        }

        private void button_calendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_calendar(), sender);
        }

        private void button_questions_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_questions(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }

        private void button_exit_MouseHover(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.Transparent;
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.Transparent;
        }

        private void button_exit_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel1.BackColor = Color.DimGray;
        }

        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel2_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel2.BackColor = Color.Transparent;
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel2.BackColor = Color.DimGray;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            guna2Panel2.BackColor = Color.DimGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel2.BackColor = Color.Transparent;
        }

        private void btn_allLecture_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_lecturesAll(), sender);

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void form_loading_MouseDown(object sender, MouseEventArgs e)
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

        private void Picture_profile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            form_student student = new form_student();
            student.Show();
            student.OpenChildForm(new form_profile(), sender);
        }

        private void Picture_profile_MouseMove(object sender, MouseEventArgs e)
        {
            panel_profile_logo.BackColor = Color.DimGray;
        }

        private void Picture_profile_MouseLeave(object sender, EventArgs e)
        {
            panel_profile_logo.BackColor = Color.Transparent;
        }
    }
}
