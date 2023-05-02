// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to A-Host");

//Console.WriteLine("Hello {0}", "World");


//int num1 = 6;
//long num2 = 10;
//Console.WriteLine(num2 + num1);
//Console.WriteLine("num1 = {0}", num1);
//Console.WriteLine("num2 = {0}", num2);



//Console.WriteLine(Math.Pow(2,8));


//string name1,name2;
//float weight1,weight2;
//float height1,height2;

//Console.Write("Student : ");
//name1 = Console.ReadLine();

//Console.Write("Weight : ");
//weight1 = float.Parse(Console.ReadLine());

//Console.Write("Height : ");
//height1 = float.Parse(Console.ReadLine());

//Console.Write("Student : ");
//name2 = Console.ReadLine();

//Console.Write("Weight : ");
//weight2 = float.Parse(Console.ReadLine());

//Console.Write("Height : ");
//height2 = float.Parse(Console.ReadLine());


//float heightInMeter1 = height1 / 100;
//float bmi1 = weight1 / (heightInMeter1 * heightInMeter1);

//float heightInMeter2 = height2 / 100;
//float bmi2 = weight2 / (heightInMeter2 * heightInMeter2);



//Console.WriteLine("Student");
//Console.WriteLine("name: " + name1.ToUpper());
//Console.WriteLine("BMI: " + Math.Round(bmi1, 2));

//Console.WriteLine("Student");
//Console.WriteLine("name: " + name2.ToUpper());
//Console.WriteLine("BMI: " + Math.Round(bmi2, 2));

//float maxBmi = Math.Max(bmi1, bmi2);
//Console.WriteLine("Most BMI : " + Math.Round(maxBmi, 2));

//double x = 7;
//double y=3;
//Console.WriteLine(x % y);

//Console.WriteLine(x=3);
//x = 7;
//Console.WriteLine(x+=3);
//x = 7;
//Console.WriteLine(x-=3);
//x = 7;
//Console.WriteLine(x/=3);
//x= 7;
//Console.WriteLine(x%=3);
//x= 7;

//string role = "admin";
//if (role == "admin")
//{
//    Console.WriteLine("adminkup");
//}
//else if (role == "admin1")
//{
//    Console.WriteLine("admin1");
//}
//else
//{
//    Console.WriteLine("Not admin");
//}

//Console.Write("Your postition : ");
//string pos = Console.ReadLine();
//Console.Write("Your salary : ");
//float salary = float.Parse(Console.ReadLine());
//if(pos == "assistant developer")
//{
//    float salary1 = (float)(salary * 0.05);
//    Console.Write("Your salary will be increased : ");
//    Console.WriteLine(salary + salary1);
//}
//else if (pos == "it support")
//{
//    float salary1 = (float)(salary*0.07);
//    Console.Write("Your salary will be increased : ");
//    Console.WriteLine(salary + salary1) ;
//}else if (pos == "senior developer")
//{
//    float salary1 = (float)(salary * 0.1);
//    Console.Write("Your salary will be increased : ");
//    Console.WriteLine(salary + salary1);
//}else if (pos == "administrator")
//{
//    float salary1 = (float)(salary * 0.08);
//    Console.Write("Your salary will be increased : ");
//    Console.WriteLine(salary + salary1);
//}else
//{
//    float salary1 = (float)(salary * 0.3);
//    Console.Write("Your salary will be increased : ");
//    Console.WriteLine(salary + salary1);
//}

//int num = 0;
//while (num<=5)
//{
//    ++num;
//    Console.WriteLine(num);
//}
//Console.WriteLine("exit loop");

//do
//{
//    ++num;
//    Console.WriteLine(num);
//}


//string[] cars = new string[] { "ford", "toyota", "lambogini" };
//Array.Resize(ref cars, 4);
//cars[3] = "BMW";

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//Console.WriteLine("--------------------------");
//Array.Reverse(cars);

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//string[] cars2 = new string[4];
//Array.Copy(cars, cars2, 3);

//foreach (string car in cars2)
//{
//    Console.WriteLine(car);
//}

//Console.WriteLine(Array.IndexOf(cars, "ford"));

//HashSet<int> SetOfNumber = new HashSet<int>();
//SetOfNumber.Add(1);
//SetOfNumber.Add(100);
//SetOfNumber.Add(50);

//foreach (int i in SetOfNumber)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(SetOfNumber.Count);

//HashSet<int> SetOfNumber = new HashSet<int>();
//SetOfNumber.Add(1);
//SetOfNumber.Add(100);
//SetOfNumber.Add(50);

//foreach (int i in SetOfNumber)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(SetOfNumber.Count);

//------------- Dictionary --------------//

//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics;

//Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
//citiesPopulation.Add("Bangkok", 1000000);
//citiesPopulation.Add("Pattaya", 500000);
//Console.WriteLine(citiesPopulation["Bangkok"]);


//int num;
//if (citiesPopulation.TryGetValue("Bangkok1",out num))
//{
//    Console.WriteLine(num);
//}else
//{
//    Console.WriteLine("No Bangkok");
//}
//if (citiesPopulation.ContainsKey("Bangkok"))
//{
//    Console.WriteLine("Bangkok");
//}else
//{
//    Console.WriteLine("No Bangkok");
//}

//foreach (KeyValuePair<string,int>number in citiesPopulation)
//{
//    Console.WriteLine(number.Key);
//}


//Console.Write("Number of Student : ");
//int num = int.Parse(Console.ReadLine());

//for (int i = 0; i < num;i++)
//{
//    Console.Write("Enter student ID : ");
//    string studentID= Console.ReadLine();
//    Console.Write("Enter student score : ");
//    int studentScore = int.Parse(Console.ReadLine());
//    Console.Write("Student Id "+ studentID);
//    Console.Write(" ");
//    Console.WriteLine("score is "+ studentScore);
//    Console.WriteLine(" ");

//}
//string exitChoice = "";
//while (exitChoice != "Y")
//{
//    Console.Write("Exit? (Y/N): ");
//    exitChoice = Console.ReadLine().ToUpper();
//}
//Console.WriteLine("Result :");
//Console.WriteLine("-------------------------");
//Console.WriteLine("All Student : " + num);

//public void PrintInfo()
//{
//    Console.WriteLine("Name : {0}")
//}

// class Employee:person
//class Program
//{
//    public static void Main()
//    {
//        person P2 = new person();
//        P2.Name = "Book";
//        P2.Age = 24;
//        P2.PrintInfo();

//        Employee E1 = new Employee();
//        E1.Name = "Pond";
//        E1.Age = 22;

//    }
//}


class Human
{
    public int age;
    public string name;
    public string lastname;

    public int Age { get { return age; } set { age = value; } }
    public string Name { get { return name; } set{ name = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public virtual int Run()
    {
        return age;
    }
   
}
internal class pond : Human
{
    public pond(int age, string name,string lastname)
    {
        Age = age;
        Name = name;
        Lastname = lastname;
    }
    public override int Run()
    {
        return age;
    }
    
}
public class Program
{
    public static void Main()
    {
       pond pond = new pond(22,"Thanaphol","Kettabtim");   
       string name = pond.Name;
       string lastname = pond.Lastname;
       int age = pond.Run();
       Console.WriteLine($"Name : {name}");
       Console.WriteLine($"Lastname : {lastname}");
       Console.WriteLine($"Age  : {age}");
    }
}
