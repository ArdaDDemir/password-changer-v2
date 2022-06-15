# Şifre Değiştirici

<img src="http://cdn.ardademir.me/img/ads.jpg" align="right"
     alt="Arda Demir Logo" width="120" height="120">

Tek tıkla şifre değiştirmenize yarayan açık kaynak kodlu bir şifre değiştirici
* Windows 7-8-10, Windows Server 2012-2016-2019-2022 destekleniyor. (Artık Winows 11'de destekleniyor.)
* Modern arayüz
* Daha az kod daha az karışıklık.

# Örnek Görseller
**Yükleniyor Sayfası**
<p align="left">
  <img src="https://cdn.ardademir.me/img/pass_load%20(1).png" alt="Görsel 2" width="250" height="250">
</p>


**Açılış Sayfası**

<p align="left">
  <img src="https://cdn.ardademir.me/img/pass_load%20(2).png" alt="Görsel 2" width="275" height="350">
</p>

## Açılış Sayfasındaki ArkaPlan Nasıl Değiştirilir

1. background.pxz Dosyasını indirin
2. [Pixlr](https://pixlr.com/tr/e/)'i açın ve içine atın
3. Şimdi rengini değiştirebilirsiniz

## DirectoryServices hatası nasıl çözülür?

1. Çözüm gezgini kısmında başvurulara sağ tıklıyoruz ve başvuru ekleyi seçiyoruz.
2. Derlemeler kısmını seçiyoruz ve arama kısmına **DirectoryServices** Yazıyoruz.
3. **System.DirectoryServices** kısmını tikliyoruz ve tamama basıp kapatıyoruz.
4. Eğer hata devam ediyorsa aşağıdaki kodu en üste ekliyoruz.

```
using System.DirectoryServices;
```
