namespace Flussbeobachter {
    internal class Stadt : Beobachter {
        public bool Schutzwand { get; set; } = false;
        public void WasserEvent(object source, FlussEventArgs e) {
            if (e.Wasserstand > 8200) {
                if (this.Schutzwand == false) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Stadt: {0}\tWasserschutzwände Hochgefahren.", ((Stadt)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    this.Schutzwand = true; }
            }
            if (e.Wasserstand <= 8200) {
                if (this.Schutzwand == true) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Stadt: {0}\tWasserschutzwände Runtergefahren.", ((Stadt)source).Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    this.Schutzwand = false;
                }
            }
        }
    }
}
