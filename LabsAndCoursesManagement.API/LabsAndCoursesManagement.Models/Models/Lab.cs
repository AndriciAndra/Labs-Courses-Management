﻿namespace LabsAndCoursesManagement.Models.Models
{
    public class Lab: TenantBase
    {
        public Lab()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public string Group { get; private set; }

        public string Description { get; private set; }

        public int Year { get; private set; }

        public int Semester { get; private set; }

        public Teacher Teacher { get; private set; }

        public Guid TeacherId { get; private set; }

        public List<Student> Students { get; private set; } = new List<Student>();

        public void EnrollTeacher(Teacher teacher)
        {
            Teacher = teacher;
            TeacherId = teacher.Id;
        }

        public void EnrollStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
