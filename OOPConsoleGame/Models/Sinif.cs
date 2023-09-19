using OOPConsoleGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Sinif:BaseEntity,IStat
    {
        public Sinif(string isim)
        {
            Isim = isim;
        }

        /// <summary>
        /// Bu metot ilgili sınıfa göre karakterin tüm yeteneklerin kactan baslayacağini belirler...
        /// </summary>
        /// <param name="k"></param>



        public void StatBelirle(Karakter k)
        {
            switch (Isim.ToLower())
            {
                case "savasci":
                    k.Dayaniklilik = 3;
                    k.Ceviklik = 2;
                    k.Irade = 1;
                    break;

                case "okcu":
                    k.Guc = 2;
                    k.Dayaniklilik = 2;
                    k.Ceviklik = 3;
                    k.Irade = 1;
                    break;

                case "buyucu":
                    k.Guc = 3;
                    k.Dayaniklilik = 1;
                    k.Ceviklik = 2;
                    k.Irade = 3;
                    break;

                case "paladin":
                    k.Guc = 3;
                    k.Dayaniklilik = 3;
                    k.Ceviklik = 1;
                    k.Irade = 3;
                    break;

                case "ninja":
                    k.Guc = 2;
                    k.Dayaniklilik = 2;
                    k.Ceviklik = 3;
                    k.Irade = 2;

                    break;
            }
        }

      

        public List<Karakter> Karakterler {  get; set; }    
    }
}
