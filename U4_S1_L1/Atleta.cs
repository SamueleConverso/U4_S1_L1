namespace U4_S1_L1
{
    internal class Atleta
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Atleta(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }   

        public void ShowData()
        {
            Console.WriteLine("Nome: " + FirstName + " | Cognome: " + LastName + " | Età: " + Age);
        }
    }
}
