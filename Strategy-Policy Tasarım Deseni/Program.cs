using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Policy_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriYonetim musteriYonetim = new MusteriYonetim();
            musteriYonetim.KrediHesaplamaBase = new Once2010();
            musteriYonetim.Krediler();
            Console.ReadLine();

        }


    }

    abstract class KrediHesaplamaBase
    {
        public abstract void Hesap();

    }

    class Once2010 : KrediHesaplamaBase
    {
        public override void Hesap()
        {
            Console.WriteLine("Kredi 2010'dan Öncesine Göre Hesaplandı");

        }

    }

    class Sonra2010 : KrediHesaplamaBase
    {
        public override void Hesap()
        {
            Console.WriteLine("Kredi 2010'dan Sonrasına Göre Hesaplandı");

        }
    }

    class MusteriYonetim
    {
        public KrediHesaplamaBase KrediHesaplamaBase { get; set; }
        public void Krediler()
        {
            Console.WriteLine("Müşteri Kredilendirme: ");
            KrediHesaplamaBase.Hesap();

        }
    }
}
