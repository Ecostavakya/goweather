# goweather

Weatherapp, WeatherService sınıfını kullanarak bir hava durumu API'sinden hava durumu bilgilerini getiren basit bir C# konsol uygulamasıdır. Hava durumu verileri, sıcaklık, rüzgar ve tahmin gibi bilgileri içeren Weather sınıfı tarafından temsil edilmektedir.
Proje Yapısı
WeatherService
WeatherService sınıfı, belirtilen API'den hava durumu verilerini getirmekten sorumludur. HTTP istekleri yapmak için bir HttpClient örneği ve JSON yanıtlarını çözmek için Newtonsoft.Json kullanır.

Metotlar
GetWeatherAsync(string apiUrl): Task<Weather>
Belirtilen API URL'sinden hava durumu verilerini asenkron olarak getirir.
Sıcaklık, rüzgar, açıklama ve tahmin içeren bir Weather nesnesi döndürür.
Weather
Weather sınıfı, hava durumu bilgileri için ana yapıyı temsil eder. Sıcaklık, rüzgar, açıklama ve Forecast nesnelerinin bir dizisini içerir.

Forecast
Forecast sınıfı, belirli bir gün için tahmini temsil eder. Gün, sıcaklık ve rüzgar için özelliklere sahiptir.
