# Unity-MVMM-Mimarisi

MVVM (Model-View-ViewModel) mimarisini kullanarak Unity'de basit bir öğe sistemi oluşturmayı gösterir.

Model (Model): Model, uygulamanızın temel veri yapısını ve iş mantığını temsil eder. Model, verileri saklar, işler ve günceller. Örneğin, bir oyun uygulamasında oyuncu karakterlerinin özellikleri, envanter öğeleri ve oyun dünyasının verileri Model tarafından temsil edilir.

View (Görünüm): View, kullanıcı arayüzünü temsil eder. Bu, kullanıcıların uygulamayla etkileşimde bulunduğu alanı içerir. Unity'de bu, sahneler, UI elemanları ve kullanıcı arayüzü tasarımını içerir.

ViewModel (Görünüm Modeli): ViewModel, Model ile View arasındaki arabirimdir. ViewModel, Model'den verileri alır, bunları View için uygun bir şekilde düzenler ve kullanıcı etkileşimlerini işler. ViewModel, genellikle veri bağlama (data binding) ve olayların yönetimi için kullanılır.

MVVM yapısının çalışma mantığı şu şekildedir:

Model, uygulamanın temel verilerini ve iş mantığını içerir. Veriler bu katmanda saklanır ve güncellenir.

View, kullanıcı arayüzünün tasarlandığı yerdir. View, kullanıcı etkileşimlerini algılar ve bu etkileşimleri ViewModel'e iletir.

ViewModel, Model verilerini alır ve bu verileri View tarafından görüntülenmeye uygun bir şekilde hazırlar. ViewModel, View ile Model arasındaki iletişimi kolaylaştırır. Ayrıca, kullanıcı etkileşimlerini dinler, bu etkileşimlere yanıt verir ve Model ile View arasındaki senkronizasyonu sağlar.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Neden MVMM?

1. Sorumluluk Ayrımı
MVVM, Model, View ve ViewModel bileşenlerinin her birine özel bir sorumluluk tanır. Bu, projenizin daha organize ve sürdürülebilir olmasına yardımcı olur. Örneğin, Model verilerinizi düzenlerken, ViewModel, verileri görünüme (View) nasıl sunacağınızı ve kullanıcı etkileşimlerini nasıl işleyeceğinizi yönetir. View ise yalnızca kullanıcı arayüzünün tasarımı ve görüntülenmesiyle ilgilenir.

Örnek: Bir oyun içinde oyuncu verileri (adı, puanı, karakter özellikleri) Model tarafından yönetilirken, ViewModel bu verileri UI elemanlarına bağlar ve View, bu verileri kullanıcıya sunar.

2. Modülerlik ve Bakım Kolaylığı
MVVM, projenizin modülerliğini artırır. Her bileşen kendi görevini yerine getirir, bu da her bileşenin bağımsız olarak test edilmesini ve değiştirilmesini kolaylaştırır. Bu, projenizin daha az hata ve daha hızlı gelişme süreçlerine olanak tanır.

Örnek: Oyununuzda yeni bir özellik eklemek istediğinizde, Model'i güncellemek veya ViewModel'de yeni bir işlev eklemek, mevcut kodu etkilemeden mümkün olabilir.

3. Test Edilebilirlik
MVVM, her bileşenin (Model, View, ViewModel) bağımsız olarak test edilebilmesini sağlar. Bu, yazılım geliştirme sırasında hataları daha erken tespit etmenizi ve düzeltmenizi sağlar.

Örnek: ViewModel'deki bir özellik veya işlevi test etmek, oyunun başlatılmasına veya sahnelerin geçişine gerek kalmadan yapılabilir.

4. İşbirliği Kolaylığı
MVVM, geliştirici ve tasarımcıların daha iyi bir işbirliği içinde çalışmalarına yardımcı olur. Tasarımcılar, View'ı oluşturabilir ve stil verebilirken, geliştiriciler ViewModel ve Model üzerinde çalışabilir. Bu, iş süreçlerini hızlandırır.

Örnek: Bir oyun tasarımcısı, oyun karakterlerinin görünümünü ve UI elemanlarını tasarlar, bu tasarımlar daha sonra Unity'de kullanılır ve ViewModel ile entegre edilir.

5. Verilerin Bağımsızlığı
MVVM, Model verilerini View'den tamamen bağımsızlaştırır. Bu, aynı Model verilerini farklı View'larda (örneğin, masaüstü ve mobil sürümlerinde) kullanmanızı sağlar.

Örnek: Bir oyununuz hem PC hem de mobil sürümleri için MVVM kullanarak aynı Model verilerini farklı kullanıcı arayüzlerinde sunabilir.

Unity'de MVVM yapısının kullanılması, karmaşık oyunlar ve uygulamalar için tasarım ve geliştirme süreçlerini daha etkili ve yönetilebilir hale getirebilir. Projelerin büyüdükçe ve gereksinimler karmaşıklaştıkça, MVVM yapısı kullanmak bu avantajları daha da önemli kılar.
