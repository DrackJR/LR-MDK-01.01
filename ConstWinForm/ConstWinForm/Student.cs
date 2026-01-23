using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstWinForm
{
    public class Student
    {
        private string name_;
        private int age_;
        private double avgScore_;
        private string numberID_;

        public Student()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }

        public string Name
        {
            get { return name_; }           
        }

        public Student(string name, int age, double avgScore, string numberID)
        {
            name_ = name;
            age_ = age;
            avgScore_ = avgScore;
            numberID_ = numberID;
        }
    }
}