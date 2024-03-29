﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenHuuNhan_2011065282.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        [StringLength(255)]
        public string Pleace { get; set; }
        public DateTime DateTime { get; set; }
        public Category category { get; set; }
        [Required]
        public byte CategoryID { get; set; }
    }
 
}