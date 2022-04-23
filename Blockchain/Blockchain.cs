using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracSatis.Blockchain
{
    
    public class Blockchain
    {
        public Block blc;
        List<Block> liste = new List<Block>();

        public void blockSifreleme(int BlockID, string MusteriName, string UrunMarka, string UrunModel, int UrunFiyat, string PreviousHash)
        {
            Block blok = new Block(BlockID, MusteriName,  UrunMarka,  UrunModel, UrunFiyat,  PreviousHash);
            blok.Hash = blok.Sifreleme();
            this.blc = blok; 
        }

        public void baslangıcBloguOlustur()
        {
            Block blok = new Block(1, "", "","", 0, "");
            blok.Hash = blok.Sifreleme();
            this.blc = blok;
        }
    }
}