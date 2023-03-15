using NguyenHuuNhan_2011065282.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenHuuNhan_2011065282.Views.ViewModels
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}