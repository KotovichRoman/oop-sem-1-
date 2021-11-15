using System;
using System.Linq;

namespace lab3
{
    public class Abiturient
    {
        public static int Id = 0; //только для чтения
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        private string _address;
        public string Addres
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public readonly int Phone;
        public int[] Pass;
        static int[] PassForStatic; //статическое поле

        public Abiturient(int Id, string addSurname, string addName, string addPatronymic,
            string addAddres, int addPhone, int[] addPass) //конструктор с параметрами
        {
            Id++;
            Surname = addSurname;
            Name = addName;
            Patronymic = addPatronymic;
            Addres = addAddres;
            Phone = addPhone;
            foreach (int element in addPass)
            {
                Pass[element] = addPass[element];
            }
        } 

        public Abiturient() //конструктор без аргументов
        {
            Id++;
            Surname = "not";
            Name = "not";
            Patronymic = "not";
            Addres = "not";
            Phone = 0;
            Pass[0] = 0;
            Pass[1] = 0;
            Pass[2] = 0;
        }

        static Abiturient() //статический конструктор
        {
            Id++;
            PassForStatic[0] = 4;
            PassForStatic[1] = 6;
            PassForStatic[2] = 8;
        }

        public Abiturient(string Surname, string Name, string Patronymic,
            string Addres, int Phone, int[] Pass)
        {
            Id++;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Addres = Addres;
            this.Phone = Phone;
            foreach (var element in Pass)
            {
                this.Pass[element] = Pass[element];
            }
        }

        private Abiturient(int[] AddPass) //закрытый конструктор
        {
            Id++;
            Surname = "not";
            Name = "not";
            Patronymic = "not";
            Addres = "not";
            Phone = 0;
            Pass = AddPass;
        }

        private int sum;
        public void middle_pass(ref int[] Pass, out int sumPass)
        {
            foreach (int element in Pass)
            {
                sum += Pass[element];
            }

            sumPass = sum / Pass.Length;
        }

        public int SumPass()
        {
            foreach (int element in Pass)
            {
                sum += Pass[element];
            }

            return sum;
        }

        public int MaxPass()
        {
            Array.Sort(Pass);
            return Pass[Pass.Length];
        }

        public int MinPass()
        {
            Array.Sort(Pass);
            return Pass[0];
        }

        public void about()
        {
            Console.WriteLine($"{Id}\n{Surname}\n{Name}\n{Patronymic}\n{Addres}\n{Phone}\n{Pass}\n\n");
        }
        
        private int n {get;}

        public override int GetHashCode()
        {
            return n;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;
            Abiturient el = obj as Abiturient;
            if (el as Abiturient == null)
                return false;

            return el.Addres == this.Addres && el.Pass == this.Pass; 
        }

        public override string ToString()
        {
            return ($"\n{this.Surname}\n{this.Name}\n{this.Patronymic}\n{this.Addres}\n{this.Phone}\n{Pass}\n\n");
        }
    }
    
    public partial class Person
    {
        public void krytoi()
        {
            Console.WriteLine("I krytoi");
        }
    }
    
    class Program
    {
        static void Main()
        {
            int sumPass;
            
            Abiturient abiturient1 = new Abiturient();
            Abiturient abiturient2 = new Abiturient("Surname2", "Name2", "Patronymic2", "Addres2", 22222, new int[3] {1, 2, 3});
            Abiturient abiturient3 = new Abiturient("Surname3", "Name3", "Patronymic3", "Addres3", 33333, new int[3] {4, 5, 6});

            abiturient1.Pass = new int[3] {2, 4, 6};
            abiturient1.middle_pass(ref abiturient1.Pass, out sumPass);
            Console.WriteLine(sumPass);

            abiturient1.Name = "chel";
            abiturient2.about();
            abiturient3.Equals(abiturient1);
            abiturient2.GetHashCode();
            abiturient1.MaxPass();

            Abiturient[] arrayOfAbiturients = new Abiturient[] {abiturient1, abiturient2, abiturient3};

            for (int i = 0; i < arrayOfAbiturients.Length; i++)
            {
                for (int j = 0; j < arrayOfAbiturients[i].Pass.Length; j++)
                {
                    if (arrayOfAbiturients[i].Pass[j] < 4)
                    {
                        arrayOfAbiturients[i].about();
                    }
                }
            }

            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrayOfAbiturients.Length; i++)
            {
                if (arrayOfAbiturients[i].SumPass() > number)
                {
                    arrayOfAbiturients[i].about();
                }
            }

            var anonimAbiturient = new
            {
                Surname = "Surname4", Name = "Name4", Patronymic = "Patronymic4",
                Addres = "Addres4", Phone = 44444, Pass = new int[3] {1, 2, 3}
            };
            
        }
    }
}