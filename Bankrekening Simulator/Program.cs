using System;

namespace BankRekeningSimulator
{
    class Program
    {
        static void Main(string[] args) // static = direct aan de class gekoppeld, niet aan een object van die class
        {
            BankAccount mijnRekening = new BankAccount(100); // Creëert een nieuw BankAccount object met een start saldo van 100

            while (true) // Oneindige loop om de gebruiker steeds keuzes te laten maken
            {
                Console.WriteLine("Maak een keuze hieronder");
                Console.WriteLine("(1) Saldo bekijken - Show Balance ");
                Console.WriteLine("(2) Storten - deposit");
                Console.WriteLine("(3) Opnemen - withdraw");
                Console.WriteLine("(4) Exit");

                string keuzemenu = Console.ReadLine(); // Leest de keuze van de gebruiker

                if (keuzemenu == "1") // (1) Toon het saldo
                {
                    mijnRekening.ShowBalance(); // Roept de ShowBalance-methode van BankAccount aan
                }
                else if (keuzemenu == "2") // (2) Geld storten
                {
                    Console.WriteLine("Hoeveel wil je storten?");
                    if (decimal.TryParse(Console.ReadLine(), out decimal bedrag)) // Controleert of de input een geldig decimaal getal is
                    {
                        mijnRekening.Deposit(bedrag); // Stort het bedrag op de rekening
                    }
                    else
                    {
                        Console.WriteLine("Voer een geldig bedrag in.");
                    }
                }
                else if (keuzemenu == "3") // (3) Geld opnemen
                {
                    Console.WriteLine("Hoeveel wil je opnemen?");
                    if (decimal.TryParse(Console.ReadLine(), out decimal bedrag)) // Controleert of de input een geldig decimaal getal is
                    {
                        mijnRekening.Withdraw(bedrag); // Neemt het bedrag op van de rekening
                    }
                    else
                    {
                        Console.WriteLine("Voer een geldig getal in.");
                    }
                }
                else if (keuzemenu == "4") // (4) Stop het programma
                {
                    Console.WriteLine("Programma wordt afgesloten.");
                    break; // Verlaat de loop en stopt het programma
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze."); // In geval van een verkeerde invoer
                }
            }
        }
    }
}
