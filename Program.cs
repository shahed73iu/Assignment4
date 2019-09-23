using System;

namespace librarySytemAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new LibraryContext();

          Level:
            Console.Clear();
            Console.WriteLine("\t\t\t\t#____________________________________________#");
            Console.WriteLine("\t\t\t\t| Welcome to library system.                 |");

            Console.WriteLine("\t\t\t\t| To entry student information enter: 1      |");
            Console.WriteLine("\t\t\t\t| To entry book information enter: 2         |");
            Console.WriteLine("\t\t\t\t| To issue a book, enter: 3                  |");
            Console.WriteLine("\t\t\t\t| To return a book enter: 4                  |");
            Console.WriteLine("\t\t\t\t| To check fine, enter: 5                    |");
            Console.WriteLine("\t\t\t\t| To receive fine, enter: 6                  |");
            Console.WriteLine("\t\t\t\t|#__________________________________________#|");


            try
            {
                Console.Write("\n\n\n\tPlease enter your choice: ");
                int ch = int.Parse(Console.ReadLine());
                Console.WriteLine("=================================");

                switch (ch)
                {
                    case 1:
                        var sb = new StudentAndBook();
                        sb.EnterStudentInfo(context);
                        break;

                    case 2:
                        var sbc = new StudentAndBook();
                        sbc.EnterBookInfo(context);
                        break;

                    case 3:
                        var n = new IssueAndReturnBook();
                        n.IssueBook(context);
                        break;

                    case 4:
                        var r = new IssueAndReturnBook();
                        r.ReturnBook(context);
                        break;

                    case 5:
                        var cf = new CheckAndReceiveFine();
                        cf.CheckFine(context);
                        break;
                    case 6:
                        var cfa = new CheckAndReceiveFine();
                        cfa.ReceiveFine(context);
                        break;

                    default:
                        Console.WriteLine("Invalid Key Given. Please Try Again");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You typed an invalid Option. Please try again");
            }
            Console.WriteLine("Please Enter any key to Continue......");
            Console.ReadKey();

            goto Level;
        }
    }
}
