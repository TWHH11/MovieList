﻿using System;
using MovieList.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MovieList.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
	{
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

