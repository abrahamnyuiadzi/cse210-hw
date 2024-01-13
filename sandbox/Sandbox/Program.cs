using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        DisplayMessage();
        
Console.Write("What is your favorite color? ");
string color = Console.ReadLine();
Console.WriteLine(color);
string response ;

do{
 Console.Write("type you first number ");
 string  number = Console.ReadLine();

int x =int.Parse(number);
int y =7;
if (x>y){
Console.WriteLine("greater");
}
else if (x<y){
    Console.WriteLine("less");
}
else{
    Console.WriteLine("equal ");
}
 Console.Write("Do you want to continue? ");
    response = Console.ReadLine();

}while(response=="yes");

static void DisplayMessage (){

List<string> words = new List<string>();

words.Add("phone");
words.Add("keyboard");
words.Add("mouse");


Console.WriteLine(words.Count);
}
    }
}