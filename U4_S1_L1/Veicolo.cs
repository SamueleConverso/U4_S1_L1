namespace U4_S1_L1 {
    internal class Veicolo {
        public string Name {
            get; set;
        }

        public string Brand {
            get; set;
        }

        public Veicolo(string name, string brand) {
            Name = name;
            Brand = brand;
        }

        public void ShowData() {
            Console.WriteLine("VEICOLO - Nome: " + Name + " | Brand: " + Brand);
        }
    }
}