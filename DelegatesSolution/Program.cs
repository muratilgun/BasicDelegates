using System;

namespace DelegatesSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;

            string theZone;
            do
            {
                // Bölge adını al
                Console.WriteLine("Hangi bölgeye kargo göndermek istiyorsunuz?");
                theZone = Console.ReadLine();

                // eğer kullanıcı çıkış yazarsa programı kapat
                // yoksa devam et
                if (!theZone.Equals("çıkış"))
                {
                    // bölge verildiğinde, ilgili nakliye bilgilerini al
                    theDest = ShippingDestination.getDestinationInfo(theZone);

                    // ilişkili bir bilgi yoksa, kullanıcı geçersiz bir bölge girmiştir
                    // aksi halde devam et
                    if (theDest != null)
                    {
                        // fiyatı iste ve dizeyi ondalık sayıya dönüştür
                        Console.WriteLine("Ürün fiyatı nedir?");
                        string thePriceStr = Console.ReadLine();
                        decimal itemPrice = decimal.Parse(thePriceStr);

                        // Her ShippingDestination nesnesinin calcFees adlı bir işlevi var, 
                        // ve ücreti hesaplamak için delegate kullanır
                        theDel = theDest.calcFees;

                        // Yüksek riskli bölgeler için, daha fazlasını ekleyen delegeyi kullanırız.
                        if (theDest.m_isHighRisk)
                        {
                            theDel += delegate (decimal thePrice, ref decimal itemFee)
                            {
                                itemFee += 25.0m;
                            };
                        }

                        // delegate çağır ve çıktı al
                        // Konsola gönderim ücretini yazdır
                        decimal theFee = 0.0m;
                        theDel(itemPrice, ref theFee);
                        Console.WriteLine("The shipping fees are: {0}", theFee);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış bir varış noktası girdiniz. Tekrar deneyiniz veya 'çıkış' yazınız");
                    }
                }
            } while (theZone != "çıkış");
        }
    }
}
