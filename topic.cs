using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Topic
    {
        public string[] table = new string[7]; // Haftanın 7 günü için 7 eleman yeterli

        // Bu fonksiyon, verilen gün numarasına göre görev girilmesini sağlar
        public bool Move(int choose)
        {
            // 0'dan 6'ya kadar olan seçenekler için kullanıcıdan değer almak
            if (choose >= 0 && choose < 7)
            {
                Console.WriteLine($"Please enter task for {GetDayName(choose)}: "); // Hangi gün olduğunu belirtmek için
                string task = Console.ReadLine();
                table[choose] = task; // Seçilen güne göre value atama
                return true;
            }
            return false; // Geçersiz bir seçim yapılırsa false döner
        }

        // Haftanın 7 günü için takvimi görüntüler
        public void Display()
        {
            Console.Clear(); // Ekranı temizle (takvimi sürekli güncellemek için)
            Console.WriteLine("Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("  {0}  |   {1}   |    {2}    |   {3}    |   {4}  |   {5}    |  {6}   |",
                table[0] ?? "No Task", table[1] ?? "No Task", table[2] ?? "No Task",
                table[3] ?? "No Task", table[4] ?? "No Task", table[5] ?? "No Task",
                table[6] ?? "No Task"); // Eğer boş ise 'No Task' yaz
        }

        // Yardımcı fonksiyon: Haftanın gün ismini döndürür
        private string GetDayName(int dayIndex)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return days[dayIndex];
        }
    }
}
