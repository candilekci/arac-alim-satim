using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace AracSatis.Blockchain
{
    public class Block
    {
        public int BlockID { get; set; }
        public string MusteriName { get; set; }
        public string UrunMarka { get; set; }
        public string UrunModel { get; set; }
        public int UrunFiyat { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public Block()
        {

        }

        public Block(int BlockID , string MusteriName, string UrunMarka, string UrunModel, int UrunFiyat, string PreviousHash)
        {
            this.BlockID = BlockID;
            this.MusteriName = MusteriName;
            this.UrunMarka = UrunMarka;
            this.UrunModel = UrunModel;
            this.UrunFiyat = UrunFiyat;
            this.PreviousHash = PreviousHash;           
        }
        
        

        public string Sifreleme()
        {
            string sifrelenecektext = this.MusteriName + this.UrunMarka + this.UrunModel +
                                      this.UrunFiyat.ToString() + this.PreviousHash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(sifrelenecektext);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                this.Hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                
            }
            return this.Hash;
        }
    }
}