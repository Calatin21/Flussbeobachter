namespace Flussbeobachter {
    internal class Stadt : Beobachter {
        public bool Schutzwand { get; set; } = false;
        public void WasserEvent (object source, FlussEventArgs e) {
            if (e.Wasserstand > 8200) {
                Console.WriteLine("Stadt: {0}\tWasserschutzwände Hochgefahren.", ((Stadt)source).Name);
                this.Schutzwand = true;
            }
            if (e.Wasserstand <= 8200) {
                if (this.Schutzwand == true) {
                    Console.WriteLine("Stadt: {0}\tWasserschutzwände Runtergefahren.", ((Stadt)source).Name);
                    this.Schutzwand = false; }
            }
        }
    }
}
