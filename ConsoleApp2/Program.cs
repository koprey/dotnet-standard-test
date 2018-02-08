using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // sqlite
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }

            Console.WriteLine("SQL server");

            using(var db1 = new Db1Context())
            {
                foreach (var d in db1.Directors)
                {
                    Console.WriteLine($"{d.Id}: {d.fname} {d.lname}");
                }
            }



            Console.ReadLine();
        }
    }
}
