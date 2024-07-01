using System;
using TextCopy;
class Program
{
     static void Main(string[] args)
    {
        do{
            UserInterface();
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            switch(checkNumber){
                case 1:
                Console.WriteLine(GuidGeneration().ToString());break;
                case 2: UtcNowGeneration();Console.WriteLine($"Clipboard text is {ClipboardService.GetText()}");break;
                default: Console.WriteLine("Please select only 1 or 2");break;
            }
        }
        while(IsTrue());

        static void UtcNowGeneration(){
            string generationUtcNow = DateTimeOffset.UtcNow.ToString();
            TextCopy.ClipboardService.SetText(generationUtcNow);
            // Console.WriteLine($"{ClipboardService.GetText()}\nCopied...");
        }
        static bool IsTrue(){
                bool isTrue = true;
                string checkFlag ="";
                Console.WriteLine("Do you want to continue? (yes / no)");
                checkFlag = Console.ReadLine().ToLower();
                isTrue = checkFlag is "yes" or "y";
                return isTrue;
        }
        static string GuidGeneration(){
            string  generationGuid = Guid.NewGuid().ToString();
            return generationGuid;
            // Console.WriteLine($" New Guid is => {GenerationGuid}");
        }
        static void UserInterface(){
            Console.WriteLine("Welcome to the project GUID Generator!!!");
            Console.WriteLine("Select if you need new guid press 1 if you need current time press 2");
        }
    }
}