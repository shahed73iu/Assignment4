using System;
using System.Collections.Generic;
using System.Text;

namespace librarySytemAssignment
{
    public class StudentAndBook
    {
           public void EnterStudentInfo(LibraryContext context)
        {
            Student student = new Student();
            
            Console.WriteLine("Entry Student Information center");
            
            Console.WriteLine("===============================");

            Console.Write("Please enter student Id: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Please enter student Name: ");
            student.Name = Console.ReadLine();

            student.FineAmount = 0;
            Console.WriteLine("===============================");

            context.Students.Add(new Student()
            {
                Id = student.Id,
                Name = student.Name,
                FineAmount = 0
            });
            context.SaveChanges();
            Console.WriteLine("Student Inserted Successfully !!!!! ");
        }



        public void EnterBookInfo(LibraryContext context)
        {
            Book book = new Book();
            
            Console.WriteLine("Entry Book Information Center");
            Console.WriteLine("===============================");
            Console.Write("Please enter Book Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Please enter Book Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Please enter Book Edition: ");
            book.Edition = Console.ReadLine();

            Console.Write("Please enter Barcode of the book: ");
            book.BarCode = Console.ReadLine();

            Console.Write("Please enter Copy Count of the book: ");
            book.CopyCount = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================");

            context.Books.Add(new Book()
            {
                Author = book.Author,
                Edition = book.Edition,
                Title = book.Title,
                BarCode = book.BarCode,
                CopyCount = book.CopyCount
            });
            context.SaveChanges();
            Console.WriteLine("Books Inserted Successfully !!!!! ");
        }
    }
}

  

