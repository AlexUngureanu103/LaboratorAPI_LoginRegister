﻿using DataLayer.Entities;

namespace Core.Dtos
{
    public class GradeDto
    {
        public double Value { get; set; }

        public CourseType Course { get; set; }
    }
}
