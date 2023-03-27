using BigSchool.Models;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required] 
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public string Heading { get; set; }
        public string Action => (Id != 0) ? "Update" : "Create";

        public DateTime GetDateTime() 
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}