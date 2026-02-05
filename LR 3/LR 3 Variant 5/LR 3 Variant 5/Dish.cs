namespace LR_3_Variant_5
{
    public class Dish
    {
        private string name_;
        private double price_;
        private string photo_;
        private string description_;

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

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Photo
        {
            get { return photo_; }
        }

        public string Description
        {
            get { return description_; }
        }
    }
}
