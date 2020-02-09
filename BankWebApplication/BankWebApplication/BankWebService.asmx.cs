using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace BankWebApplication
{
    /// <summary>
    /// BankWebService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class BankWebService : System.Web.Services.WebService
    {
        //Yönetici Methodları

        [WebMethod]
        public void PersonalEkle(string adi, string soyadi, string kullaniciAdi, int sifre)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Personal");

            BsonDocument document = new BsonDocument
            {
                {"Ad", adi},
                {"Soyad", soyadi},
                {"Kullanıcı Adı", kullaniciAdi},
                {"Şifre", sifre}
            };

            collection.InsertOne(document);
        }

        [WebMethod]
        public void PersonalSil(string kullaniciAdi)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Personal");

            var filter = Builders<BsonDocument>.Filter.Eq("Kullanıcı Adı", kullaniciAdi);

            collection.DeleteOne(filter);
        }

        [WebMethod]
        public List<BsonDocument> PersonalListele()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Personal");

            var documents = collection.Find(new BsonDocument()).ToList();

            return documents;
        }

        //Personal Methodları

        [WebMethod]
        public void MusteriEkle(string adi, string soyadi, long tc, DateTime tarih, int musteriNo, int sifre)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Musteri");

            BsonDocument document = new BsonDocument
            {
                {"Ad", adi},
                {"Soyad", soyadi},
                {"TC No",  tc},
                {"Müşteri No", musteriNo},
                {"Şifre", sifre},
                {"Tarih", tarih}
            };

            collection.InsertOne(document);
        }

        [WebMethod]
        public void HesapAc(int musteriNo, int limit)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Hesap");

            //Random Müşteri No Oluşturma
            Random random = new Random();
            int rnd = random.Next(1000000,9999999);
            string HesapNo = rnd.ToString();


            BsonDocument document = new BsonDocument
            {
                {"Müşteri No", musteriNo},
                {"Hesap No", HesapNo},
                {"Limit",  limit},
                {"Tarih", DateTime.Now}
            };

            collection.InsertOne(document);
        }

        [WebMethod]
        public void HesapSil(string hesapNo)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Hesap");

            var filter = Builders<BsonDocument>.Filter.Eq("Hesap No", hesapNo);

            collection.DeleteOne(filter);
        }

        [WebMethod]
        public List<BsonDocument> MusteriListele()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Musteri");

            var documents = collection.Find(new BsonDocument()).ToList();

            return documents;
        }

        //Müşteri Methodları

        [WebMethod]
        public List<BsonDocument> HesapListele(string hesapNo)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Hesap");

            var filter = Builders<BsonDocument>.Filter.Eq("Hesap No", hesapNo);

            var result = collection.Find(filter).ToList();

            return result;
        }

        [WebMethod]
        public void Guncelle(string hesapNo, int lim)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Hesap");

            var filter = Builders<BsonDocument>.Filter.Eq("Hesap No", hesapNo);
            var update = Builders<BsonDocument>.Update.Set("Limit", lim);

            collection.FindOneAndUpdate(filter,update);
        }
    }
}
