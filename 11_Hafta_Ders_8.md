## Quiz Sorusu ##
**``` ```**
1. Aşağıda Verilenlere Göre **```Ogrenci```** adında **```abstract```** bir sınıf tanımlayınız


    - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili olmak üzere 5 tane **```private field```** bulunacak. 
    - herbir field için birer tane **```property ```** oluşturarak aşağıdaki durumlara göre **```encapsulation```** yapılacak. 
      - Ad ve Soyad boş girilirse **``` throw ```** ile hata fırlatılmalı.
      - OgrenciNo 5 basamaklı bir rakamdan oluşmuyorsa **``` throw ```** ile hata fırlatılmalı.
      - DogumTarihi ve başlamaYili içinde bulunduğumuz yıl ile 1990 arasında değilse **``` throw  ```** ile hata fırlatılmalı.
    - Yas adında **```readonly property```**  tanımlanarak dogumTarihinden yası hesaplattırılacak. (Sadece **```get```** metodu bulunacak)
    - Tanımlanan 5 **``` field ```** için değer ataması kurucu metot içerisinde yapılacak.
    - **```string```** tipinde enOnemliOlayi adından bir **```abstract```** metod tanımlayınız. 
    - Öğrencinin tüm bilgilerini ekrana yazdıran bilgileriEkranaYaz() adında **```virtual```** metot tanımlayınız.


2. Aşağıda verilenlere göre IOgrenciIslem() adında bir **``` interface ```** tanımlayınız.


    - string tipinde matematikDersIcerigi() adında bir metot gövdesi bulunacak
    - int tipinde mezunOlacagiYasiHesapla() adında bir metot gövdesi tanımlayınız.


3. Aşağıda verilenlere göre IlkOkulOgrencisi, OrtaOkulOgrencisi, LiseOgrencisi adında classları Ogrenci class'ından ve IOgrenciIslem interface'inden türetiniz. 
   
   - IlkOkulOgrencisi class'i


        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
                 (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "Yaz Kampları" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "İlk Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
                İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad Soyad  bilgileri birleştirilerek döndürülecek
   
   - IlkOkulOgrencisi class'i

        - Ek olarak başlamaYili adında bir field ve bu field ile ilişkili bir property bulunacak
        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "Yaz Kampları" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "İlk Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
            -İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad Soyad  bilgileri birleştirilerek döndürülecek
