using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Daniel";
            string secondName = "Ivanov";
            string lastName = "Damyanov";
            double balance = 10000.50;
            string bankName = "UBB";
            object IBAN = "88UBB566465786654";
            long firstCreditCardNumber = 1845667897564;
            long secondCreditCardNumber = 1869764311544;
            long thirdCreditCardNumber = 1865456644476;
            
            Console.WriteLine(" First Name: {0}\n Second Name: {1}\n Last Name: {2}\n Balance: {3}\n Bank Name: {4}\n IBAN: {5}\n ", firstName, secondName, lastName, balance, bankName, IBAN);
            Console.WriteLine("Credit cards\n Credit card number\n 1.{0}\n 2.{1}\n 3.{2}\n", firstCreditCardNumber,secondCreditCardNumber,thirdCreditCardNumber);
        }
    }

