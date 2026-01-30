using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_3_Variant5
{
    public partial class MainForm: Form
    {
        private List<List<Dish>> allDishes_ = new List<List<Dish>>();
        private List<Dish> meat_ = new List<Dish>();
        private List<Dish> fish_ = new List<Dish>();
        private List<Dish> porridge_ = new List<Dish>();
        public MainForm()
        {
            InitializeComponent();
            porridge_.Add(new Dish("Овсяная каша", 86, "D:\\П-30 Смирнов\\jpg\\овсянка.jpg", "Данная каша сварена из лучших круп в мире"));
            porridge_.Add(new Dish("Манная каша", 95, "D:\\П-30 Смирнов\\jpg\\манка.jpg", "Просто хорошая каша, рекомендую!"));
            porridge_.Add(new Dish("Гречневая каша", 69, "", "Если хочешь ты поесть, то и кашу надо съесть"));
            allDishes_.Add(porridge_);
            allDishes_.Add(fish_);
            allDishes_.Add(meat_);

            GroupDishListBox.DataSource = allDishes_;
            GroupDishListBox.DisplayMember = "Name";
        }

        private void GroupDishListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishMenuComboBox.DataSource = GroupDishListBox.SelectedItem;
            DishMenuComboBox.DisplayMember = "Name";            
            PhotoOfDishPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void DishMenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Dish> currentMenu = (List<Dish>)GroupDishListBox.SelectedItem;
            Dish dish = (Dish)DishMenuComboBox.SelectedItem;
            PriceLabel.Text = dish.Price.ToString();
            DescriptionLabel.Text = dish.Description;
            PhotoOfDishPictureBox.Load(dish.Photo);
        }
    }
}
