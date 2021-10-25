## Öğrenci Sınıfını kullanan WPF Uygulaması ##

**[Uygulamanın Tamamlanmış Proje Dosyası](https://github.com/sahinmansuroglu/NtpDersi/files/7410022/WpfApp1.zip)**

### WPF Form Arayüzü ###

![image](https://user-images.githubusercontent.com/28144917/138693911-a06ed2d5-8d67-41cb-8f38-435cd182f27c.png)

### Dosya Yapisi ###
![image](https://user-images.githubusercontent.com/28144917/138696521-05232a75-5f39-45d8-8b90-6229f30bca46.png)

### Öğrenci Sinifi ###

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ogrenci
    {
        private string adSoyad;
        private short okulNo;
        private short puan1;
        private short puan2;
        private short puan3;

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
                    adSoyad = "Ad Soyad Girilmedi";
                }
                else
                {
                    adSoyad = value;
                }

            }
        }

        public short OkulNo
        {
            get
            {
                return okulNo;
            }
            set
            {
                okulNo = value;
            }
        }

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
                    puan1 = 0;
                }

            }
        }
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
                    puan2 = 0;
                }

            }
        }
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
                    puan3 = 0;
                }

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

        public double ortalamaHesapla()
        {
            return (puan1 + Puan2 + puan3) / 3.0;
        }
        public string kaldiGectiHesapla()
        {
            if (ortalamaHesapla() < 50)
            {
                return "Kaldı..";
            }
            else
            {
                return "Geçti";
            }
        }
        public void bilgileriEkranaYaz()
        {
            Console.WriteLine("---------Öğrenci Bilgileri----------");
            Console.WriteLine($" Ad Soyad:{adSoyad}");
            Console.WriteLine($" Okul No:{okulNo}");
            Console.WriteLine($" Puan1: {puan1}");
            Console.WriteLine($" Puan2: {puan2}");
            Console.WriteLine($" Puan3: {puan3}");
            Console.WriteLine($" Ortalama:{ortalamaHesapla()}");
            Console.WriteLine($" Durumu:{kaldiGectiHesapla()}");

        }

        public string TumBilgiler
        {
            get
            {
                string metin = $" Ad Soyad: {adSoyad} Okul No: {OkulNo} 1. Puan:{Puan1}  2. Puan:{Puan2} 3. Puan:{Puan3} Ortalama:{ortalamaHesapla()} Durum:{kaldiGectiHesapla()}";
                return metin;
            }
        }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            short puan1 = Convert.ToInt16(txtPuan1.Text);
            short puan2 = Convert.ToInt16(txtPuan2.Text);
            short puan3 = Convert.ToInt16(txtPuan3.Text);
            short okulNo = Convert.ToInt16(txtOkulNo.Text);
            Ogrenci ogrenci = new Ogrenci(adSoyad, okulNo, puan1, puan2, puan3);
            liste.Items.Add(ogrenci);
            liste.DisplayMemberPath = "AdSoyad";
            textKutularinitemizle();
        }

        public void textKutularinitemizle()
        {
            txtPuan1.Clear();
            txtPuan2.Clear();
            txtPuan3.Clear();
            txtAdSoyad.Clear();
            txtOkulNo.Clear();
        }
        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ogrenci secilenOgrenci = (Ogrenci)liste.SelectedItem;
            lblBilgi.Content = secilenOgrenci.TumBilgiler;
           
        }
    }
}


```
