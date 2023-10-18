using Assignment_18_10_23;

Console.WriteLine("Enter the Name");
string name=Console.ReadLine();
Console.WriteLine("Enter the marks");
int markone=Convert.ToInt32(Console.ReadLine());
int marktwo=Convert.ToInt32(Console.ReadLine());
int markthree=Convert.ToInt32(Console.ReadLine());
CalculateAverage calculateAverage=new CalculateAverage(markone, marktwo, markthree,name);
Console.WriteLine($"Name Of Student is: {name}");
Console.WriteLine($"Average Mark is:{calculateAverage.CalculateAverageMark()}");
Console.WriteLine($"Total Mark is:{calculateAverage.TotalMark()}");
Console.WriteLine($"Grade is:{calculateAverage.GetGrade()}");

