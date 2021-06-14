using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothArc.tools
{
    class Lecture
    {
        public int id;
        public string url;
        public string name;
        public DateTime start = new DateTime();
        public DateTime finish = new DateTime();
        public List<LectureDay> lectureDays = new List<LectureDay>();
        private DateTime today = DateTime.Now;
       
        public int duration ;
        public Lecture(DataTable egitimler, int index)
        {
            this.duration = int.Parse(egitimler.Rows[index].ItemArray[7].ToString());
            this.name = egitimler.Rows[index].ItemArray[3].ToString();
            this.start = DateTime.Parse(egitimler.Rows[index].ItemArray[9].ToString());
            this.finish = start.AddDays(7 * duration);
            this.id = int.Parse(egitimler.Rows[index].ItemArray[0].ToString());
            this.url = egitimler.Rows[index].ItemArray[20].ToString();
            for (int i = 11; i <= 17; i++)
            {
                if (!(String.IsNullOrEmpty(egitimler.Rows[index].ItemArray[i].ToString())))
                {
                    LectureDay lectureDay = new LectureDay();
                    lectureDay.day = ToDayOfWeek(egitimler.Columns[i].ColumnName.ToString());
                    lectureDay.startHour= egitimler.Rows[index].ItemArray[i].ToString().Substring(0, 5);
                    lectureDay.finishHour = egitimler.Rows[index].ItemArray[i].ToString().Substring(8);
                    this.lectureDays.Add(lectureDay);
                  
                }
            }
            Console.WriteLine(this.name);
        }
        private DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
        public bool isActive()
        {
            if (DateTime.Compare(start,today) < 1 && DateTime.Compare(finish, today) >= 1) return true;
            else return false;
        }
        public bool isFinished()
        {
            if (DateTime.Compare(today,finish) < 1) return true;
            else return false;
        }
        public DateTime NextLesson()
        {
    
            DateTime nextLesson = new DateTime();
            List<DateTime> lessons = new List<DateTime>();
            if (this.isActive())
            {
                for(int i = 0; i < lectureDays.Count; i++)
                {
                    lessons.Add(GetNextWeekday(today,lectureDays[i].day));
                    
                }
            }
            else
            {
                for (int i = 0; i < lectureDays.Count; i++)
                {
                    lessons.Add(GetNextWeekday(start, lectureDays[i].day));
                }
            }
            nextLesson = lessons.OrderBy(t => t.DayOfYear).ToList().First();
            for (int i = 0; i < this.lectureDays.Count; i++)
            {
                if (nextLesson.DayOfWeek == this.lectureDays[i].day)
                {
                    nextLesson = DateTime.ParseExact(nextLesson.ToString("dd/MM/yyyy") + " " + this.lectureDays[i].startHour, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture);
                }
            }
            return nextLesson;
        }

        public DateTime NextLessonStart()
        {
            DateTime startDate = new DateTime();
            for (int i = 0; i < this.lectureDays.Count; i++)
            {
                if (this.NextLesson().DayOfWeek == this.lectureDays[i].day)
                {
                    startDate = DateTime.ParseExact(this.NextLesson().ToString("dd/MM/yyyy") + " " + this.lectureDays[i].startHour, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.CurrentCulture);
                }
            }
            return startDate;
        }

        public DayOfWeek ToDayOfWeek(string day)
        { 
            switch (day)
            {
                case "pazartesi":
                    return DayOfWeek.Monday;
                case "sali":
                    return DayOfWeek.Tuesday;
                case "carsamba":
                    return DayOfWeek.Wednesday;
                case "persembe":
                    return DayOfWeek.Thursday;
                case "cuma":
                    return DayOfWeek.Friday;
                case "cumartesi":
                    return DayOfWeek.Saturday;
                case "pazar":
                    return DayOfWeek.Sunday;
                default:
                    return DayOfWeek.Monday;


            }
        }
    }
}


