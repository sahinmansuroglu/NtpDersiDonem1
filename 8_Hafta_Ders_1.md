## Öğrenci Sınıfını kullanan WPF Uygulaması ##

**[Uygulamanın Tamamlanmış Proje Dosyası](https://github.com/sahinmansuroglu/NtpDersi/files/7417773/Uygulama.zip)**

### WPF Form Arayüzü ###

![image](https://user-images.githubusercontent.com/28144917/138871866-02546bdd-36df-4569-9fd6-5f8dee95286e.png)

### Dosya Yapisi ###
![image](https://user-images.githubusercontent.com/28144917/138872530-d94ac010-0f15-4d3b-b20c-b3f8edbd83dc.png)

### Öğrenci Sinifi ###

```csharp
  class Ogrenci
    {
        string adSoyad;
        public string AdSoyad
        {
            get
            {
                return adSoyad;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Ad Soyad Boş Geçilemez....");
                }
                else
                {
                    adSoyad = value;
                }
            }
        }
        short okulNo;
        public short OkulNo
        {
            get
            {
                return okulNo;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Okul No negatif sayı olamaz...");
                }
                else
                {
                    okulNo = value;
                }
            }
        }
        short puan1;
        public short Puan1
        {
            get
            {
                return puan1;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    puan1 = value;
                }
                else
                {
                    throw new Exception("Puan1 0 ile 100 arasında olmalı");
                }

            }
        }
        short puan2;
        public short Puan2
        {
            get
            {
                return puan2;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    puan2 = value;
                }
                else
                {
                    throw new Exception("Puan2 0 ile 100 arasında olmalı");
                }

            }
        }
        short puan3;
        public short Puan3
        {
            get
            {
                return puan3;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    puan3 = value;
                }
                else
                {
                    throw new Exception("Puan3 0 ile 100 arasında olmalı");
                }



            }
        }
        public string GoruntulemeBasligi
        {
            get
            {
                return $"{adSoyad} : {okulNo}";
            }
        }
        public double Ortalama
        {
             get{
                return (puan1 + puan2 + puan3) / 3.0;

            }
        }

        public string Durum
        {
            get
            {
                return  Ortalama<50 ?" Kaldınız..":"Geçtiniz...";
            }
        }
        public string TumBilgiler
        {
            get
            {
                return $" Ad Soyad:{adSoyad} Okul No:{okulNo} Puan1:{puan1} Puan2:{puan2} Puan3:{puan3} Ortalama:{Ortalama:#.##} Durum:{Durum}";
            }
        }

        public Ogrenci(string adSoyad, short okulNo, short puan1, short puan2, short puan3)
        {
            this.AdSoyad = adSoyad;
            this.OkulNo = okulNo;
            this.Puan1 = puan1;
            this.Puan2 = puan2; 
            this.Puan3 = puan3;
        }

    }
```

### Main Window Uygulaması ###

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ogrenci secilenOgrenci = (Ogrenci) liste.SelectedItem;
            lblBilgi.Content = secilenOgrenci.TumBilgiler;
            
        }

        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string adSoyad = txtAdSoyad.Text;
                short okulNo = Convert.ToInt16(txtOkulNo.Text);
                short puan1 = Convert.ToInt16(txtPuan1.Text);
                short puan2 = Convert.ToInt16(txtPuan2.Text);
                short puan3 = Convert.ToInt16(txtPuan3.Text);

                //Todo List
                //1. Girilen Verilerden Ogrenci Nesnesi oluşturulacak
                Ogrenci yeniOgrenci = new Ogrenci(adSoyad, okulNo, puan1, puan2, puan3);

                //2. Oluşturan nesne listbox'a eklenecek
                liste.Items.Add(yeniOgrenci);
                liste.DisplayMemberPath = "GoruntulemeBasligi";

                //3. Kutucukları Temizleyecek
                kutucuklariTemizle();
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı", "Bilgi Mesajı", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException hata)
            {
                MessageBox.Show("Okul No ve Punlara lütfen rakam giriniz", "Hata İletisi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata İletisi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
           
           
        }

        public void kutucuklariTemizle()
        {
            txtAdSoyad.Clear();
            txtOkulNo.Clear();
            txtPuan1.Clear();
            txtPuan2.Clear();
            txtPuan3.Clear();
            txtAdSoyad.Focus();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Ogrenci yeniOgrenci1 = new Ogrenci("Arda EKIN", 185, 65, 55, 22);
            Ogrenci yeniOgrenci2 = new Ogrenci("Ali Veli", 854, 45, 55, 22);
            liste.Items.Add(yeniOgrenci1);
            liste.Items.Add(yeniOgrenci2);
            liste.DisplayMemberPath = "GoruntulemeBasligi";
        }
    }
}

```
