using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // класс млекопитающие
    public class Mammalia : Animalia, ITypeOfMove, IVitalActivity
    {
        // объявлены в Животных
        //protected string classis; // класс 
        //protected string phylum; // тип 
        //protected bool multicellular; //многоклеточный 
        //protected bool aerobe; // аэробный
        //protected bool dioecious; // двуполый

        // поля класса Млекопитающие
        protected string species; // вид
        protected int weight; // средняя масса взрослого экземпляра
        protected string[] habitat;

        // конструкторы
        public Mammalia() // по умолчанию
        {
            multicellular = false;
            aerobe = false;
            dioecious = false;
            phylum = "Хордовые";
            classis = "Млекопитающие";
            species = "Dog";
            weight = 15;
            habitat = new string[4];
            for (int i = 0; i < 4; i++)
            {
                habitat[i] = "Not defined";
            }
            habitat[0] = "Европа";
            habitat[1] = "Азия";
        }

        public Mammalia(bool multicellular, bool aerobe, bool dioecious,
            string phylum, string classis, string species, int weight, params string[] habitat) // все значения
        {

            this.multicellular = multicellular;
            this.aerobe = aerobe;
            this.dioecious = dioecious;
            this.phylum = phylum;
            this.classis = classis;
            this.species = species;
            try
            {
                if (weight < 0)
                {
                    weight = 0;
                    throw new MammaliaException("Введено отрицательное значение массы, значение изменено на 0.");
                }
            }
            catch (MammaliaException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            this.weight = weight;

            this.habitat = new string[4];
            int haLn = habitat.Length;
            try
            {
                if (habitat.Length > 4)
                {
                    throw new MammaliaException("Превышено количество записей для мест обитания, будет оставлено только 4 записей.");
                }
            }
            catch (MammaliaException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            if (haLn > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    this.habitat[i] = habitat[i];
                }
            }
            else if (haLn > 0)
            {
                for (int i = 0; i < haLn; i++)
                {
                    this.habitat[i] = habitat[i];
                }
                for (int i = haLn; i < 4; i++)
                {
                    this.habitat[i] = "Not defined";
                }
            }
        }

        public Mammalia(bool multicellular, bool aerobe, bool dioecious,
    string phylum = "Not defined", string classis = "Not defined", string species = "Not defined",
    int weight = 0) // со значениями по умолчанию
        {
            this.multicellular = multicellular;
            this.aerobe = aerobe;
            this.dioecious = dioecious;
            this.phylum = phylum;
            this.classis = classis;
            this.species = species;
            if (weight < 0)
            {
                throw new MammaliaException("Введено отрицательное значение массы.");
            }
            else
            {
                this.weight = weight;
            }
            this.habitat = new string[4];
            for (int i = 0; i < 4; i++)
            {
                this.habitat[i] = "Not defined";
            }
        }

        public Mammalia(Mammalia oldObj) // конструктор копирования
        {
            this.multicellular = oldObj.multicellular;
            this.aerobe = oldObj.aerobe;
            this.dioecious = oldObj.dioecious;
            this.phylum = oldObj.phylum;
            this.classis = oldObj.classis;
            this.species = oldObj.species;
            this.weight = oldObj.weight;
            this.habitat = new string[4];
            int haLn = oldObj.habitat.Length;
            if (haLn > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    this.habitat[i] = oldObj.habitat[i];
                }
            }
            else if (haLn > 0)
            {
                for (int i = 0; i < haLn; i++)
                {
                    this.habitat[i] = oldObj.habitat[i];
                }
                for (int i = haLn; i < 4; i++)
                {
                    this.habitat[i] = "Not defined";
                }
            }
        }
        // реализация абстрактного класса

        public string this[int i]
        {
            get
            {
                return habitat[i];
            }
            set
            {
                habitat[i] = value;
            }
        }

        public string Species
        {
            get
            {
                return species;
            }

            set
            {
                species = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        // переопределение виртуальной функции
        public override bool NeedOxygen()
        {
            return aerobe;
        }

        public override bool IsItDioecious()
        {
            return dioecious;
        }

        //  интерфейс тип движения // явная реализация // разница?

        public void TypeOfMove()
        {
            return;
        }

        // интерфейс процессы жизнедеятельности
        public void Eat()
        {
            return;
        }

        public void Breathe()
        {
            return;
        }

        public void Reproduction()
        {
            return;
        }

        // Переопределение метода ToString класса object
        public override string ToString()
        {
            string tempStr;
            string nameTemp;
            if (species == "Not defined")
                nameTemp = "Наименование неопределено";
            else
                nameTemp = string.Concat("Наименование: ", species.ToUpper());
            string multicellularTemp;
            if (multicellular == true)
                multicellularTemp = "Многоклеточные";
            else
                multicellularTemp = "Одноклеточные";
            string aerobeTemp;
            if (aerobe == true)
                aerobeTemp = "Аэробные";
            else
                aerobeTemp = "Анаэробные";
            string dioeciousTemp;
            if (dioecious == true)
                dioeciousTemp = "Двуполые";
            else
                dioeciousTemp = "Гермафродиты";
            string phylumTemp;
            if (phylum == "Not defined")
                phylumTemp = "Тип неопределен";
            else
                phylumTemp = string.Concat("Тип ", phylum);
            string classisTemp;
            if (classis == "Not defined")
                classisTemp = "Класс неопределен";
            else
                classisTemp = string.Concat("Класс ", classis);
            string speciesTemp;
            if (species == "Not defined")
                speciesTemp = "Вид неопределен";
            else
                speciesTemp = string.Concat("Вид ", species);
            string weightTemp;
            if (weight > 0)
                weightTemp = string.Concat("Средняя масса взрослой особи равна ", weight.ToString(), "кг");
            else
                weightTemp = "Средняя масса взрослой особи неопределена";
            string habitatTemp = "Места обитания неопределены.";
            for (int i = 0; i < 4; i++)
            {
                if (habitat[i] != "Not defined")
                {
                    if (habitatTemp == "Места обитания неопределены.")
                    {
                        habitatTemp = string.Concat("Места обитания: ", habitat[i]); ;
                    }
                    else
                    {
                        habitatTemp = string.Concat(habitatTemp, ", ", habitat[i]);
                    }
                }
            }
            tempStr = string.Join(", ", nameTemp, multicellularTemp, aerobeTemp, dioeciousTemp, phylumTemp,
                classisTemp, speciesTemp, weightTemp, habitatTemp);

            return tempStr;
        }
    }
}
