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
        //Todo2: Tecrübe puanına före level ayarlaması yapılacak (Bunun için ideal olan bir kontrol metodu yazılması)

        //Todo3:Silah ve esya sistemi olusturulacak

        //Todo3:
        public Karakter(Sinif sinif,Irk irk)
        {
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 50;
            Sinifi=sinif;
            Irk=irk;

            switch (Sinifi.Isim.ToLower())
            {
                case "savasci":
                    Guc = 3;
                    Dayaniklilik = 3;
                    Ceviklik = 2;
                    Irade = 1;
                    break;

                case "okcu":
                    Guc = 2;
                    Dayaniklilik = 2;
                    Ceviklik = 3;
                    Irade = 1;
                    break;

                case "buyucu":
                    Guc = 3;
                    Dayaniklilik = 1;
                    Ceviklik = 2;
                    Irade = 3;
                    break;

                case "paladin":
                    Guc = 3;
                    Dayaniklilik = 3;
                    Ceviklik = 1;
                    Irade = 3;
                    break;

                case "ninja":
                    Guc = 2;
                    Dayaniklilik = 2;
                    Ceviklik = 3;
                    Irade = 2;

                    break;

            }
            switch (Irk.Isim.ToLower())
            {
                case "insan":
                    Irade += 1;
                    break;

                case "ork":
                    Dayaniklilik += 2;
                    break;

                case "elf":
                    Ceviklik += 1;
                    break;

                case "cuce":
                    Guc += 2;
                    break;

                case "undead":
                    Guc += 3;
                    Irade += 1;
                    break;
            }

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

        public override int YakinSaldiri()
        {
            return base.YakinSaldiri()+Guc+Seviye;
        }

    }
}
