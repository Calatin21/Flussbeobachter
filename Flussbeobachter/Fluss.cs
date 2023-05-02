﻿namespace Flussbeobachter {
    internal class Fluss {
        public string Name { get; set; }
        public int Wasserstand { get; set; }
        public int AlterWasserstand { get; set; } = 0;
        public void Fliesst() {
            Random rnd = new Random();
            this.AlterWasserstand = this.Wasserstand;
            this.Wasserstand = rnd.Next(100, 10001);
        }
    }
}
