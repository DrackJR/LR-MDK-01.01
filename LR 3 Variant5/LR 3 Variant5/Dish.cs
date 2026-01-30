using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3_Variant5
{
    public class Dish
    {
        private string name_;
        private double price_;
        private string photo_;
        private string description_;

        public Dish() 
        {

        }

        public Dish(string name, double price, string photo, string description)
        {
            name_ = name;
            price_ = price;
            photo_ = photo;
            description_ = description;
        }

        public string Name
        {
            get { return name_; }
        }


        public double Price
        {
            get { return price_; }
        }

        public string Description
        {
            get { return description_; }
        }

        public string Photo
        {
            get { return photo_; }
        }
    }
}
