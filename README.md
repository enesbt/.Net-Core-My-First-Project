# .Net-Core-My-First-Project
## Kullanılan Teknolojiler
- Framework olarak entity framework core kullanılmıştır.
- Mimari olarak n katmanlı mimari kullanılmıştır.
- Geliştirme yaklaşımı olarak repository design pattern
- Code First olarak geliştirilmiştir.
- Kullanıcı işlemleri için Identity kütüphanesi kullanılmıştır.

## Proje Amacı
- Kayıp evcil hayvanların veya sokakta bulunan evcil hayvanların ilanları verilerek sahiplerine daha kolay ulaşmak.

## Site Özellikleri
- Siteyi kullanan 3 rol üzerinden oluşturulmuştur.Kullanıcı , üye , admin
- Üyeler ilan verebilir bu ilanlara kullanıcılar ulaşır ve üyeye mesaj atabilir.
- İletişim sekmesinden adminle direk iletişime geçilebilir
- İlan özelliklerine göre filtreleme işlemi yapılabilir
- Admin tüm özellikleri kontrol edebilir ekleme güncelleme silme işlemi yapabilir , kullanıcılara rol atayabilir.
- Admin ilan şikayetlerine ulaşabilir şikayet edilen ilanı görüntüleyip kaldırabilir.

## Veri Tabanı İlişkileri
- 1 ilana birden fazla şikayet gelebilir
- 1 ilana birden fazla  mesaj gelebilir
- 1 şehir birden fazla ilanda yer alabilir
- 1 kategori birden fazla ilanda yer alabilir
- 1 yaş aralığı birden fazla ilanda yer alabilir
- 1 tür birden fazla ilanda yer alabilir
- 1 cins birden fazla ilanda yer alabilir
- 1 türde birden fazla cins olabilir
