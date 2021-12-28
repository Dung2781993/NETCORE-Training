﻿using System;
using System.Collections.Generic;

namespace NetCoreTraining.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int? Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
