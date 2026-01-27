namespace NasledWinForms
{
    public class HomoSapiens
    {
        private string name_;
        private int age_;

        public string GetName()
        {
            return name_;
        }

        public HomoSapiens(string name, int age)
        {
           name_ = name;
           age_ = age;
        }

        public override string ToString()
        {
            return $"{GetName()}, {age_}";
        }
    }
}
