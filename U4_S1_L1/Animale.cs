namespace U4_S1_L1 {
    public class Animale {
        public string Name {
            get; set;
        }

        public int Age {
            get; set;
        }

        public Animale(string name, int age) {
            Name = name;
            Age = age;
        }

        public void ShowData() {
            Console.WriteLine("ANIMALE - Nome: " + Name + " | Età: " + Age);
        }
    }
}