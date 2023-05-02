﻿namespace Flussbeobachter {
    internal class Program {
        static void Main(string[] args) {
            Fluss fluss1 = new Fluss() { Name = "Rhein" };
            Stadt stadt1a = new Stadt() { Name = "Köln" };
            Stadt stadt1b = new Stadt() { Name = "Düsseldorf" };
            Schiff schiff1a = new Schiff() { Name = "Rheingold" };
            Schiff schiff1b = new Schiff() { Name = "Lorelei" };

            Fluss fluss2 = new Fluss() { Name = "Donau" };
            Stadt stadt2a = new Stadt() { Name = "Ulm" };
            Schiff schiff2a = new Schiff() { Name = "Xaver" };
            Schiff schiff2b = new Schiff() { Name = "Unser Franz" };
            Klaerwerk kwerk = new Klaerwerk() { Name = "Söder 1" };

            schiff1a.SchiffEvent += schiff1a.WasserEvent;
            schiff1b.SchiffEvent += schiff1b.WasserEvent;
            stadt1a.StadtEvent += stadt1a.WasserEvent;
            stadt1b.StadtEvent += stadt1b.WasserEvent;

            stadt2a.StadtEvent += stadt2a.WasserEvent;
            schiff2a.SchiffEvent += schiff2a.WasserEvent;
            schiff2b.SchiffEvent += schiff2b.WasserEvent;
            kwerk.KlaerwerkEvent += kwerk.WasserEvent;

            while (true) {
                Console.Clear();
                fluss1.Fliesst();
                Console.WriteLine("Fluss: {1}\tWasserstand: {0}\talter Wasserstand: {2}", fluss1.Wasserstand, fluss1.Name, fluss1.AlterWasserstand);
                schiff1a.beobachten(fluss1);
                schiff1b.beobachten(fluss1);
                stadt1a.beobachten(fluss1);
                stadt1b.beobachten(fluss1);
                Console.WriteLine("-----------------------------------------------------------------");
                fluss2.Fliesst();
                Console.WriteLine("Fluss: {1}\tWasserstand: {0}\talter Wasserstand: {2}", fluss2.Wasserstand, fluss2.Name, fluss2.AlterWasserstand);
                schiff2a.beobachten(fluss2);
                schiff2b.beobachten(fluss2);
                stadt2a.beobachten(fluss2);
                kwerk.beobachten(fluss2);
                Console.Read();//Thread.Sleep(1000);
            }


        }
    }
}