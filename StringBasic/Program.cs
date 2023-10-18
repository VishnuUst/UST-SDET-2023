// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Two String");
string? s1 = "";
string? s2 = "";
string? s3 = "";
s1 = Console.ReadLine();
s2 = Console.ReadLine();
s3 = Console.ReadLine();
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s2.Substring(3));
Console.WriteLine(s1 + " " + s2);
Console.WriteLine(s3);
string[] s=s3.Split(' ');
for(int i=0; i<s.Length; i++)
{
    Console.WriteLine(s[i]);
}
