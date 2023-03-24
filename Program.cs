using OOP_17.CrossFigure.CrossFigure;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace OOP_17
{
    namespace CrossFigure
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Створюємо об'єкт Cross і ініціалізуємо його властивості
                Cross cross = new Cross(8, 8);

                // Бінарна серіалізація
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("cross.bin", FileMode.Create))
                {
                    formatter.Serialize(stream, cross);
                }

                // XML серіалізація
                XmlSerializer serializer = new XmlSerializer(typeof(Cross));
                using (FileStream stream = new FileStream("cross.xml", FileMode.Create))
                {
                    serializer.Serialize(stream, cross);
                }

                // Бінарна десеріалізація
                using (FileStream stream = new FileStream("cross.bin", FileMode.Open))
                {
                    cross = (Cross)formatter.Deserialize(stream);
                }

                // XML десеріалізація
                using (FileStream stream = new FileStream("cross.xml", FileMode.Open))
                {
                    cross = (Cross)serializer.Deserialize(stream);
                }

                // Виводимо інформацію про властивості і методи класу, використовуючи рефлексію
                Type type = typeof(Cross);
                PropertyInfo[] properties = type.GetProperties();
                Console.WriteLine("Properties:");
                foreach (var property in properties)
                {
                    Console.WriteLine(property.Name);
                }

                MethodInfo[] methods = type.GetMethods();
                Console.WriteLine("Methods:");
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }

                // Викликаємо метод Draw()
                cross.Draw();

                Console.ReadKey();

            }
        }
    }
}
