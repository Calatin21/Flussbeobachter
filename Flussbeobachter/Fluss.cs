namespace Flussbeobachter {
    internal class Fluss {
        public string Name { get; set; }
        public int Wasserstand { get; set; }
        public void Fliesst() {
            Random rnd = new Random();
            this.Wasserstand = rnd.Next(100, 10001);
        }
    }
}
