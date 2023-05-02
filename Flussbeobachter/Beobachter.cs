namespace Flussbeobachter {
    internal class Beobachter {
        public event EventHandler<FlussEventArgs> SchiffEvent;
        public event EventHandler<FlussEventArgs> StadtEvent;
        public event EventHandler<FlussEventArgs> KlaerwerkEvent;
        public string Name { get; set; }
        public void beobachten(Fluss fluss) {
            FlussEventArgs EA = new FlussEventArgs();
            EA.Wasserstand = fluss.Wasserstand;
            if (SchiffEvent != null) {
                SchiffEvent(this, EA);
            }
            if (StadtEvent != null) {
                StadtEvent(this, EA);
            }
            if (KlaerwerkEvent != null) {
                KlaerwerkEvent(this, EA);
            }
        }
    }
}