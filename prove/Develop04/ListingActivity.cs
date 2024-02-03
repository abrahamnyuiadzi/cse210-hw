public class ListingActivity{

  int _time;

      public  String DisplayMessage()
    {

  return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

    public void GetRandomPrompt(){

      System.Console.WriteLine("Who are people that you appreciate?");
     
      System.Console.WriteLine("What are personal strengths of yours??");
     
      System.Console.WriteLine("Who are people that you have helped this week?");
      
      System.Console.WriteLine("When have you felt the Holy Ghost this month?");
      
      System.Console.WriteLine("Who are some of your personal heroes?");


    }
      public  void GetTime()
    {

 Console.Write(" how long in second do you like for your session ? : ");
 int usercount = Console.ReadLine();

 //for (int i =5 ;i> 0;i--){
// Console.Write(5);
 //Thread.Sleep(1000);
// }

List<String> animationStrings =new List<String>();
animationStrings.Add("|") ;
animationStrings.Add("/") ;
animationStrings.Add("-") ;
animationStrings.Add("/") ;
animationStrings.Add("\\") ;
//foreach(string s in animationStrings)
//{
 // Console.WriteLine(s);
 // Thread.Sleep(1000);
 // Console.Write("\b \b");
//}
DateTime  startTime = DateTime.Now;
DateTime  endTime = startTime.AddSeconds(30);

int i = 0;
while(DateTime.Now < endTime) 
{
  String s =animationStrings[i];
Console.WriteLine(s);
  Thread.Sleep(1000);
  Console.Write("\b \b");

  i++;
  if(i >= animationStrings.Count) 
  {
 i= 0;
  }
}

;

  for (int i =5 ;i> 0;i--){
 Console.Write(5);
 Thread.Sleep(1000);
 
 }


 Console.WriteLine("Done");
 
    }



    public string GetListFromUser (){

      List<String> words =new List<String>();

      words.Add(word);

      Console.WriteLine(words.Count);



    }


}