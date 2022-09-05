// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("Running Successfully");*/
using Batch1_DET_2022;

class MyClass
{


    /* try
     {
         Empp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                             // Console.WriteLine(m.Print());

         Empp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
         // Console.WriteLine(m1.Print());  //base class ref can point to derived object

         Empp e1 = new Empp(1, "Jiyana", new DateTime(2020, 1, 5));
         //Console.WriteLine(e1.Print());

         Console.WriteLine("enter empid b.w 1001 - 25000");
         int id = Convert.ToInt32(Console.ReadLine());
         if (id < 1001 || id > 25000)
             throw new InvalidEmpIdException("Entered empid is not in the range...");

         Console.WriteLine("enter emp name");
         string name = Console.ReadLine();

         Console.WriteLine("enter doj");
         DateTime doj = DateTime.Parse(Console.ReadLine());

         Empp e2 = new(id, name, doj);


         List<Empp> list = new List<Empp>();
         list.Add(m);
         list.Add(m1);
         list.Add(e1);
         foreach (Empp x in list)
             Console.WriteLine(x.Print());
     }
     catch (InvalidEmpIdException e)
     {
         Console.WriteLine(e.Message);
     }
     catch (Exception e)
     { }*/





    //    try
    //    {
    //        Console.WriteLine("Enter your age");
    //        int age = int.Parse(Console.ReadLine());

    //        if (age < 0 || age > 120)
    //            throw new InvalidAgeException("Enter correct age");

    //    }

    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }


    //}
    public static void Main()
    {
        //public GetListofEmployees()
        //{
        //    List<EmployeeLinq> emps = new List<EmployeeLinq>();
        //    emps.Add(new EmployeeLinq(1, "John", "Training"));
        //    emps.Add(new EmployeeLinq(2, "Mark", "Finance"));
        //    emps.Add(new EmployeeLinq(3, "Peter", "Technical"));
        //    emps.Add(new EmployeeLinq(4, "Bob", "Technical"));
        //    emps.Add(new EmployeeLinq(5, "Robert", "Finance"));
        //    emps.Add(new EmployeeLinq(6, "Jason", "Training"));

        //    return emps;
        //}

        // static void SampleEmployeeList()
        //{
        //    List<EmployeeLinq> emps = GetListOfEmployees();
        //    var emp_query = from employee in emps
        //                    select employee;

        //    foreach (var item in emp_query)
        //    {
        //        Console.WriteLine("Name is " + item.Name + "and dept is " + item.Dept);
        //    }
        //    Console.ReadLine();
        //}

        //List<Animal> animal = new List<Animal>();
        //animal.Add(new Dog());
        //animal.Add(new Cat());

        //foreach (Animal a in animal)
        //    Console.WriteLine(a.ToString());

        //PersonDOB p = new PersonDOB();
        //Console.WriteLine(p.DOB(08/06/2023));
        //public static Student Student { get; private set; }

        //public static void Main()
        //{
        //    ScienceStudent Student = new ScienceStudent { regno = 24, Name = "Manasa" };
        //    ScienceStudent sciencesubject = new ScienceStudent { physics = 60, chemistry = 85, maths = 90 };
        //    CommerceStudent Commercessubject = new CommerceStudent { economices = 65, accounts = 75, banking = 80 };

        //    Console.WriteLine(Student.ToString());
        //    Console.WriteLine($"The Average marks of Science subjects {sciencesubject.GetAvgMarks()}");
        //    Console.WriteLine($"The average marks of Commerce Subjects {Commercessubject.GetAvgMarks()}");
        //}
    }
}

        
  