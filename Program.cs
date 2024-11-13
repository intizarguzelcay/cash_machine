// See https://aka.ms/new-console-template for more information
string choice ="";
double balance =0;

do
{
   

   Console.Write("1-Blance inquiry\n2-Deposit\n3-Withdrawal\n4-Exit\nYour choice: ");
   choice = Console.ReadLine();

   switch (choice)
{
    case "1":
         Console.WriteLine("Your balance {0} TL", balance);
         break;
    case "2":
         Console.WriteLine(" The amount you want to deposit: ");
         double deposited = double.Parse(Console.ReadLine());
         balance+= deposited;
         break;
    case "3":
         Console.WriteLine("The amount you want to withdrawn: ");
         double withdrawn = double.Parse(Console.ReadLine());
         if(withdrawn>balance)
            Console.WriteLine("Your balance is insufficient.");
         else
             balance-=withdrawn;
         break;
    case "4":
         Console.WriteLine("Exit.");
         break;
    
    default:
         Console.WriteLine("Wrong choice.");
         break;
}

} while (choice!="4");

Console.WriteLine("Aplication exited.");