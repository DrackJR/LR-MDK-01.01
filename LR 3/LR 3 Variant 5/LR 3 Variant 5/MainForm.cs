using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LR_3_Variant_5
{
    public partial class MainForm : Form
    {
        private Dictionary <string,List<Dish>> menu_ = new Dictionary <string,List<Dish>>();
        private Dictionary<string, int> orders_ = new Dictionary<string, int>();
        private StorageDish dishes_ = new StorageDish();
        public MainForm()
        {
            InitializeComponent();
            List<Dish> allDishes = new List<Dish>();
            //menu_.Add("Завтрак", new List<Dish>()
            //{  new Dish("Овсяная Каша", 149.9, "..\\images\\овсяная каша.jpg", "Ингредиенты: Овёс, молоко/вода, соль/сахар, масло.","Завтрак"),
            //   new Dish("Рисовая Каша", 59.9, "..\\images\\рисовая каша.jpg", "Ингредиенты: Рис, молоко/вода, соль/сахар, масло.","Завтрак"),
            //   new Dish("Манная Каша", 99.9, "..\\images\\манная каша.jpg", "Ингредиенты: Манная крупа, молоко, сахар, масло.","Завтрак")
            //}
            //);
            //menu_.Add("Обед", new List<Dish>()
            //{  new Dish("Борщ", 199.9, "..\\images\\борщ.jpg", "Ингредиенты: Свёкла, капуста, картофель, морковь, лук, мясо/бульон, томат, сметана.","Обед"),
            //   new Dish("Рассольник", 99.9, "..\\images\\рассольник.jpg", "Ингредиенты: Солёные огурцы, перловка, картофель, морковь, лук, мясо/бульон, сметана.","Обед"),
            //   new Dish("Окрошка", 149.9, "..\\images\\окрошка.jpg", "Ингредиенты: Варёные овощи (картофель, морковь), колбаса/мясо, яйца, огурцы, зелёный лук.","Обед")
            //}
            //);
            //menu_.Add("Ужин", new List<Dish>()
            //{  new Dish("Плов", 149.9, "..\\images\\плов.jpg", "Ингредиенты: Рис, мясо (чаще баранина), морковь, лук, масло, специи.", "Ужин"),
            //   new Dish("Овощной салат", 99.9, "..\\images\\овощной салат.jpg", "Ингредиенты: Свежие овощи (огурцы, помидоры, перец и др.), зелень, масло/сметана.", "Ужин"),
            //   new Dish("Картофельное пюре", 49.9, "..\\images\\картофельное пюре.jpg", "Ингредиенты: Картофель, молоко, масло, соль.", "Ужин")
            //}
            //);
            allDishes = dishes_.Load();
            foreach (Dish dish in allDishes)
            {
                if (menu_.ContainsKey(dish.Category) == false)
                {
                    menu_.Add(dish.Category, new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) });
                }

                else if (dish.Category == "Завтрак" && menu_.ContainsKey(dish.Category))
                {
                    menu_[dish.Category] = new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) };
                }

                if (dish.Category == "Обед" && menu_.ContainsKey(dish.Category) == false)
                {
                    menu_.Add(dish.Category, new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) });
                }

                else if (dish.Category == "Обед" && menu_.ContainsKey(dish.Category))
                {
                    menu_[dish.Category] = new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) };
                }

                if (dish.Category == "Ужин" && menu_.ContainsKey(dish.Category) == false)
                {
                    menu_.Add(dish.Category, new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) });
                }

                else if (dish.Category == "Ужин" && menu_.ContainsKey(dish.Category))
                {
                    menu_[dish.Category] = new List<Dish>() { new Dish(dish.Name, dish.Price, dish.Photo, dish.Description, dish.Category) };
                }
            }

            CategoriesListBox.DataSource = menu_.Keys.ToList();
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuComboBox.DataSource = menu_[CategoriesListBox.SelectedItem.ToString()];
            MenuComboBox.DisplayMember = "Name";
        }

        private void MenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish dish = MenuComboBox.SelectedItem as Dish;
            PriceLabel.Text = dish.Price.ToString() + "  руб.";
            PhotoPictureBox.Load(dish.Photo);
            DescriptionLabel.Text = dish.Description;
            QuantityTextBox.Text = "0";
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (orders_.ContainsKey(CategoriesListBox.SelectedItem.ToString()))
            {
                orders_[CategoriesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
               BasketRichTextBox.Clear();
               foreach (string key in orders_.Keys)
               {                    
                   BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт.\n");
               }
            }
            else
            {
                orders_.Add(CategoriesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders_.Keys)
                {                    
                     BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт.\n");
                }
            }                
        }
    }
}
