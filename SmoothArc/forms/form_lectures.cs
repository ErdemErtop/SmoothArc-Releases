using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using SmoothArc.tools;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmoothArc.forms;

namespace SmoothArc
{

    public partial class Form_lectures : Form
    {
        bool teachermode = Properties.Settings.Default.TeacherMode;
        string user = Properties.Settings.Default.Email;
        DataTable egitimler = new DataTable();
        DBconnection connection = new DBconnection();
        List<Label> label_lessons = new List<Label>();
        List<Label> label_times = new List<Label>();
        List<Label> label_dates = new List<Label>();
        List<Guna.UI2.WinForms.Guna2Button> save_btns = new List<Guna.UI2.WinForms.Guna2Button>();
        List<Lecture> lectures = new List<Lecture>();
        public void LessonCountView(int LessonCount)
        {
            if (LessonCount < 1)
            {
                panel_lesson1.Visible = false;
                panel_lesson2.Visible = false;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                btn_addLesson.Location = panel_lesson1.Location;
            }
            if (LessonCount == 1)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = false;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                btn_addLesson.Location = panel_lesson2.Location;
            }
            if (LessonCount == 2)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = false;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                btn_addLesson.Location = panel_lesson3.Location;
            }
            if (LessonCount == 3)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = false;
                panel_lesson5.Visible = false;
                btn_addLesson.Location = panel_lesson4.Location;
            }
            if (LessonCount == 4)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = true;
                panel_lesson5.Visible = false;
                btn_addLesson.Location = panel_lesson5.Location;
            }
            if (LessonCount > 5)
            {
                panel_lesson1.Visible = true;
                panel_lesson2.Visible = true;
                panel_lesson3.Visible = true;
                panel_lesson4.Visible = true;
                panel_lesson5.Visible = true;

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
            //times
            label_times.Add(label_time1);
            label_times.Add(label_time2);
            label_times.Add(label_time3);
            label_times.Add(label_time4);
            label_times.Add(label_time5);
            //buttons
            save_btns.Add(btn_save1);
            save_btns.Add(btn_save2);
            save_btns.Add(btn_save3);
            save_btns.Add(btn_save4);
            save_btns.Add(btn_save5);
            //dates
            label_dates.Add(label_date1);
            label_dates.Add(label_date2);
            label_dates.Add(label_date3);
            label_dates.Add(label_date4);
            label_dates.Add(label_date5);
        }
        public void CustomizeDesign(int LessonCount)
        {
            if (teachermode == false)
            {
                LessonCountView(LessonCount);

            }
            if (teachermode == true)
            {
                btn_save1.Text = "Başla";
                btn_save2.Text = "Başla";
                btn_save3.Text = "Başla";
                btn_save4.Text = "Başla";
                btn_save5.Text = "Başla";
                btn_addLesson.Visible = false;
                
                for (int i =0; i < lectures.Count; i++)
                {
                    Console.WriteLine(lectures[i].url);
                    if (!String.IsNullOrEmpty(lectures[i].url))
                    {
                        if (save_btns[i].Enabled == true && Properties.Settings.Default.lectureURL == lectures[i].url)
                        {
                            save_btns[i].Text = "Katıl";
                        }
                    }
          
                }
                LessonCountView(LessonCount);
            }
        }
        public void getLectures()
        {
            lectures.Clear();
            if (teachermode == true)
            {
                egitimler = connection.query("SELECT * FROM `egitimler` WHERE `egitmen_id`= " + Properties.Settings.Default.id.ToString());
            }
            else
            {
                egitimler = connection.query("SELECT * FROM `egitimler` INNER JOIN `siparisler` ON `siparisler`.`egitim_id`=`egitimler`.`id` WHERE `siparisler`.`musteri_id`='" + Properties.Settings.Default.id.ToString() + "'AND `siparisler`.`durum`= '1'");
            }
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
                if (i > 4)
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
                        if (teachermode == true)
                        {
                            if ((startDate - today).TotalMinutes <= 15 && finishDate.CompareTo(today) == 1)
                            {
                                save_btns[i].Enabled = true;
                            }
                    

                        }
                        else
                        {
                            if (startDate.CompareTo(today) <= 0 && finishDate.CompareTo(today) > 0) save_btns[i].Enabled = true;
                        }
                    }
                }

            }
          

        }
        public void SaveButton(int index)
        {
            new form_message("", true).Show();
            System.Diagnostics.Process.Start("https://meet.google.com/new");
            getLectures();
            Properties.Settings.Default.egitimID = lectures[index].id;
        }
        public void JoinButton(int index)
        {
            getLectures();
            Properties.Settings.Default.egitimID = lectures[index].id;
            string joinUrl = lectures[index].url;
            System.Diagnostics.Process.Start(joinUrl);
        }

        public Form_lectures()
        {
            InitializeComponent();
            fill_lists();
            getLectures();
            CustomizeDesign(lectures.Count);


        }

        public string CreateMeeting()
        {
            var client = new RestClient("https://api.zoom.us/v2/users/" + user + "/meetings");
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOm51bGwsImlzcyI6Im50VGpJQTRpUUJLZld2WDJEN1pNdnciLCJleHAiOjQxMDUxMTg1ODAsImlhdCI6MTYxMjEyNzY0N30.lstS6dg0uE7abq-dCo0r8AwviltyzmZkDmkliDEhJ8I");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            dynamic json = JsonConvert.DeserializeObject(response.Content);
            string joinUrl = json.join_url;
            return joinUrl;
        }


        private void btn_addLesson_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://online.smoothacademy.org/");
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            if (teachermode == true && btn_save1.Text== "Başla")
            {
                SaveButton(0);
            }
            else JoinButton(0);

        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            if (teachermode == true && btn_save1.Text == "Başla")
            {
                SaveButton(1);
            }
            else
                JoinButton(1);
        }

        private void btn_save3_Click(object sender, EventArgs e)
        {
            if (teachermode == true && btn_save1.Text == "Başla")
            {
                SaveButton(2);
            }
            else
                JoinButton(2);
        }

        private void btn_save4_Click(object sender, EventArgs e)
        {
            if (teachermode == true && btn_save1.Text == "Başla")
            {
                SaveButton(3);
            }
            else
                JoinButton(3);
        }

        private void btn_save5_Click(object sender, EventArgs e)
        {
            if (teachermode == true && btn_save1.Text == "Başla")
            {
                SaveButton(4);
            }
            else
                JoinButton(4);
        }
    }
}
