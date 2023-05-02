namespace Flussbeobachter {
    internal class Schiff : Beobachter {
        public bool faehrt { get; set; } = true;
        public void WasserEvent(object source, FlussEventArgs e) {
            Console.WriteLine("Schiff: {1} angehalten.", e.Wasserstand, ((Schiff)source).Name);
            this.faehrt = false;
        }
    }
}
