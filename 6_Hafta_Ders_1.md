## Erişim Belirleyiciler (Access Modifiers) ##
> Erişim belirleyiciler sınıflara ve sınıf içerisindeki üyelere (field, methot) hangi durumlarda erişim sağlanabileceğini belirlemek için kullanılır.

### Erişim Belirleyici Türleri ###

| Erişim Belirleyici    | Tanım           | 
| ------------- |:---------------:| 
| Public    		| Bu erişim belirleyicide herhangi bir kısıtlama yoktur. Tüm sınıflar ve projeler tarafından erişilebilir. | 
| Private    		| Bu erişim belirleyicisi ile tanımlanmış üyelere sadece tanımlandığı class içerisinden erişilebilir. | 
| Protected    		| Bu erişim belirleyicisi ile tanımlanmış üyelere tanımlandığı class içerisinden veya bu class'ı miras alan class'lar tarafından erişilebilir.| 
| Internal    		| Sadece  tanımlandığı proje içerisinden erişilebilir. Farklı bir projeden erişilemez   | 
| Internat protected		|  Tanımlandığı proje içerisinden erişilebilir. Farklı bir projeden ise miras alınarak kullanılabilir. | 

**Not-1:**  Internal, bir Class'ın  varsayılan erişim belirleyicisidir. Class'ın başına herhangi bir şey yazılmadığında internal kabul edilir.

**Not-2:**  Bir class üyesinin varsayılan erişim belirleyicisi private'dir.Class'ın başına herhangi bir şey yazılmadığında private kabul edilir.
