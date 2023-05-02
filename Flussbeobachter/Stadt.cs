namespace Flussbeobachter {
    internal class Stadt : Beobachter {
        public bool Schutzwand { get; set; } = false;
        public void WasserEvent (object source, FlussEventArgs e) {
            Console.WriteLine("Stadt: {0}\tWasserschutzwände Hochgefahren.", ((Stadt)source).Name);
            this.Schutzwand = true;
        }
    }
}
