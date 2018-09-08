using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl girl1 = new Girl(1, "Tanya", "Danielle", new DateTime(1976, 12, 17), 50, 34, 5.5);
            Girl girl2 = new Girl(2, "Goldie", "Blair", new DateTime(1974, 12, 3), 43, 44, 6.5);
            Girl girl3 = new Girl(3, "Critstina", "Carter", new DateTime(1977, 4, 6), 55, 84, 4.3);

            //Serializer<Girl>.Serialize(girl1);
            //Girl newGirl = Serializer<Girl>.Deserialize();
            //Console.WriteLine(newGirl.ToString());

            //List<Girl> listOfGirls = new List<Girl>();
            //listOfGirls.Add(girl1);
            //listOfGirls.Add(girl2);
            //listOfGirls.Add(girl3);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Girl>));
            //Stream stream = File.OpenWrite("outputList.xml");
            //serializer.Serialize(stream, listOfGirls);

            List<Girl> newListOfGirls;
            using (FileStream fs = new FileStream("outputList.xml", FileMode.Open))
            {
               newListOfGirls = (List<Girl>)serializer.Deserialize(fs);
            }

            foreach(Girl girl in newListOfGirls)
            {
                Console.WriteLine(girl.ToString());
            }               
        }
    }
}

/*
 * Сериализация - способ сохранения данных, в том числе структурированно, с сохранением структуры объекта.
 * Есть разные способы хранения - XML, байтовый, json.
 * Мы используем XML.
 * Для сериализации нужно:
 * 1. Подключить System.Xml.Serialization;
 * 2. Если собираемся записывать/читать файл, то подключить System.IO;
 * 3. Если сериализовать будем объекты, то объект снабдить аттрибутом [Serializable]. Класс также должен быть public.
 * 4. Создать экземпляр XmlSerializer указав тип данных, которые будут сериализоваться -
 *    XmlSerializer serializer = new XmlSerializer(typeof(List<Girl>));
 * 5. Запустить его метод Serialize([поток], [данные]) - serializer.Serialize(filestream, data);
 * 6. Для десериализации - <Type> newData = serializer.Deserialize(filestream);
*/
