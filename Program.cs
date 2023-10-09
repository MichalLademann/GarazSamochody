using SamochodyBasic;

Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
Garaz g1 = new Garaz("ul. Garażowa 1", 1);
Garaz g2 = new Garaz("ul. Garażowa 2", 2);

g1.WprowadzSamochod(s1);
g1.WprowadzSamochod(s2);
g1.WyprowadzSamochod(); // Poprawka: Wywołanie metody bez argumentów

g2.WprowadzSamochod(s2);
g2.WprowadzSamochod(s1);

Console.WriteLine("Informacje o garażu g1:");
g1.WypiszInfo();

Console.WriteLine("\nInformacje o garażu g2:");
g2.WypiszInfo();

Console.ReadKey();