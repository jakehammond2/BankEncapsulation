
using BankEncapsulation;

var BankAccount1 = new BankAccount();

Console.WriteLine("Welcome to your bank account\n");


Console.WriteLine("Would you like to withdraw money?\n");

var withdrawInput = Console.ReadLine();

if (withdrawInput == "yes")
{
    Console.WriteLine("How much do you want to withdraw?\n");

    var withdrawAmount = Convert.ToInt32((Console.ReadLine()));


    BankAccount1.Withdrawel(withdrawAmount);

    Console.WriteLine($"Your account balance after your withdrawel is now {BankAccount1.GetBalance()}\n");
}


Console.WriteLine("Would you like to deposit money?\n");

var depositInput = Console.ReadLine();

    if (depositInput == "yes")
    {
        Console.WriteLine("How much money do you want to deposit?\n");

        var depositAmount = Convert.ToInt32(Console.ReadLine());

        BankAccount1.Deposit(depositAmount);

        Console.WriteLine($"You account balance after your deposit is now {BankAccount1.GetBalance()}\n");
    }



Console.WriteLine($"Your balance is {BankAccount1.GetBalance()}");



//Console.WriteLine("Would you like to deposit money?\n");





//BankAccount1.Deposit();
//BankAccount1.GetBalance(); 