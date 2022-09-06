using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CodeFirstApproach
    {
        public static void Main()
        {
            //AddNewBook();
            //GetBookDetails();
            //DeleteBook();
            //UpdateBook();
            //AddNewCustomerAndOrder();
            //AddOrder();
           //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();

        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }

        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            // ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }



        //private static void AddNewCustomerAndOrder()
        //{
        //    var ctx = new BookContext();

        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "Manasa";
        //    customer.Age = 21;

        //    Order ord=new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and order is created");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //private static void AddOrder()
        //{
        //    try
        //    {



        //        var ctx = new BookContext();

        //        Order ord = new Order();
        //        ord.Order_ID = 101;
        //        ord.Amount = 2500;
        //        ord.OrderDate = DateTime.Now;
        //        var order = ctx.Orders.Where(x => x.cust.ID == 1).SingleOrDefault();

        //        ord.cust = order;
        //        ctx.Orders.Add(ord);
        //        //ctx.SaveChanges();
        //        Console.WriteLine("Order Added");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}

        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());

                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded 
            //from the database as part of the initial query.
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");

                //var customers = ctx.Customers.Include(o => o.Orders); 

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");


                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //private static void GetBookDetails()
        //{
        //    try
        //    {
        //        var ctx = new BookContext();
        //        var books = ctx.Books;

        //        foreach (var book in books)
        //        {
        //            Console.WriteLine(book.BookID + "  " + book.BookName + "  " + book.author + "  " + book.price);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}



        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var books = ctx.Books.Where(x => x.BookID == 4).SingleOrDefault();

        //    try
        //    {

        //        books.BookName = "C++";
        //        ctx.Update(books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Updated successfully");
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //    private static void DeleteBook()
        //    {
        //        var ctx = new BookContext();
        //        var books = ctx.Books.Where(x => x.BookID == 2).SingleOrDefault();
        //        try
        //        {
        //            ctx.Books.Remove(books);
        //            ctx.SaveChanges();
        //            Console.WriteLine("Deleted successfully");
        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.InnerException.Message);
        //        }
        //    }
        //    private static void AddNewBook()
        //    {
        //        var ctx = new BookContext();
        //        Book book = new Book();
        //        book.BookID = 3;
        //        book.BookName = "C#";
        //        book.author = "Scott";
        //        book.price = 170;

        //        try
        //        {
        //            ctx.Books.Add(book);
        //            ctx.SaveChanges();
        //            Console.WriteLine("New book added successfully");
        //        }

        //        catch(Exception ex)
        //        {
        //            Console.WriteLine(ex.InnerException.Message);
        //        }
        //    }
    }
}
