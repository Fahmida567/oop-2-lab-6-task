﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student_App
{
    class Student
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public  string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public  string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {

            name = "Fahmida Rashid";
            id = "19-40040-1";
            department = "CSE";
            cgpa = 3.80F;
        }
        public Student (string name,string id,string department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;

        }
        public void showInfo()
        {
            Console.WriteLine("Student Name is:" + name);
            Console.WriteLine("Student Id is " + id);
            Console.WriteLine("Student Department is: " + department);
            Console.WriteLine("Student Cgpa is:" + cgpa);

        }


    }
}
