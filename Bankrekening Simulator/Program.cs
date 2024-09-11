using System;
using System.Security.Cryptography.X509Certificates;

namespace BankRekeningSimulator
{
    class BankAccount
    {
        private decimal balance; //private variabel zodat de gegevens beschermd worden tegen ongewenste wijzingen buitenaf

        public void Deposit(decimal hoeveelheid) //methode Deposit
        {
            if (hoeveelheid > 0)
            {
                balance += hoeveelheid; //voegt het bedrag toe aan de hoeveelheid geld we hebben 
                Console.WriteLine($"{hoeveelheid} is gestort op je rekening. Je hebt nu in totaal {balance}");
            }
            else
            {
                Console.WriteLine("Het moet een getal zijn en het getal moet positief zijn");
            }
        }

        public void Withdraw(decimal hoeveelheid)
        {
            if (hoeveelheid > 0)
            {
                balance -= hoeveelheid; //hetzelfde als net alleen nu withdraw dus veranderen we + in -
                Console.WriteLine($"{hoeveelheid} is opgenomen van je rekening. Je hebt nu in totaal {balance}");
            }
            else
            {
                Console.WriteLine("Het moet een getal zijn en het getal moet positief zijn");
            }
        }

        // Methode ShowBalance aangepast zodat deze geen parameter vereist
        public void ShowBalance()
        {
            Console.WriteLine($"Je huidige saldo is: {balance}");
        }

        static void Main(string[] args) //static = direct aan de class gekoppeld niet aan een object van die class
        {
            BankAccount mijnRekening = new BankAccount(); //Creëert een nieuw BankAccount object
            mijnRekening.Deposit(100); //stort 100 euro

            while (true)
            {
                Console.WriteLine("Maak een keuze hieronder");
                Console.WriteLine("(1) Saldo bekijken - Show Balance ");
                Console.WriteLine("(2) Storten - deposit");
                Console.WriteLine("(3) Opnemen - withdraw");
                Console.WriteLine("(4) Exit");

                string keuzemenu = Console.ReadLine(); //Leest de keuze van de gebruiker

                if (keuzemenu == "1") //(1)
                {
                    mijnRekening.ShowBalance(); // Aangepaste aanroep zonder argument
                }
                else if (keuzemenu == "2") //(2)
                {
                    Console.WriteLine("Hoeveel wil je storten");
                    if (decimal.TryParse(Console.ReadLine(), out decimal bedrag))
                    {
                        mijnRekening.Deposit(bedrag);
                    }
                    else
                    {
                        Console.WriteLine("Voer een geldig bedrag in");
                    }
                }
                else if (keuzemenu == "3")
                {
                    Console.WriteLine("Hoeveel wil je opnemen?");
                    if (decimal.TryParse(Console.ReadLine(), out decimal bedrag))
                    {
                        mijnRekening.Withdraw(bedrag);
                    }
                    else
                    {
                        Console.WriteLine("Voer een geldig getal in");
                    }
                }
                else if (keuzemenu == "4")
                {
                    Console.WriteLine("Programma wordt afgesloten");
                    break; //verlaat loop en stopt het programma
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                }
            }
        }
    }
}
