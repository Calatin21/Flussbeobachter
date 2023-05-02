namespace Flussbeobachter {
    internal class Klaerwerk : Beobachter {
        public bool Einleiten { get; set; } = true;
        public int Einleitungsmenge { get; set; } = 100;
        public void WasserEvent(object source, FlussEventArgs e) {
            if (e.Wasserstand > 8000) {
                if (this.Einleiten == true) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Klärwerk: {0}\tWasserstand über 8000, Einleitung wird gestoppt", ((Klaerwerk)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Einleiten = false;
                }
            }
            if (e.Wasserstand < 3000) {
                if (this.Einleitungsmenge == 100) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Klärwerk: {0}\tWasserstand zu niedrig, Einleitungsmenge verdoppelt.", ((Klaerwerk)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    this.Einleitungsmenge *= 2;
                }
            }
            if (e.Wasserstand > 3000 && e.Wasserstand < 8000) {
                if (this.Einleiten == false) {
                    this.Einleiten = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Einleitung wieder gestartet.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (this.Einleitungsmenge > 100) {
                    this.Einleitungsmenge /= 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Einleitungsmenge wieder halbiert.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
