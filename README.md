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

<img width="799" height="451" alt="{C43CFBFA-43A6-45A7-ACCD-F35898645769}" src="https://github.com/user-attachments/assets/49c327b5-cbd7-4a0a-9f87-39114a775aa7" />


<h2>🏛️ FrmBanks (Bankalar)</h2>
<p>
Bu form, sistemde tanımlı olan tüm banka hesaplarını listeler ve yönetim işlemlerine olanak tanır. 
Her banka için bakiye, hesap adı, şube bilgisi gibi detaylar görüntülenebilir. 
Kullanıcı yeni banka ekleme, düzenleme veya silme işlemlerini kolayca gerçekleştirebilir. 
Ayrıca, form üzerinden bankalar arası işlem geçişleri de sağlanır. 
Finansal akışın temelini oluşturan bu modül, tüm parasal hareketlerin başlangıç noktasını temsil eder.
</p>

<img width="802" height="452" alt="{BDCBB1FF-A929-42A3-A3B9-24A08CF95354}" src="https://github.com/user-attachments/assets/63b25ee8-c506-4aaa-8764-9a77fe89b908" />


<h2>💸 FrmBanksTransactions (Banka İşlemleri)</h2>
<p>
FrmBanksTransactions, seçilen banka hesaplarının tüm gelir ve gider hareketlerini gösterir. 
Kullanıcı, her işlem için açıklama, tutar, tarih ve işlem tipi bilgilerini detaylı olarak görüntüleyebilir. 
Bu form, banka bakiyelerini güncel tutmak ve geçmiş işlemleri raporlamak için tasarlanmıştır. 
Arayüz, işlem filtreleme ve sıralama özellikleriyle finansal analizi kolaylaştırır. 
Şeffaf bir işlem geçmişi sunarak, kullanıcıya hesap kontrolü sağlar.
</p>

<img width="800" height="450" alt="{5FEB8746-D019-43D5-93AA-AA243433D2BB}" src="https://github.com/user-attachments/assets/2b8ce9b5-a667-49e7-8b24-df21b6fb50ca" />


<h2>🧾 FrmBilling (Faturalar)</h2>
<p>
Faturalama formu, müşteri veya tedarikçilere ait tüm faturaları yönetmek için kullanılır. 
Her fatura için tarih, tutar, kategori ve açıklama bilgileri saklanır. 
Kullanıcı yeni fatura ekleyebilir, mevcut faturaları güncelleyebilir veya silebilir. 
Bu form, gelir–gider dengesi üzerinde doğrudan etkili olan verileri düzenli tutmayı hedefler. 
Finansal kayıtların düzenli takibi için uygulamanın önemli parçalarından biridir.
</p>

<img width="799" height="451" alt="{4EE7AC80-03F7-45CA-9A28-F638D1DFBF9E}" src="https://github.com/user-attachments/assets/9fe85e26-0060-4e8c-9129-09de7c1b0e3a" />


<h2>🗂️ FrmCategories (Kategoriler)</h2>
<p>
FrmCategories formu, gider veya gelir türlerinin sınıflandırılmasını sağlar. 
Kullanıcı, kategori ekleme, silme ve güncelleme işlemlerini bu ekrandan yapabilir. 
Böylece, raporlama ve analiz süreçlerinde hangi harcama kalemlerinin daha fazla yer tuttuğu kolayca belirlenebilir. 
Kategoriler, tüm sistemde dinamik olarak diğer formlarda kullanılır. 
Basit ama finansal düzenin temelini oluşturan bir modüldür.
</p>

<img width="800" height="450" alt="{DF47E189-D114-4CE3-8DF2-F0DA461A924A}" src="https://github.com/user-attachments/assets/b89e2660-f98c-41b1-a954-8ad185cc92c6" />


<h2>💰 FrmExpenses (Giderler)</h2>
<p>
Bu form, şirketin yaptığı tüm harcamaları detaylı şekilde listeler. 
Her gider kaydı; kategori, tarih, tutar ve açıklama bilgilerini içerir. 
Kullanıcı gider ekleme, düzenleme ve silme işlemlerini doğrudan bu form üzerinden yapabilir. 
Veriler Entity Framework ile veritabanına kaydedilir ve Dashboard’da toplam gider verisine yansıtılır. 
Bu form, finansal planlama ve tasarruf analizlerinde kilit rol oynar.
</p>

<img width="801" height="452" alt="{0962E5F1-312D-4CE2-B609-2545493D952B}" src="https://github.com/user-attachments/assets/43e52b6f-e376-4166-8b9a-f29cf40cf6bf" />

<h2>⚙️ FrmSettings (Ayarlar)</h2>
<p>
Ayarlar formu, sistemin genel yapılandırmasını ve kullanıcı tercihlerini düzenlemek için kullanılır. 
Tema, para birimi, dil seçenekleri veya bağlantı ayarları bu ekrandan yapılabilir. 
Kullanıcı dostu arayüzü sayesinde kişisel ihtiyaçlara göre özelleştirme kolaydır. 
Ayrıca, veritabanı bağlantı bilgileri gibi teknik ayarlar da bu form üzerinden yönetilebilir. 
Uygulamanın esnek ve sürdürülebilir yapısının temel taşlarından biridir.
</p>

<img width="800" height="449" alt="{023D2016-57AF-4627-895B-7CE2CC12FD00}" src="https://github.com/user-attachments/assets/c949c2a6-371e-4218-b6f7-e3c0091d3326" />

