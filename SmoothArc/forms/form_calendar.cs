using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using SmoothArc.tools;
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

namespace SmoothArc.forms
{
    public partial class form_calendar : Form
    {
        DataTable egitimler = new DataTable();
        DBconnection connection = new DBconnection();
        bool teachermode = Properties.Settings.Default.TeacherMode;
        List<Lecture> lectures = new List<Lecture>();


        public form_calendar()
        {
            InitializeComponent();
        }

        public void getLectures()
        {
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
        }
        private void form_calendar_Load(object sender, EventArgs e)
        {

            getLectures();
            for (int i = 0; i < lectures.Count; i++)
            {
                for (int j = 0; j < lectures[i].lectureDays.Count; j++)
                {
                    DateTime Start = DateTime.Parse(lectures[i].start.ToString("yyyy/MM/dd") + " " + lectures[i].lectureDays[j].startHour + ":00");
                    DateTime End = DateTime.Parse(lectures[i].start.ToString("yyyy/MM/dd") + " " + lectures[i].lectureDays[j].finishHour + ":00");                    
                    schedulerControl1.GroupType = SchedulerGroupType.Resource;
                    Appointment apt = schedulerControl1.DataStorage.CreateAppointment(AppointmentType.Pattern);
                    apt.RecurrenceInfo.Type = RecurrenceType.Weekly;
                    apt.RecurrenceInfo.Start = Start;
                    apt.Duration = End - Start;
                    apt.Subject = lectures[i].name;
                    apt.RecurrenceInfo.Periodicity = 1;
                    apt.RecurrenceInfo.WeekDays = ToWeekDays((lectures[i].lectureDays[j].day));
                    apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
                    apt.RecurrenceInfo.OccurrenceCount = lectures[i].duration;
                    apt.ResourceId = schedulerControl1.SelectedResource.Id;
                    schedulerControl1.DataStorage.Appointments.Add(apt);




                }

            }



        }

        public WeekDays ToWeekDays(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    return WeekDays.Monday;
                case DayOfWeek.Tuesday:
                    return WeekDays.Tuesday;
                case DayOfWeek.Wednesday:
                    return WeekDays.Wednesday;
                case DayOfWeek.Thursday:
                    return WeekDays.Thursday;
                case DayOfWeek.Friday:
                    return WeekDays.Friday;
                case DayOfWeek.Saturday:
                    return WeekDays.Saturday;
                case DayOfWeek.Sunday:
                    return WeekDays.Sunday;
                default:
                    return WeekDays.EveryDay;



            }


        }

        private void schedulerControl1_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
        {
            DayHeader header = e.ObjectInfo as DayHeader;
            // Draws the outer rectangle.
            using (var backBrush = new LinearGradientBrush(e.Bounds,
                    Color.Silver, Color.Gray, LinearGradientMode.Vertical))
                e.Cache.FillRectangle(backBrush, e.Bounds);
            Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
            // Draws the inner rectangle.
            using (var backBrush = new LinearGradientBrush(e.Bounds,
                    Color.Gray, Color.DimGray, LinearGradientMode.Vertical))
                e.Cache.FillRectangle(backBrush, innerRect);
            // Draws the header's caption.
            e.Cache.DrawString(header.Caption, header.Appearance.HeaderCaption.Font,
                Brushes.White, innerRect,
                header.Appearance.HeaderCaption.GetStringFormat());
            e.Handled = true;
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
        }

        private void schedulerControl1_CustomDrawDayViewAllDayArea(object sender, CustomDrawObjectEventArgs e)
        {
            AllDayAreaCell cell = (AllDayAreaCell)e.ObjectInfo;
            Resource resource = cell.Resource;
            // Specify what precentage of the appointment duration should be painted.
            Brush brush;
            // Select the brush color.
            brush = Brushes.Silver;
            // Paint the area with the selected color.
            e.Cache.FillRectangle(brush, e.Bounds);
            // Draw the percentage text. 
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Cache.DrawString(string.Format(" "), cell.Appearance.Font, Brushes.Black, e.Bounds, format);
            e.Handled = true;
        }

  
    }
}
