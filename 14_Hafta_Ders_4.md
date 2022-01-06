## SortedList Koleksiyonu ##
> SortedList koleksiyonu  Hashtable ve Dictionary koleksiyonuna benzer bir yapıdır. Farkı ise  SortedList koleksiyonu içindeki verileri anahtarın içeriğine göre sıralamasıdır. Karışık olarak verilen anahtar değerlerini bile 
kendi içinde artan şekilde bir sıralama yaparak koleksiyon içine eklemektedir.


 SortedList<int, string> iller = new SortedList<int, string>();
            iller.Add(33, "Mersin");
            iller.Add(35, "İzmit");
            iller.Add(32, "Isparta");
            iller.Add(27, "Gaziantep");
            iller.Add(55, "Samsun");
            foreach (int key in iller.Keys)
            {
                Console.WriteLine($"{key,5} {iller[key],20}");
            }
            Console.ReadKey();


