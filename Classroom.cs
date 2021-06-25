using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
       // private List<Student> subjectStudents;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }

        public int Capacity { get; set; }  // the curr Capacity ClassRoom
        public int Count => this.students.Count; // the count of the Students in the classRoom

        public string RegisterStudent(Student student) 
        {
            if (Capacity - Count > 0)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return $"No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName) 
        {
            Student student = students.FirstOrDefault(stud => stud.FirstName == firstName &&
            stud.LastName == lastName);

            if (student != null)
            {
                // i was forgotten to remove the studetn from the curr List
                students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }

            return $"Student not found";
        }

        public string GetSubjectInfo(string subject) 
        {
            List<Student>subjectStudents = students
                .Where(stud => stud.Subject == subject)
                .ToList();

            if (subjectStudents.Count != 0)
            {              

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var student in subjectStudents)
                {
                   sb.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return sb.ToString().TrimEnd();
                
            }
            
                return ("No students enrolled for the subject");
           
        }
        // students.Where(stud => stud.Subject == subject).ToList();

        public int GetStudentsCount() => students.Count;
        public Student GetStudent(string firstName, string lastName)
        {
            Student selectedStudent = students
                .FirstOrDefault(stud => stud.FirstName == firstName &&
             stud.LastName == lastName);

            if (selectedStudent != null)
            {               
                return selectedStudent;
            }

            return null;
        }
    }
}
