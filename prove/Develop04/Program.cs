using System;

class Program
{
 
    int choice;
    static void Main(string[] args)
    {
   string menuUserinput="";
          while (menuUserinput != 4)
           {
        Console.WriteLine(@"what is your choose between 1-5);
        .......1.Breathing Activity
        ........2.Reflecting Activity
        ........3.Listing Activity 
        ........4 Exit 
        ");

        System.Console.WriteLine("what is your choice ");
        String userInput =Console.ReadLine();

          
           
         

       

          if (userInput == "1") {

            BreathingActivity breathingactivity = new BreathingActivity();
            breathingactivity.start();


        }

        else if (userInput =="2"){

            ListingActivity Listingactivity = new ListingActivity();
            ListingActivity.start();
        }

        else if  (userInput =="3") {
          
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            ReflectingActivity.start();
        }

        else{
          Console.WriteLine(" choose between 1 -3");
        }

        }
           }
    }
  
}