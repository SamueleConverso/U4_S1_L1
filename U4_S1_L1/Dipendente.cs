namespace U4_S1_L1
{
    internal class Dipendente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Dipendente(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void ShowData()
        {
            Console.WriteLine("DIPENDENTE - Nome: " + FirstName + " | Cognome: " + LastName + " | Età: " + Age);
        }
    }
}
