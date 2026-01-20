# query_and_stack_project
# İşlemci ve Süreç Yönetimi Simülasyonu (Process Scheduling)

Bu proje, Veri Yapıları dersi kapsamında **Öncelikli Kuyruk (Priority Queue)** ve **Yığın (Stack)** veri yapılarını kullanarak bir işlemci simülasyonu gerçekleştirmektedir.

## 🎯 Projenin Amacı
Sistem; P1, P2 ve P3 kaynaklarından gelen rastgele önceliklere sahip süreçleri (process) kuyruğa alır, öncelik sırasına göre işler ve tamamlananları raporlamak üzere saklar.

##  Çalışma Mantığı ve Özellikler

1. **Süreç Üretimi (Processes):** - P1, P2 ve P3 kaynakları belirli aralıklarla rastgele süreç üretir.
   - Her sürece **0 ile 5** arasında bir öncelik atanır. 
   - **Önemli:** `0` En Yüksek Öncelik, `5` En Düşük Öncelik kabul edilir.

2. **Öncelikli Kuyruk (Priority Queue):**
   - Üretilen süreçler geliş sırasına göre değil, öncelik değerine göre kuyruğa yerleşir.
   - Örnek Sıralama: `P1-0 -> P2-1 -> P3-3` (Düşük rakam öne geçer).

3. **İşlemci (Processor):**
   - "İşlemci Başlat" butonuna tıklandığında kuyruktaki elemanları sırayla işler.
   - İşlenen elemanlar kuyruktan çıkarılır.

4. **Yığın (Stack) ile Raporlama:**
   - İşlemci tarafından bitirilen süreçler bir Yığın (Stack) yapısına atılır.
   - "Bitirilen Prosesleri Göster" dendiğinde yığındaki veriler listelenir.

5. **Dinamik Hız Kontrolü:**
   - Arayüzdeki **TrackBar** araçları ile hem işlemcinin çalışma hızı hem de süreçlerin üretim hızı (saniye başına işlem sayısı) anlık olarak değiştirilebilir.

##  Kullanılan Teknolojiler
* **Dil:** C# (.NET Framework)
* **Arayüz:** Windows Forms Application
* **Veri Yapıları:** Custom Priority Queue, Stack, Object Oriented Programming (OOP)
