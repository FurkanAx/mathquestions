using System;

namespace mathquestions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			Random sayiolustur = new Random();
Start:
			int num01 = sayiolustur.Next(1, 11);
int num02 = sayiolustur.Next(10, 26);
Console.WriteLine(num01 + "x" + num02 + "= ?");

			Soru:
			int sonuc = Convert.ToInt32(Console.ReadLine());

			if (sonuc == num01* num02)
			{
				int randomline2 = sayiolustur.Next(1, 4);
				switch (randomline2)
				{
					case 1:
						Console.WriteLine("Tebrikler! Doğru cevap.");
						break;
					case 2:
						Console.WriteLine("Bravo! Hadi başka bir şey daha yapalım.");
						break;
					case 3:
						Console.WriteLine("Sanırım bu konuda başarılısın!");
						break;
				}
				goto Start;
			}

			else {
				int randomline = sayiolustur.Next(1, 4);
				switch (randomline)
				{
					case 1:
						Console.WriteLine("Olmadı.. Tekrar deneyelim.");
						break;
					case 2:
						Console.WriteLine("Hadi ama, basit matematik dostum.");
						break;
					case 3:
						Console.WriteLine("Bence yapabilirsin. Bi' daha desenese.");
						break;
						
				}
				goto Soru;
			
			}

			Console.ReadKey();
		
		}
	}
}
