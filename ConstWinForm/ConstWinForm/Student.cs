using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstWinForm
{
    public class Student
    {
        private string name_;
        private int age_;
        private double avgScore_;
        private string numberID_;
        private string photo_;

        public Student()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }

        public string Name
        {
            get { return name_; }           
        }

        public Student(string name, int age, double avgScore, string numberID, string photo)
        {
            name_ = name;
            age_ = age;
            avgScore_ = avgScore;
            numberID_ = numberID;
            photo_ = photo;
        }

        public int Age
        {
            get { return age_; }
        }

        public double AvgScore
        {
            get { return avgScore_; }
        }

        public string NumberID
        {
            get { return numberID_; }
        }

        public string Photo
        {
            get { return photo_; }
        }
    }
}