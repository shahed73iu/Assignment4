using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace librarySytemAssignment
{
        public class CheckAndReceiveFine
        {

            public void CheckFine(LibraryContext context)
            {
                Student student = new Student();

                Console.WriteLine("Check Fine");
                Console.WriteLine("===============================");

                Console.Write("Please Enter Student Id : ");
                student.Id = int.Parse(Console.ReadLine());

                var CheckFine = context.Students.Where(x => x.Id == student.Id).SingleOrDefault();

                Console.WriteLine("\n\nYour Fine is {0} TAKA", CheckFine.FineAmount);

                Console.WriteLine("===============================");
            }






            public void ReceiveFine(LibraryContext context)
            {
                Student student = new Student();
                Console.WriteLine("Receive the Fine");
                Console.WriteLine("===============================");

                Console.WriteLine("Please Enter Student Id : ");
                student.Id = int.Parse(Console.ReadLine());


                Console.WriteLine("Please Enter Fine amount : ");
                student.FineAmount = double.Parse(Console.ReadLine());

                var CheckFine = context.Students.Where(x => x.Id == student.Id).SingleOrDefault();

                var RemainingFineBalance = CheckFine.FineAmount - student.FineAmount;

                if (RemainingFineBalance < 0) { Console.WriteLine("Sorry !! Transaction failed.. Receive Actual Fine"); }

                else
                {
                    CheckFine.FineAmount = RemainingFineBalance;
                    Console.WriteLine("Your Remaining Fine Balance is {0} Taka", RemainingFineBalance);
                    context.SaveChanges();
                }
                Console.WriteLine("===============================");
            }


        }
}

