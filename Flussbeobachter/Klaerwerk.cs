namespace Flussbeobachter {
    internal class Klaerwerk : Beobachter {
        public bool Einleiten { get; set; } = false;
        public int Einleitungsmenge { get; set; } = 100;
        public void WasserEvent(object source, FlussEventArgs e) {
            if (e.Wasserstand > 8000) {
                Console.WriteLine("Klärwerk: {0}\tWasserstand über 8000, Einleitung wird gestoppt", ((Klaerwerk)source).Name);
                Einleiten = false;
            }
            else if (e.Wasserstand < 3000) {
                Console.WriteLine("Klärwerk: {0}\tWasserstand zu niedrig, Einleitungsmenge verdoppelt.", ((Klaerwerk)source).Name);
                this.Einleitungsmenge *= 2;
            }
            if (e.Wasserstand > 3000 && e.Wasserstand < 8000) {
                if (Einleiten == false) {
                    Einleiten = true;
                    Console.WriteLine("Einleitung wieder gestartet.");
                }
                if (Einleitungsmenge > 100) {
                    Einleitungsmenge /= 2;
                    Console.WriteLine("Einleitungsmenge wieder halbiert.");
                }
            }
        }
    }
}
