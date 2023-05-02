namespace Flussbeobachter {
    internal class Beobachter {
        public event EventHandler<FlussEventArgs> SchiffEvent;
        public event EventHandler<FlussEventArgs> StadtEvent;
        public event EventHandler<FlussEventArgs> KlaerwerkEvent;
        public string Name { get; set; }
        public void beobachten(Fluss fluss) {
            FlussEventArgs EA = new FlussEventArgs();
            if (fluss.Wasserstand < 250 || fluss.Wasserstand > 8000) {
                EA.Wasserstand = fluss.Wasserstand;
                if (SchiffEvent != null) {
                    SchiffEvent(this, EA);
                }
            }
            if (fluss.Wasserstand > 8200) {
                EA.Wasserstand = fluss.Wasserstand;
                if (StadtEvent != null) {
                    StadtEvent(this, EA);
                }
            }
            if (fluss.Wasserstand < 3000 || fluss.Wasserstand > 8000) {
                EA.Wasserstand = fluss.Wasserstand;
                if (KlaerwerkEvent != null) {
                    KlaerwerkEvent(this, EA); }
            }
        }
    }
}
