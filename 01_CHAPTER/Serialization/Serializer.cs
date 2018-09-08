using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public static class Serializer<T>
    {
        //XmlSerializer serializer = new XmlSerializer(typeof(T));

        public static void Serialize(T value)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream("output.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, value);
            }
        }

        public static T Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T value;
            using (FileStream fs = new FileStream("output.xml", FileMode.Open))
            {
                value = (T)serializer.Deserialize(fs);
            }
            return value;
        }
    }
}
