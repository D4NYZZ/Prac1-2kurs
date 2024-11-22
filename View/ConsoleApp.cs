using BusinessLogic;
using System;
namespace View
{
    public class Programm
    {
        public static void Main()
        {
            Logic logic = new Logic();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выбирайте действие:");
                Console.WriteLine("1 - Добавить студента");
                Console.WriteLine("2 - Удалить студента");
                Console.WriteLine("3 - Изменить данные студента");
                Console.WriteLine("4 - Показать список студентов");
                Console.WriteLine("5 - Показать распределение по специальностям");
                Console.WriteLine("6 - Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите специальность: ");
                        string speciality = Console.ReadLine();
                        Console.Write("Введите группу: ");
                        string group = Console.ReadLine();
                        logic.AddStudent(name, speciality, group);
                        break;
                    
                    case "2":
                        Console.Write("Введите индекс студента для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out int indexToRemove))
                        {
                            logic.RemoveStudent(indexToRemove - 1);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный индекс");
                        }
                        break;
                    
                    case "3":
                        Console.Write("Введите индекс студента для изменения его данных: ");
                        if (int.TryParse(Console.ReadLine(), out int indexToUpdate))
                        {
                            Console.Write("Введите новое имя: ");
                            string newName = Console.ReadLine();
                            Console.Write("Введите новую специальность: ");
                            string newSpeciality = Console.ReadLine();
                            Console.Write("Введите новую группу: ");
                            string newGroup = Console.ReadLine();
                            logic.UpdateStudent(indexToUpdate - 1, newName, newSpeciality, newGroup);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный индекс.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Список студентов:");
                        
                        logic.GetAll();
                        
                        break;
                    
                    case "5":
                        var distribution = logic.GetSpecialityDistribution();
                        Console.WriteLine("Распределение студентов по специальностям:");
                        foreach (var item in distribution)
                        {
                            Console.WriteLine($"Специальность: {item.Key}, Количество: {item.Value}");
                        }
                        break;
                    
                    case "6":
                        exit = true;
                        break;
                    
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}  
   
