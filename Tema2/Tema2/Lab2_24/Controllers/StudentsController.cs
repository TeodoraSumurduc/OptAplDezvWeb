﻿using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21},
            new Student { Id = 1, Name = "Maria", Age = 19},
            new Student { Id = 1, Name = "Vlad", Age = 22},
            new Student { Id = 1, Name = "Florin", Age = 25},
            new Student { Id = 1, Name = "Marian", Age = 20},
        };

        // endpoint 
        // Get 
        [HttpGet]
        public List<Student> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }

        // Create

        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }


        [HttpDelete]
        public List<Student> DeleteId(int id)
        {
            var studentIndex = students.FindIndex(x => x.Id == id);
            if (studentIndex >= 0)
            {
                students.RemoveAt(studentIndex);
            }
            return students;
        }
        [HttpGet("getAllOrdered")]
        public List<Student> GetOrdered(string orderBy = "Age")
        {
            List<Student> orderedStudents;
            switch (orderBy)
            {
                case "Age":
                    orderedStudents = students.OrderBy(s => s.Age).ToList();
                    break;
                default:
                    orderedStudents = students;
                    break;
            }

            return orderedStudents;
        }
    }
}
