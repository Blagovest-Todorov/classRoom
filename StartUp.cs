﻿namespace ClassroomProject
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom(10); // Initialize the curr classroom

            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");

            Console.WriteLine(student); // Prints the curr Student

            //  // Register Student
            string register = classroom.RegisterStudent(student);
            Console.WriteLine(register);
            string registerTwo = classroom.RegisterStudent(studentTwo);
            string registerThree = classroom.RegisterStudent(studentThree);
            string registerFour = classroom.RegisterStudent(studentFour);

            //Dismiss Student 
            string dismissed = classroom.DismissStudent("Peter", "Parker");
            Console.WriteLine(dismissed); // Dismissed student Peter Parker

            string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
            Console.WriteLine(dismissedTwo);

            // Subject Info

            string subjectInfo = classroom.GetSubjectInfo("Algebra");
            Console.WriteLine(subjectInfo);
            // Subject: Algebra
            // Students:
            // Sarah Smith
            // Sam Winchester
            string anotherInfo = classroom.GetSubjectInfo("Art");
            Console.WriteLine(anotherInfo); // No students enrolled for the subject

            // Get Student
            Console.WriteLine(classroom.GetStudent("Dean", "Winchester"));
            // Student: First Name = Dean, Last Name = Winchester, Subject = Music


        }
    }
}