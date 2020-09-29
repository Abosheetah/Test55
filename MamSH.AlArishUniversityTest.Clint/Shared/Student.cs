using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MamSH.AlArishUniversityTest.Clint.Shared
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Student Name is Requierd")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
