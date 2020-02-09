using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //[Obsolete]
        public void PersonalEkle(string adi, string soyadi, string kullaniciAdi, int sifre)
        {
            //var client = new MongoClient();
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


            /*
            MongoClient client = new MongoClient();

            MongoServer server = client.GetServer(); //Yerel bilgisayardaki mongoDB'ye bağlanılıyor.

            MongoDatabase db = server.GetDatabase("banka"); //banka adındaki veritabanına bağlantı sağlanıyor.

            var personaller = db.GetCollection("Personal");  //Personal adındaki koleksiyona (tabloya) bağlanılıyor.

            //Ekleme işlemi yapılıyor
            personaller.Insert(new BsonDocument
            {
                {"Ad", adi},
                {"Soyad", soyadi},
                {"Kullanıcı Adı", kullaniciAdi},
                {"Şifre", sifre}
            });
            */
        }

        [WebMethod]
        //[Obsolete]
        public void PersonalSil(string kullaniciAdi)
        {
            /*
            MongoClient client = new MongoClient();

            MongoServer server = client.GetServer(); //Yerel bilgisayardaki mongoDB'ye bağlanılıyor.

            MongoDatabase db = server.GetDatabase("banka"); //banka adındaki veritabanına bağlantı sağlanıyor.

            var personaller = db.GetCollection("Personal"); //Personal adındaki koleksiyona (tabloya) bağlanılıyor.

            var sorgu = new QueryDocument { { "Kullanıcı Adı", kullaniciAdi } };

            personaller.Remove(sorgu);
            */
        }

        [WebMethod]
        public List<BsonDocument> PersonalListele()
        {
            //var client = new MongoClient();
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Personal");

            var documents = collection.Find(new BsonDocument()).ToList();

            return documents;
        }

        [WebMethod]
        public long count()
        {
            //var client = new MongoClient();
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("banka");

            var collection = database.GetCollection<BsonDocument>("Personal");

            var count = collection.CountDocuments(new BsonDocument());

            return count;
        }

        //Personal Methodları

        [WebMethod]
        //[Obsolete]
        public void MusteriEkle(string adi, string soyadi, DateTime tarih, int musteriNo, int sifre)
        {
            /*
            MongoClient client = new MongoClient();

            MongoServer server = client.GetServer(); //Yerel bilgisayardaki mongoDB'ye bağlanılıyor.

            MongoDatabase db = server.GetDatabase("banka"); //banka adındaki veritabanına bağlantı sağlanıyor.

            var musteriler = db.GetCollection("Musteri");  //Musteri adındaki koleksiyona (tabloya) bağlanılıyor.

            //Ekleme işlemi yapılıyor
            musteriler.Insert(new BsonDocument
            {
                {"Ad", adi},
                {"Soyad", soyadi},
                {"Tarih", tarih},
                {"Müşteri No", musteriNo},
                {"Şifre", sifre}
            });
            */
        }

        [WebMethod]
        //[Obsolete]
        public void HesapAc(int musteriNo, int limit)
        {
            /*
            MongoClient client = new MongoClient();

            MongoServer server = client.GetServer(); //Yerel bilgisayardaki mongoDB'ye bağlanılıyor.

            MongoDatabase db = server.GetDatabase("banka"); //banka adındaki veritabanına bağlantı sağlanıyor.

            var hesaplar = db.GetCollection("Hesap");  //Hesap adındaki koleksiyona (tabloya) bağlanılıyor.

            //Ekleme işlemi yapılıyor
            hesaplar.Insert(new BsonDocument
            {
                {"Müşteri No", musteriNo},
                {"Limit",  limit},
                {"Tarih", DateTime.Now}
            });
            */
        }

        [WebMethod]
        //[Obsolete]
        public void HesapSil(int musteriNo)
        {
            /*
            MongoClient client = new MongoClient();

            MongoServer server = client.GetServer(); //Yerel bilgisayardaki mongoDB'ye bağlanılıyor.

            MongoDatabase db = server.GetDatabase("banka"); //banka adındaki veritabanına bağlantı sağlanıyor.

            var hesaplar = db.GetCollection("Hesap"); //Personal adındaki koleksiyona (tabloya) bağlanılıyor.

            var sorgu = new QueryDocument { { "Müşteri No", musteriNo } };

            hesaplar.Remove(sorgu);
            */
        }
    }
}
