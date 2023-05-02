namespace Flussbeobachter {
    internal class Schiff : Beobachter {
        public bool faehrt { get; set; } = true;
        public void WasserEvent(object source, FlussEventArgs e) {
            if (e.Wasserstand < 250 || e.Wasserstand > 8000) {
                if (this.faehrt == true) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Schiff: {1} angehalten.", e.Wasserstand, ((Schiff)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    this.faehrt = false;
                }
            }
            if (e.Wasserstand >= 250 && e.Wasserstand <= 8000) {
                if (this.faehrt == false) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Schiff: {1} fährt wieder.", e.Wasserstand, ((Schiff)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    this.faehrt = true;
                }
            }
        }
    }
}
