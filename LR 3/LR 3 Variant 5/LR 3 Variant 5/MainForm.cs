using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LR_3_Variant_5
{
    public partial class MainForm : Form
    {
        Dictionary <string,List<Dish>> menu = new Dictionary <string,List<Dish>>();
        Dictionary<string, int> orders = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            menu.Add("Завтрак", new List<Dish>()
            {  new Dish("Овсяная Каша", 149.9, "..\\images\\овсяная каша.jpg", "Ингредиенты: Овёс, молоко/вода, соль/сахар, масло."),
               new Dish("Рисовая Каша", 59.9, "..\\images\\рисовая каша.jpg", "Ингредиенты: Рис, молоко/вода, соль/сахар, масло."),
               new Dish("Манная Каша", 99.9, "..\\images\\манная каша.jpg", "Ингредиенты: Манная крупа, молоко, сахар, масло.")        
            }
            );
            menu.Add("Обед", new List<Dish>()
            {  new Dish("Борщ", 199.9, "..\\images\\борщ.jpg", "Ингредиенты: Свёкла, капуста, картофель, морковь, лук, мясо/бульон, томат, сметана."),
               new Dish("Рассольник", 99.9, "..\\images\\рассольник.jpg", "Ингредиенты: Солёные огурцы, перловка, картофель, морковь, лук, мясо/бульон, сметана."),
               new Dish("Окрошка", 149.9, "..\\images\\окрошка.jpg", "Ингредиенты: Варёные овощи (картофель, морковь), колбаса/мясо, яйца, огурцы, зелёный лук.")
            }
            );
            menu.Add("Ужин", new List<Dish>()
            {  new Dish("Плов", 149.9, "..\\images\\плов.jpg", "Ингредиенты: Рис, мясо (чаще баранина), морковь, лук, масло, специи."),
               new Dish("Овощной салат", 99.9, "..\\images\\овощной салат.jpg", "Ингредиенты: Свежие овощи (огурцы, помидоры, перец и др.), зелень, масло/сметана."),
               new Dish("Картофельное пюре", 49.9, "..\\images\\картофельное пюре.jpg", "Ингредиенты: Картофель, молоко, масло, соль.")
            }
            );

            CategoriesListBox.DataSource = menu.Keys.ToList();            
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuComboBox.DataSource = menu[CategoriesListBox.SelectedItem.ToString()];
            MenuComboBox.DisplayMember = "Name";
        }

        private void MenuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish dish = MenuComboBox.SelectedItem as Dish;
            PriceLabel.Text = dish.Price + "  руб.";
            PhotoPictureBox.Load(dish.Photo);
            DescriptionLabel.Text = dish.Description;
            QuantityTextBox.Text = "0";
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (orders.ContainsKey(CategoriesListBox.SelectedItem.ToString()))
            {
               orders[CategoriesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
               BasketRichTextBox.Clear();
               foreach (string key in orders.Keys)
               {                    
                   BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
               }
            }
            else
            {
                orders.Add(CategoriesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders.Keys)
                {                    
                     BasketRichTextBox.AppendText(key + " " + orders[key] + " шт." + "\n");
                }
            }                
        }
    }
}
