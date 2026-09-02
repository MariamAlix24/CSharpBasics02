namespace G_ASP_NET_99_C_Basics_02
{
    internal class Book
    {
        public string Title;
        public int Pages;
        public override string ToString()
        {
            return $" Book Title: {Title}, Pages: {Pages}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Q1
            Book b1= new Book();
            b1.Title = "nany hunter";
            b1.Pages = 300;
            object obj = b1;
            Console.WriteLine(obj);
            #endregion
        }
    }
}
