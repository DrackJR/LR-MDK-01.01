namespace NasledWinForms
{
    public class Student : HomoSapiens
    {
        private int numberID_;

        public Student(int numberID) : base("Александр Патрин", 20)
        {
            numberID_ = numberID;
        }

        public int NumberID
        {
            get { return numberID_; }
        }

        public override string ToString()
        {
            return base.ToString() + ", " + numberID_;
        }
    }
}
