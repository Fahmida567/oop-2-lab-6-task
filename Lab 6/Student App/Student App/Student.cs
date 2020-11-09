using System;
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

        }
        public Student (string name,string id,string department,float cgpa)
        {

        }


    }
}
