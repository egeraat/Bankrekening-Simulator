namespace BankRekeningSimulator
{
    class BankAccount
    {


        private decimal balance; //private variabel zodat de gegevens beschermd worden tegen ongewenste wijzingen buitenaf


        public BankAccount(decimal startsaldo)
        {
            balance = startsaldo;
        }

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
    }
}