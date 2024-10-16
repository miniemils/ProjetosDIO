using src.Models;

Console.WriteLine("Smartphone Samsung");
Samsung s = new Samsung("96123-4567", "Galaxy S23", "353490561234567", 254);
s.Ligar();
s.ReceberLigaçao();
s.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone i = new Iphone("99345-6789", "16 Pro Max", "490154203237518", 128);
i.Ligar();
i.ReceberLigaçao();
i.InstalarAplicativo("Messages");