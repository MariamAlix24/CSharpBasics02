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
            #region Question 2
            //Q2
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());
            #endregion
            #region Qestion 3
            //Q3
            // Compile Time Error :you cannot put text (string) into an int 
            #endregion
            #region Question 4
            //Q4
            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally { Console.WriteLine("Done"); }
            #endregion
            #region Question5
            //Q5
            int Pages =300;
            double doublePages = Pages;
            #endregion
            #region Question6
            //Q6
            double price = 49.99;
            int intPrice = (int)price;
            #endregion
            #region Question7
            //Q7
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);
            #endregion
            #region Question8
            //Q8
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);
            #endregion
            #region Question9
            //Q8 continued try parse
            string badtext = "abc";
            int result;
            if (!int.TryParse(badtext, out result))
            {
                Console.WriteLine("Conversion failed.");
            }
            #endregion
            #region Question9
            //Q9
            int pagescount = 464;
            string pagesString = pagescount.ToString();
            Console.WriteLine(pagesString.GetType());
            #endregion
        }
    }
}
