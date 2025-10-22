<h1>🏦 Finansal CRM Projesi Hakkında</h1>

<p>
Bu proje, <strong>C#</strong> ve <strong>Entity Framework</strong> kullanılarak geliştirilmiş bir 
<strong>finansal yönetim ve CRM uygulamasıdır</strong>. 
Uygulama, firmaların banka hareketleri, giderleri, fatura işlemleri ve kategori bazlı finansal analizlerini kolayca yönetebilmesini sağlar. 
Entity Framework ile veritabanı işlemleri <em>LINQ</em> sorguları üzerinden gerçekleştirilir, bu da veri takibini dinamik hale getirir. 
Proje Windows Forms arayüzüyle modern bir tasarım sunarken, kullanıcıya pratik ve görsel bir deneyim kazandırır. 
Uygulamanın her formu, finansal sürecin farklı bir aşamasını temsil edecek şekilde tasarlanmıştır.
</p>

<hr>

<h2>🔐 FrmLogin (Giriş Ekranı)</h2>
<p>
FrmLogin, kullanıcı doğrulama işlemlerinin gerçekleştirildiği giriş ekranıdır. 
Kullanıcı adı ve şifre kontrolü yapılarak yetkili kişilerin sisteme erişimi sağlanır. 
Basit ama güvenli bir kimlik doğrulama sistemiyle yetkisiz erişimler engellenir. 
Başarılı girişten sonra sistem doğrudan Dashboard’a yönlendirir. 
Kullanıcı deneyimini sade ve hızlı tutacak şekilde tasarlanmıştır.
</p>

<img width="801" height="450" alt="{B2904B7A-E206-4064-9901-551AFF149C7F}" src="https://github.com/user-attachments/assets/cfd9ed1e-8f27-4f45-a10d-70a816bc5f1e" />


<h2>📊 FrmDashboard (Kontrol Paneli)</h2>
<p>
Dashboard formu, kullanıcıya sistemin genel finansal durumunu hızlı bir bakışla sunar. 
Gelir, gider, banka bakiyeleri ve toplam fatura sayısı gibi temel göstergeler anlık olarak bu panelde gösterilir. 
Renkli kutucuklar ve dinamik sayısal göstergeler, kullanıcıya kolay anlaşılır bir veri sunumu sağlar. 
LINQ sorguları ile veriler doğrudan veritabanından çekilerek anlık olarak güncellenir. 
Bu form, finansal karar alma süreçlerini hızlandırmak için tasarlanmıştır.
</p>

<h2>🏛️ FrmBanks (Bankalar)</h2>
<p>
Bu form, sistemde tanımlı olan tüm banka hesaplarını listeler ve yönetim işlemlerine olanak tanır. 
Her banka için bakiye, hesap adı, şube bilgisi gibi detaylar görüntülenebilir. 
Kullanıcı yeni banka ekleme, düzenleme veya silme işlemlerini kolayca gerçekleştirebilir. 
Ayrıca, form üzerinden bankalar arası işlem geçişleri de sağlanır. 
Finansal akışın temelini oluşturan bu modül, tüm parasal hareketlerin başlangıç noktasını temsil eder.
</p>

<h2>💸 FrmBanksTransactions (Banka İşlemleri)</h2>
<p>
FrmBanksTransactions, seçilen banka hesaplarının tüm gelir ve gider hareketlerini gösterir. 
Kullanıcı, her işlem için açıklama, tutar, tarih ve işlem tipi bilgilerini detaylı olarak görüntüleyebilir. 
Bu form, banka bakiyelerini güncel tutmak ve geçmiş işlemleri raporlamak için tasarlanmıştır. 
Arayüz, işlem filtreleme ve sıralama özellikleriyle finansal analizi kolaylaştırır. 
Şeffaf bir işlem geçmişi sunarak, kullanıcıya hesap kontrolü sağlar.
</p>

<h2>🧾 FrmBilling (Faturalar)</h2>
<p>
Faturalama formu, müşteri veya tedarikçilere ait tüm faturaları yönetmek için kullanılır. 
Her fatura için tarih, tutar, kategori ve açıklama bilgileri saklanır. 
Kullanıcı yeni fatura ekleyebilir, mevcut faturaları güncelleyebilir veya silebilir. 
Bu form, gelir–gider dengesi üzerinde doğrudan etkili olan verileri düzenli tutmayı hedefler. 
Finansal kayıtların düzenli takibi için uygulamanın önemli parçalarından biridir.
</p>

<h2>🗂️ FrmCategories (Kategoriler)</h2>
<p>
FrmCategories formu, gider veya gelir türlerinin sınıflandırılmasını sağlar. 
Kullanıcı, kategori ekleme, silme ve güncelleme işlemlerini bu ekrandan yapabilir. 
Böylece, raporlama ve analiz süreçlerinde hangi harcama kalemlerinin daha fazla yer tuttuğu kolayca belirlenebilir. 
Kategoriler, tüm sistemde dinamik olarak diğer formlarda kullanılır. 
Basit ama finansal düzenin temelini oluşturan bir modüldür.
</p>

<h2>💰 FrmExpenses (Giderler)</h2>
<p>
Bu form, şirketin yaptığı tüm harcamaları detaylı şekilde listeler. 
Her gider kaydı; kategori, tarih, tutar ve açıklama bilgilerini içerir. 
Kullanıcı gider ekleme, düzenleme ve silme işlemlerini doğrudan bu form üzerinden yapabilir. 
Veriler Entity Framework ile veritabanına kaydedilir ve Dashboard’da toplam gider verisine yansıtılır. 
Bu form, finansal planlama ve tasarruf analizlerinde kilit rol oynar.
</p>

<h2>⚙️ FrmSettings (Ayarlar)</h2>
<p>
Ayarlar formu, sistemin genel yapılandırmasını ve kullanıcı tercihlerini düzenlemek için kullanılır. 
Tema, para birimi, dil seçenekleri veya bağlantı ayarları bu ekrandan yapılabilir. 
Kullanıcı dostu arayüzü sayesinde kişisel ihtiyaçlara göre özelleştirme kolaydır. 
Ayrıca, veritabanı bağlantı bilgileri gibi teknik ayarlar da bu form üzerinden yönetilebilir. 
Uygulamanın esnek ve sürdürülebilir yapısının temel taşlarından biridir.
</p>
