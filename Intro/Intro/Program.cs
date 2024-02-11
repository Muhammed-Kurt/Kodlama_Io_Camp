// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase // İlk kelime küçük diğerleri büyük harfle başlar.
bool isAuthenticated = false;

Console.WriteLine(message1);

//condition // Şart
if (isAuthenticated) //ile (isAuthenticated == true) aynı
{
    Console.WriteLine("Button --> Hoşgeldin Muhammed");
}
else
{
    Console.WriteLine("Button --> Sisteme Giriş Yap");
}

//array[]

string[] loans = ["Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"]; //loans = krediler
//string[] loans2 = new string[6]; //2.Yol
//loans2[0] = "Kredi 1";

for (int i = 0/*start*/; i < loans.Length /*condition*/; i++/*increment*/)
{
    Console.WriteLine(loans[i]);
}

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs...";
//course1.Price = 0;


//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "JAVA";
//course2.Description = "Java 17 ....";
//course2.Price = 10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12...";
//course3.Price = 20;

//courses[0] = course1;
//courses[1] = course2;
//courses[2] = course3;

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}


CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "123456";
customer3.TaxNumber = "12345678987";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.CustomerNumber = "654779";
customer3.TaxNumber = "12345678985";


BaseCustomer[] customers =
{
    customer1, customer2, customer3, customer4
};

//Polymorphism
foreach (var customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}