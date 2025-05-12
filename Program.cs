using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic();

            // Başlangıçta takvimi göster
            topic.Display();

            // Kullanıcıya hangi günü seçtiğini sor
            while (true)
            {
                Console.WriteLine("\nWhich day would you like to assign a task to?");
                Console.WriteLine("1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7. Sunday\n8. Exit");
                Console.Write("Select a day (1-8): ");
                int dayChoice = int.Parse(Console.ReadLine()) - 1; // 0 ile 6 arasındaki değerler olacak

                if (dayChoice == 7) // Çıkış için 8 seçildiğinde döngüden çık
                {
                    break;
                }

                if (dayChoice >= 0 && dayChoice < 7)
                {
                    topic.Move(dayChoice); // Seçilen gün için görev gir
                    topic.Display(); // Güncellenmiş takvimi göster
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please choose a valid day.");
                }
            }

            Console.WriteLine("\nFinal Schedule:");
            topic.Display(); // Son takvimi göster
        }
    }
}
