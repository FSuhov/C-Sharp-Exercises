using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl girl1 = new Girl("Masha", 35);
            Gladiatrix gladiatrix1 = new Gladiatrix("Tanya", 27, "Трезубец", 5.98F);
            Console.WriteLine(girl1.ToString());
            Console.WriteLine(gladiatrix1.ToString());

            Girls girls = new Girls(5);
            girls.AddGirl(girl1);
            girls.AddGirl(gladiatrix1);
            foreach(Girl girl in girls)
            {
                Console.WriteLine(girl.ToString());
            }
        }
    }

    public class Girl
    {
        static byte counter = 0; //статическоей поле будем общим для всех экземпляров
        public byte Id { get; set; }
        public string  Name { get; set; }
        public ushort Age { get; set; }

        public Girl(string name, ushort age)
        {
            Id = ++counter;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return System.String.Format("I am {0}, my name is {1}, age {2}, ID {3}", this.GetType(), Name, Age, Id);
        }        
    }

    public class Gladiatrix : Girl //объявление наследника
    {
        public string  Weapon { get; set; }
        public float Strength { get; set; }

        //конструктор, в котором используется конструктор родителя
        public Gladiatrix(string name, ushort age, string weapon, float strength) : base(name, age)
        {
            Weapon = weapon;
            Strength = strength;
        }
    }

    //имплементация интерфейса
    public class Girls : IEnumerable
    {
        Girl[] girls;
        int index = 0;
        public Girls(int capacity)
        {
            girls = new Girl[capacity];
        }

        public void AddGirl(Girl newGirl)
        {
            if(index < girls.Length)
            {
                girls[index++] = newGirl as Girl;
            }
        }       

        public Girl GetGirl(int index)
        {
            if (index < girls.Length)
            {
                return girls[index];
            }
            else return new Girl("", 0);
        }

        public IEnumerator GetEnumerator() //метод, которые итерирует. Требуется для интерфейса
        {
            foreach(Girl girl in girls)
            {
                if (girl == null) break;
                yield return girl;
            }
        }
    }
}
