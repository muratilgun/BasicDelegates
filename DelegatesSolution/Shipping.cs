using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSolution
{
    // �cretleri hesaplamak i�in kullan�lan delege t�r�
    public delegate void ShippingFeesDelegate(decimal thePrice, ref decimal fee);

    // Bu hedef b�lgelerin her biri i�in temel
    // olarak kullan�lan bir base class
    abstract class ShippingDestination
    {
        public bool m_isHighRisk;
        public virtual void calcFees(decimal price, ref decimal fee) { }

        // Bu static method hedefin ad� verilen bir ShippingDestination nesnesini
        // veya yoksa null de�erini d�nd�r�r.
        public static ShippingDestination getDestinationInfo(string dest)
        {
            if (dest.Equals("zone1"))
            {
                return new Dest_Zone1();
            }
            if (dest.Equals("zone2"))
            {
                return new Dest_Zone2();
            }
            if (dest.Equals("zone3"))
            {
                return new Dest_Zone3();
            }
            if (dest.Equals("zone4"))
            {
                return new Dest_Zone4();
            }
            if (dest.Equals("zone5"))
            {
                return new Dest_Zone5();
            }
            return null;
        }
    }

    // Sevkiyat hedeflerinin her biri i�in implementation s�n�flar� tan�mlan�r.
    // �htiyaca g�re istedildi�i kadar eklenebilinir.

    class Dest_Zone1 : ShippingDestination
    {
        public Dest_Zone1()
        {
            this.m_isHighRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.25m;
        }
    }
    class Dest_Zone2 : ShippingDestination
    {
        public Dest_Zone2()
        {
            this.m_isHighRisk = true;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.12m;
        }
    }
    class Dest_Zone3 : ShippingDestination
    {
        public Dest_Zone3()
        {
            this.m_isHighRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.08m;
        }
    }
    class Dest_Zone4 : ShippingDestination
    {
        public Dest_Zone4()
        {
            this.m_isHighRisk = true;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.04m;
        }
    }
    class Dest_Zone5 : ShippingDestination
    {
        public Dest_Zone5()
        {
            this.m_isHighRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.15m;
        }
    }
}