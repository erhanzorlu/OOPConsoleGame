using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Karakter:BaseEntity
    {
        public Karakter()
        {
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 20;
            
        }
      

        int _maksimumCan;
        
        public int MaksimumCan {

            get
            {
                if(Seviye==1 && _maksimumCan != 100)
                {
                    throw new Exception("Karakter 1.seviyede plmasına rağmen can puanın bir sıkıntısı var");
                }
                return _maksimumCan;
            }
            set
            {
                if (Seviye==1 && value==100) 
                {
                _maksimumCan = value;
                }
                else if(Seviye>1 &&value>_maksimumCan)
                {
                    _maksimumCan=value;
                }
                else
                {
                    throw new Exception("Karakterin can puanıyla ilgili bir sıkıntı oluştu");
                }
            }       
        }
        public int MevcutCan { get; set; }
        public int Seviye { get; set; }
        int _maksimumEnerji;
        public int MaksimumEnerji {
            get 
            { 
            if(Seviye==1 && _maksimumEnerji != 100)
                {
                    throw new Exception("Karakteriniz enerji durumda bir tutarsızlık var");
                }
                return _maksimumEnerji;
            }
            set 
            {
                if (Seviye==1 && value==50)
                {
                    _maksimumEnerji = value;
                }
                else if (Seviye>1 && value>_maksimumEnerji)
                {
                    _maksimumEnerji = value;
                }
                else
                {
                    throw new Exception("Enerjide sorun var");
                }
            }
        }
        public int MevcutEnerji { get; set; }


        //Stats
        public int Guc { get; set; }
        public int Ceviklik { get; set; }
        public int Irade { get; set; }

        public Sinif Sinifi { get; set; }

    }
}
