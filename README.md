
# ToDoList Uygulaması

Bu proje, kullanıcıların haftalık görevlerini düzenlemelerini ve takip etmelerini sağlayan basit bir ToDoList uygulamasıdır. Kullanıcılar, her bir gün için görevlerini ekleyebilir ve bu görevleri haftalık takvim üzerinde takip edebilir.

## Özellikler

- Haftalık takvim (Pazartesi - Pazar) görüntülenir.
- Kullanıcı, herhangi bir güne görev ekleyebilir.
- Kullanıcı her bir gün için tek tek görev girebilir ve takvim dinamik olarak güncellenir.
- Eğer bir gün için görev girilmemişse, o gün "No Task" olarak görünür.
- Takvim her seferinde güncellenir ve eski görevler kaybolmaz.

## Gereksinimler

- .NET Framework 4.7.2 veya daha yüksek sürüm
- Visual Studio veya benzer bir IDE

## Kurulum

1. **Proje dosyasını klonlayın veya indirin:**

   ```bash
   git clone https://github.com/KullaniciAdiniz/ToDoList.git
   ```

2. **Visual Studio ile projeyi açın.**

   - Projeyi Visual Studio veya bir IDE ile açın.
   - `ToDoList.sln` dosyasını açarak projeyi çalıştırabilirsiniz.

3. **Gerekli paketleri yükleyin:**
   
   Uygulama için herhangi bir NuGet paketine ihtiyaç yoktur, ancak `.NET Framework` 4.7.2 yüklü olmalıdır.

4. **Uygulamayı Çalıştırın:**
   - Projeyi çalıştırarak uygulamanın konsol ekranında görev eklemeye başlayabilirsiniz.

## Kullanım

1. Uygulama başladığında haftalık takvim ekrana gelir.
2. Uygulama, hangi gün için görev eklemek istediğinizi sorar (Pazartesi, Salı, Çarşamba vb.).
3. Her gün için görevlerinizi ekleyin.
4. Takvim, eklediğiniz görevlerle birlikte güncellenir.
5. Kullanıcı **"Exit"** seçeneğini seçene kadar görevler eklenebilir.

### Örnek Kullanım:

```bash
Please enter task for Monday: 
Task 1
Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday
----------------------------------------------------------------------
  Task 1  |   No Task   |    No Task    |   No Task    |   No Task  |   No Task    |  No Task   |

Which day would you like to assign a task to?
1. Monday
2. Tuesday
3. Wednesday
4. Thursday
5. Friday
6. Saturday
7. Sunday
8. Exit
Select a day (1-8): 2
Please enter task for Tuesday: 
Task 2

Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday
----------------------------------------------------------------------
  Task 1  |   Task 2   |    No Task    |   No Task    |   No Task  |   No Task    |  No Task   |

...
```

## Katkıda Bulunma

Eğer projeye katkı sağlamak isterseniz, aşağıdaki adımları takip edebilirsiniz:

1. Bu projeyi fork edin.
2. Yeni bir feature branch oluşturun.
3. Değişikliklerinizi yapın ve commit edin.
4. Pull request gönderin.

## Lisans

Bu proje **MIT Lisansı** ile lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

---

## Ekstra Notlar

- Bu uygulama sadece temel bir To-Do listesi işlevselliği sunmaktadır. İlerleyen sürümlerde, kullanıcıların görevlerini tamamlayıp işaretlemelerine olanak tanıyacak, görevlerin bitiş tarihlerini ekleyerek hatırlatıcılar oluşturabilecek daha gelişmiş özellikler eklenebilir.
