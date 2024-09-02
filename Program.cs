using BOX;
using CAR;
using STUDENTS;

Console.Write("baho kiriting 1...5: ");
int enterGrade = int.Parse( Console.ReadLine());

List<Student> students = new List<Student>();

students.Add(new Student { Name = "John", FirstName = "Doer", Room = 9, Grade = 5 });
students.Add(new Student { Name = "Jane", FirstName = "jasen", Room = 9, Grade = 4 });

students.Add(new Student { Name = "ali", FirstName = "Doe", Room = 9, Grade = 3 });
students.Add(new Student { Name = "carry", FirstName = "mona", Room = 9, Grade = 4 });

students.Add(new Student { Name = "tony", FirstName = "Doe", Room = 9, Grade = 5 });
students.Add(new Student { Name = "ivan", FirstName = "Smith", Room = 9, Grade = 3 });

students.Add(new Student { Name = "pulisic", FirstName = "cary", Room = 9, Grade = 5 });
students.Add(new Student { Name = "rakitic", FirstName = "tary", Room = 9, Grade = 4 });

students.Add(new Student { Name = "terry", FirstName = "lyer", Room = 9, Grade = 2 });
students.Add(new Student { Name = "mary", FirstName = "mown", Room = 9, Grade = 1 });

foreach (var student in students)
{
    if (student.Grade == enterGrade)
    {
        Console.WriteLine($"oquvchi id si {student.Id}, oquvchi ismi {student.Name}, oquvchi familiyasi {student.FirstName}, oquvchi honasi {student.Room}, oquvchi bahosi {student.Grade}");
    }
}




// 2 assignment
Console.Write("narh kiriting boshlangich 50,000... : ");
int enterCost = int.Parse( Console.ReadLine());
Console.Write("narh kiriting tugallanish ... 210,000: ");
int enterCost2 = int.Parse( Console.ReadLine());

List<Car> cars = new List<Car>();

cars.Add(new Car { CarName = "AUDI", CarModel = "Q8", CarCost = 210000});
cars.Add(new Car { CarName = "bmw", CarModel = "X7", CarCost = 190000});
cars.Add(new Car { CarName = "merc", CarModel = "w211", CarCost = 90000});
cars.Add(new Car { CarName = "opel", CarModel = "xr", CarCost = 50000});
cars.Add(new Car { CarName = "porsche", CarModel = "911", CarCost = 200000});

foreach (var item in cars)
{
    if (enterCost <= item.CarCost && enterCost2 >= item.CarCost)
    {
        Console.WriteLine($"mashina nomi {item.CarName}, mashina modeli {item.CarModel}, mashina narhi {item.CarCost}");
    }
}






// 3- assignment
List<Box> boxer = new List<Box>();

boxer.Add(new Box { BoxName = "John", BoxFirstname = "Doer", BoxAge = 20, Boxweigh = 75 });
boxer.Add(new Box { BoxName = "Jane", BoxFirstname = "jasen", BoxAge = 22, Boxweigh = 67 });

boxer.Add(new Box { BoxName = "ali", BoxFirstname = "Doe", BoxAge = 18, Boxweigh = 49 });
boxer.Add(new Box { BoxName = "carry", BoxFirstname = "mona", BoxAge = 21, Boxweigh = 63 });

boxer.Add(new Box { BoxName = "tony", BoxFirstname = "Doe", BoxAge = 19, Boxweigh = 105 });
boxer.Add(new Box { BoxName = "ivan", BoxFirstname = "Smith", BoxAge = 24, Boxweigh = 45 });

boxer.Add(new Box { BoxName = "pulisic", BoxFirstname = "cary", BoxAge = 20, Boxweigh = 76 });
boxer.Add(new Box { BoxName = "rakitic", BoxFirstname = "tary", BoxAge = 23, Boxweigh = 84 });

boxer.Add(new Box { BoxName = "terry", BoxFirstname = "lyer", BoxAge = 21, Boxweigh = 90 });
boxer.Add(new Box { BoxName = "mary", BoxFirstname = "mown", BoxAge = 22, Boxweigh = 59 });

foreach (var item in boxer)
{
    if (item.Boxweigh <= 50)
    {
        Console.WriteLine($"boxchi {item.BoxName} yengil vaznli {item.Boxweigh} kg");
    }else if (item.Boxweigh >= 50 && item.Boxweigh <= 76)
    {
        Console.WriteLine($"boxchi {item.BoxName} yengil orta vaznli {item.Boxweigh} kg");
    }else if (item.Boxweigh >= 76 && item.Boxweigh <= 90)
    {
        Console.WriteLine($"boxchi {item.BoxName} orta vaznli {item.Boxweigh} kg");
    }else{
        Console.WriteLine($"boxchi {item.BoxName} ogir vaznli {item.Boxweigh} kg");
    }
}