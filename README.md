# Unity-MVMM-Mimarisi

MVVM (Model-View-ViewModel) mimarisini kullanarak Unity'de basit bir öğe sistemi oluşturmayı gösterir.

**Model 
-**(Item.cs): Öğelerin temel özelliklerini (adı ve gücü) içeren bir sınıfı temsil eder.
- **ViewModel (ItemViewModel.cs):** Öğelerin yönetildiği yerdir. Yeni öğeler eklemek ve mevcut öğeleri listelemek için kullanılır.
- **View (ItemView.cs):** Kullanıcı arayüzünü ve etkileşim sağlar. Kullanıcılar yeni öğeler ekleyebilir ve mevcut öğeleri görüntüleyebilirler.

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
