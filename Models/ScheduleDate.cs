using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnDuty.Models
{
    public class ScheduleDate
    {
        public ScheduleDate() {}
        public ScheduleDate(int fullDate, string year, string month, string day, string week, string dayType, string remark)
        {
            this.fullDate = fullDate;
            this.year = year;
            this.month = month;
            this.day = day;
            this.week = week;
            this.dayType = dayType;
            this.remark = remark;
        }
        public int fullDate { get; set; }
        public string? year { get; set; }
        public string? month { get; set; }
        public string? day { get; set; }
        public string? week { set; get; }
        public string? dayType { get; set; }
        public string? remark { set; get; } = null;
    }
}
