## Sınav  Sorusu ##
> **Aşağıdaki istenilenler tek bir soru içindir. Verilenleri sırayla takip ederek uygulamayı tamamlayınız.**
1. Aşağıda Verilenlere Göre **```Ogrenci```** adında **```abstract```** bir sınıf tanımlayınız _**```(25 Puan)```**_


    - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili olmak üzere 5 tane **```private field```** bulunacak. 
    - herbir field için birer tane **```property ```** oluşturarak aşağıdaki durumlara göre **```encapsulation```** yapılacak. 
      - Ad ve Soyad boş girilirse **``` throw ```** ile hata fırlatılmalı.
      - OgrenciNo 3 basamaklı bir rakamdan oluşmuyorsa **``` throw ```** ile hata fırlatılmalı.
      - DogumTarihi ve başlamaYili 2023  ile 1990 arasında değilse **``` throw  ```** ile hata fırlatılmalı.
    - Yas adında **```readonly property```**  tanımlanarak dogumTarihinden yası hesaplattırılacak. (Sadece **```get```** metodu bulunacak)
    - Tanımlanan 5 **``` field ```** için değer ataması kurucu metot içerisinde yapılacak.
    - **```string```** tipinde enOnemliOlayi adından bir **```abstract```** metod tanımlayınız. 
    - Öğrencinin tüm bilgilerini ekrana yazdıran bilgileriEkranaYaz() adında **```virtual```** metot tanımlayınız.


2. Aşağıda verilenlere göre IOgrenciIslem() adında bir **``` interface ```** tanımlayınız. _**```(5 Puan)```**_


    - string tipinde matematikDersIcerigi() adında bir metot gövdesi bulunacak
    - int tipinde mezunOlacagiYasiHesapla() adında bir metot gövdesi tanımlayınız.


3. Aşağıda verilenlere göre IlkOkulOgrencisi ve OrtaOkulOgrencisi  adlarında classları Ogrenci class'ından ve IOgrenciIslem interface'inden türetiniz. 
   
   - IlkOkulOgrencisi class'ı _**```(15 Puan)```**_

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "Yaz Kampları" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "İlk Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
            - İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad Soyad  bilgileri birleştirilerek döndürülecek
        - ortaokuldanMezunOlmaYiliniEkranaYaz() metodu başlamaYili'na 8 ekleyerek  sonucu ekrana yazacak
        
   - OrtaOkulOgrencisi class'ı  _**```(15 Puan)```**_

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "LGS Sınavı" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "Temel Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
            -İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad, Soyad ve ogrenciNo  bilgileri birleştirilerek döndürülecek
        - gidebileceğiOkullariEkranaYaz() metodu ekrana "Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi" metinin yazacak
        
4. Aşağıdaki gibi  2 Adet İlkokul öğrencisi ve 2 adet ortaokul Öğrencisi nesnesi oluşturunuz.  _**```(15 Puan)```**_


        - OrtaOkulOgrencisi("Zehra", "ACI", 354, 2009, 2019);
        - IlkOkulOgrencisi("Esra", "ZEYBEK", 985, 2014, 2000);
        - OrtaOkulOgrencisi("Ali", "AKIN", 654, 2010, 2020);
        - IlkOkulOgrencisi("Ahmet", "EKER", 387, 2015, 2000);


5. Her bir öğrencinin  bilgileriEkranaYaz() metodunu çağırarak bilgilerini ekrana yazdırınız. _**```(20 Puan)```**_

    - Ayrıca;
    - Eğer Öğrenci İlkokul öğrencisi ise ortaokuldanMezunOlmaYiliniEkranaYaz()  metodunu da çağırın.
    - Eğer Öğrenci Ortaokul öğrencisi ise gidebileceğiOkullariEkranaYaz()  metodunu da çağırın.
    
