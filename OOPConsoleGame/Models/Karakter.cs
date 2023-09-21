using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Karakter:KarakterYaratikSpec
    {
        //Todo:Abstraction Prensibi !!!
        //Todo2: Tecrübe puanına göre level ayarlaması yapılacak (Bunun için ideal olan bir kontrol metodu yazılması)

        //Todo3:Silah ve esya sistemi olusturulacak

        
        public Karakter(Sinif sinif,Irk irk)
        {
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 50;
            Sinifi=sinif;
            Irk=irk;

            sinif.StatBelirle(this);
           irk.StatBelirle(this);

        }
      

        int _maksimumCan;
        
        public override int MaksimumCan {

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
       
    
        int _maksimumEnerji;
        public override int MaksimumEnerji {
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



        public Sinif Sinifi { get; set; }
        public Irk Irk { get; set; }
        public int Seviye { get; set; }
        
        
        
        //Stats
        public int Guc { get; set; }
        public int Ceviklik { get; set; }
        public int Irade { get; set; }
        public int Dayaniklilik { get; set; }
        public int Para { get; set; }

        //Equipment


        public override int YakinSaldiri()
        {
            int saldiri = Sinifi.Isim == "savasci" || Sinifi.Isim == "sovalye" ? rnd.Next(1,21): rnd.Next(1,10);
            return base.YakinSaldiri()+Guc+Seviye;
        }

        public override void OzelSaldiri()
        {
            throw new NotImplementedException();
        }
    }
}
