using Model;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace BusinessLogic
{
    public class Logic
    {
        private BindingList<Student> _students = new BindingList<Student>();

        /// <summary>
        /// Метод добавляет студента, добавляет значения в лист Student
        /// </summary>
        public void AddStudent(string name, string speciality, string group)
        {
            var student = new Student()
            {
                Name = name,
                Group = group,
                Speciality = speciality
            };
            _students.Add(student);
        }

        /// <summary>
        /// Метод удаляет студента из листа Student, выбор происходит по индексу студента
        /// </summary>
        public void RemoveStudent(int index)
        {
            var student = GetStudentByIndex(index);
            if (student != null)
            {
                _students.Remove(student);
            }
        }

        /// <summary>
        /// Метод изменяет данные студента в листе Student
        /// </summary>
        public void UpdateStudent(int index, string newName, string newSpeciality, string newGroup)
        {
            var student = GetStudentByIndex(index);
            if (student != null)
            {
                student.Name = newName;
                student.Speciality = newSpeciality;
                student.Group = newGroup;
            }
        }

        /// <summary>
        /// Метод выводит студентов в консольное приложение
        /// </summary>
        public string GetAll()
        {
            var study = "";
            int counter = 0;
            foreach (var student in _students)
            {
                counter++;
                study += $"{counter}. Имя студента: {student.Name} Специальность: {student.Speciality} Группа: {student.Group}\n";
            }
            Console.WriteLine(study);
            return study;
        }

        /// <summary>
        /// Метод используется для получения информации о студентах в методе LoadStudents в WinForm
        /// </summary>
        public BindingList<Student> GetStudentList()
        {
            return _students;
        }

        /// <summary>
        /// Метод используется для вывода гистограммы студентов по специализациям
        /// </summary>
        public Dictionary<string, int> GetSpecialityDistribution()
        {
            return _students.GroupBy(s => s.Speciality).ToDictionary(g => g.Key, g => g.Count());
        }

        /// <summary>
        /// Метод возвращает студента по индексу
        /// </summary>
        public Student? GetStudentByIndex(int index)
        {
            if (index >= 0 && index < _students.Count)
            {
                return _students[index];
            }
            return null;
        }
    }
}
