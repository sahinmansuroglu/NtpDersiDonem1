## Encapsulation  Kapsülleme ## 
```csharp
class Dikdortgen{
        private int kisaKenar;
        public int KisaKenar
        {
            get { return kisaKenar; }
            set
            {
                if (value < 0)
                { kisaKenar = 0; }
                else
                { kisaKenar = value; }
            }
        }
}
```
