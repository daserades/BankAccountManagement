# BankAccountManagement

C# - Banka Hesap Yönetimi

<h2>Yönetici Methodları</h2>

<table>
  <tr>
    <th style="text-align:center">Adı</th>
    <th style="text-align:center">Parametreleri</th>
    <th style="text-align:center">Tanımı</th>
  </tr>
  <tr>
    <td>PersonalEkle()</td>
    <td>string adi, string soyadi, string kullaniciAdi, int sifre</td>
    <td>mongoDB veritabanına personal ekler.</td>
  </tr>
  <tr>
    <td>personalSil()</td>
    <td>string kullaniciAdi</td>
    <td>mongoDB veritabanından personal siler.</td>
  </tr>
  <tr>
    <td>PersonalListele()</td>
    <td>empty</td>
    <td>mongoDB veritabanındaki personalleri listeler.</td>
  </tr>
</table>

<h2>Personal Methodları</h2>

<table>
  <tr>
    <th style="text-align:center">Adı</th>
    <th style="text-align:center">Parametreleri</th>
    <th style="text-align:center">Tanımı</th>
  </tr>
  <tr>
    <td>MusteriEkle()</td>
    <td>string adi, string soyadi, long tc, int sifre, DateTime tarih</td>
    <td>mongoDB veritabanına müşteri ekler.</td>
  </tr>
  <tr>
    <td>Hesap Aç()</td>
    <td>int musteriNo, int limit</td>
    <td>mongoDB veritabanına hesap ekler.</td>
  </tr>
  <tr>
    <td>HesapSil()</td>
    <td>string hesapNo</td>
    <td>mongoDB veritabanından hesap siler.</td>
  </tr>
  <tr>
    <td>MusteriListele()</td>
    <td>empty</td>
    <td>mongoDB veritabanındaki müşterileri listeler.</td>
  </tr>
</table>

<h2>Müşteri Methodları</h2>

<table>
  <tr>
    <th style="text-align:center">Adı</th>
    <th style="text-align:center">Parametreleri</th>
    <th style="text-align:center">Tanımı</th>
  </tr>
  <tr>
    <td>MusteriKontrol()</td>
    <td>long tc</td>
    <td>Müşteri giriş işlemi için kontrol sağlar.</td>
  </tr>
  <tr>
    <td>HesapListele()</td>
    <td>string hesapNo</td>
    <td>Hesaba ait verileri listeler.</td>
  </tr>
  <tr>
    <td>Guncelle()</td>
    <td>string hesapNo, int lim</td>
    <td>Hesaba ait limit değerini günceller.</td>
  </tr>
</table>

