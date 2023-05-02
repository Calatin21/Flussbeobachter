namespace Flussbeobachter {
    internal class Klaerwerk : Beobachter {
        public bool Einleiten { get; set; }
        public int Einleitungsmenge { get; set; } = 100;
        public void WasserEvent(object source, FlussEventArgs e) {
            if (e.Wasserstand > 8000) {
                Console.WriteLine("Klärwerk: {0}\tWasserstand über 8000, Einleitung wird gestoppt", ((Klaerwerk)source).Name);
            }
            else if (e.Wasserstand < 3000) {
                Console.WriteLine("Klärwerk: {0}\tWasserstand zu niedrig, Einleitungsmenge verdoppelt.", ((Klaerwerk)source).Name);
                this.Einleitungsmenge = this.Einleitungsmenge * 2;
            }
        }
    }
}
