using SmoothArc.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothArc.forms
{
    public partial class form_lecturesAll : Form
    {
        List<Lecture> lectures = new List<Lecture>();
        bool teachermode = Properties.Settings.Default.TeacherMode;
        string user = Properties.Settings.Default.Email;
        DataTable egitimler = new DataTable();
        DBconnection connection = new DBconnection();
        List<Label> label_lessons = new List<Label>();
        List<Label> label_times = new List<Label>();
        List<Label> label_dates = new List<Label>();
        List<Guna.UI2.WinForms.Guna2Button> save_btns = new List<Guna.UI2.WinForms.Guna2Button>();


        public form_lecturesAll()
        {
            InitializeComponent();
            fill_lists();
            getLectures();
            LessonCountView(lectures.Count);

        }
        public void LessonCountView(int LessonCount)
        {
            if (LessonCount < 1)
            {
                panel_lesson1.Visible = false;
                panel_lesson2.Visible = false;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                panel_lesson6.Visible = false;

            }
            if (LessonCount == 1)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = false;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                panel_lesson6.Visible = false;

            }
            if (LessonCount == 2)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                panel_lesson6.Visible = false;

            }
            if (LessonCount == 3)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                panel_lesson6.Visible = false;

            }
            if (LessonCount == 4)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = true;
                panel_lesson5.Visible = false;
                panel_lesson6.Visible = false;

            }
            if (LessonCount == 5)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = true;
                panel_lesson5.Visible = true;
                panel_lesson6.Visible = false;

            }
            if (LessonCount > 6)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = true;
                panel_lesson5.Visible = true;
                panel_lesson6.Visible = true;

            }
        }

        public void fill_lists()
        {
            //labels
            label_lessons.Add(label_lesson1);
            label_lessons.Add(label_lesson2);
            label_lessons.Add(label_lesson3);
            label_lessons.Add(label_lesson4);
            label_lessons.Add(label_lesson5);
            label_lessons.Add(label_lesson6);
            //times
            label_times.Add(label_time1);
            label_times.Add(label_time2);
            label_times.Add(label_time3);
            label_times.Add(label_time4);
            label_times.Add(label_time5);
            label_times.Add(label_time6);
            //buttons
            save_btns.Add(btn_save1);
            save_btns.Add(btn_save2);
            save_btns.Add(btn_save3);
            save_btns.Add(btn_save4);
            save_btns.Add(btn_save5);
            save_btns.Add(btn_save6);
            //dates
            label_dates.Add(label_date1);
            label_dates.Add(label_date2);
            label_dates.Add(label_date3);
            label_dates.Add(label_date4);
            label_dates.Add(label_date5);
            label_dates.Add(label_date6);


        }
        public void getLectures()
        {
            egitimler = connection.query("SELECT * FROM `egitimler` ");
            
            for (int i = 0; i < egitimler.Rows.Count; i++)
            {

                Lecture lecture = new Lecture(egitimler, i);
                if (!lecture.isFinished()) lectures.Add(lecture);
               
            }

            
            //sort
            Lecture temp;
            for (int i = 1; i <= lectures.Count; i++)
            {
                for (int j = 0; j < lectures.Count - i; j++)
                {


                    if (DateTime.Compare(lectures[j].NextLessonStart(), lectures[j + 1].NextLessonStart()) < 1)
                    {
                        temp = lectures[j];
                        lectures[j] = lectures[j + 1];
                        lectures[j + 1] = temp;
                    }
                }
            }
            lectures.Reverse();
            //show
            for (int i = 0; i < lectures.Count; i++)
            {
                if (i > 5)
                {
                    label_lessons.Add(new Label());
                    label_dates.Add(new Label());
                    label_times.Add(new Label());
                    save_btns.Add(new Guna.UI2.WinForms.Guna2Button());
                }
                label_lessons[i].Text = lectures[i].name;
                label_dates[i].Text = lectures[i].NextLesson().ToString("dd/MM/yyyy");
                for (int j = 0; j < lectures[i].lectureDays.Count; j++)
                {
                    if (lectures[i].NextLesson().DayOfWeek == lectures[i].lectureDays[j].day)
                    {
                        label_times[i].Text = lectures[i].lectureDays[j].startHour;
                        DateTime startDate = DateTime.ParseExact(lectures[i].NextLesson().ToString("dd/MM/yyyy") + " " + lectures[i].lectureDays[j].startHour, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture);
                        DateTime finishDate = DateTime.ParseExact(lectures[i].NextLesson().ToString("dd/MM/yyyy") + " " + lectures[i].lectureDays[j].finishHour, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture);
                        DateTime today = DateTime.Now;
                        if (startDate.CompareTo(today) <= 0 && finishDate.CompareTo(today) > 0) save_btns[i].Enabled = true;

                    }
                }
            }
        }
        public void JoinButton(int index)
        {
            lectures.Clear();
            getLectures();
            Properties.Settings.Default.egitimID = lectures[index].id;
            string joinUrl = lectures[index].url;
            if (!String.IsNullOrEmpty(joinUrl)) System.Diagnostics.Process.Start(joinUrl);
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            JoinButton(0);
        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            JoinButton(1);

        }

        private void btn_save3_Click(object sender, EventArgs e)
        {
            JoinButton(2);
        }

        private void btn_save4_Click(object sender, EventArgs e)
        {
            JoinButton(3);
        }

        private void btn_save5_Click(object sender, EventArgs e)
        {
            JoinButton(4);
        }

        private void btn_save6_Click(object sender, EventArgs e)
        {
            JoinButton(5);
        }
    }
}
