﻿using System.Collections.Generic;
namespace DataLayer.Entities;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int ClassId { get; set; }
    public Class Class { get; set; }
    public List<Grade> Grades { get; set; }

}

