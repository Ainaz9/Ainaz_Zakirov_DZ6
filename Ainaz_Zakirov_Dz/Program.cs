// DZ6



namespace Programm
{
    public class dz6
    {
        abstract class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            public Person(string name, int age, string gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }

            public abstract void DisplayInfo();

            public string GetBasicInfo() => $"Имя: {Name}, Возраст: {Age}, Пол: {Gender}";
        }

        class Deceased : Person
        {
            public DateTime DateOfDeath { get; set; }
            public string CauseOfDeath { get; set; }

            public Deceased(string name, int age, string gender, DateTime dateOfDeath, string causeOfDeath)
                : base(name, age, gender)
            {
                DateOfDeath = dateOfDeath;
                CauseOfDeath = causeOfDeath;
            }

            public Deceased(string name, int age, string gender) : this(name, age, gender, DateTime.Now, "Неизвестно") { }

            public override void DisplayInfo()
            {
                Console.WriteLine($"{GetBasicInfo()}, Дата смерти: {DateOfDeath.ToShortDateString()}, Причина смерти: {CauseOfDeath}");
            }

            public void UpdateCauseOfDeath(string cause)
            {
                CauseOfDeath = cause;
            }

            public int GetYearsSinceDeath()
            {
                return DateTime.Now.Year - DateOfDeath.Year;
            }
        }

        class MorgueWorker : Person
        {
            public string Position { get; set; }
            public int ExperienceYears { get; set; }

            public MorgueWorker(string name, int age, string gender, string position, int experienceYears)
                : base(name, age, gender)
            {
                Position = position;
                ExperienceYears = experienceYears;
            }

            public MorgueWorker(string name, int age, string gender) : this(name, age, gender, "Стажёр", 0) { }

            public override void DisplayInfo()
            {
                Console.WriteLine($"{GetBasicInfo()}, Должность: {Position}, Стаж: {ExperienceYears} лет");
            }

            public void Promote(string newPosition)
            {
                Position = newPosition;
            }

            public void GainExperience()
            {
                ExperienceYears++;
            }
        }

        class Morgue
        {
            public string Name { get; private set; }
            public List<Deceased> DeceasedList { get; set; }
            public List<MorgueWorker> Workers { get; set; }

            public Morgue(string name)
            {
                Name = name;
                DeceasedList = new List<Deceased>();
                Workers = new List<MorgueWorker>();
            }

            public void AddDeceased(Deceased deceased)
            {
                DeceasedList.Add(deceased);
            }

            public void AddWorker(MorgueWorker worker)
            {
                Workers.Add(worker);
            }

            public void DisplayAllDeceased()
            {
                Console.WriteLine("Список умерших:");
                foreach (var d in DeceasedList)
                {
                    d.DisplayInfo();
                }
            }

            public void DisplayAllWorkers()
            {
                Console.WriteLine("Список работников:");
                foreach (var w in Workers)
                {
                    w.DisplayInfo();
                }
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                // Создаем морг
                Morgue morgue = new Morgue("Городской морг");

                // Создаем работников
                MorgueWorker worker1 = new MorgueWorker("Cтас Карпов", 35, "Мужской", "Судмедэксперт", 10);
                MorgueWorker worker2 = new MorgueWorker("Катя Новикова", 29, "Женский");

                // Добавляем работников в морг
                morgue.AddWorker(worker1);
                morgue.AddWorker(worker2);

                // Создаем умерших
                Deceased deceased1 = new Deceased("Иван Иванов", 72, "Мужской", new DateTime(2022, 5, 15), "Инфаркт");
                Deceased deceased2 = new Deceased("Мария Кузнецова", 68, "Женский");

                // Добавляем умерших в морг
                morgue.AddDeceased(deceased1);
                morgue.AddDeceased(deceased2);

                // Демонстрируем работу программы
                Console.WriteLine($"Добро пожаловать в {morgue.Name}");
                morgue.DisplayAllWorkers();
                morgue.DisplayAllDeceased();

                // Пример работы методов
                Console.WriteLine("\nОбновление данных...");
                deceased2.UpdateCauseOfDeath("Пневмония");
                worker2.Promote("Ассистент судмедэксперта");
                worker2.GainExperience();

                // Показ обновленных данных
                morgue.DisplayAllWorkers();
                morgue.DisplayAllDeceased();
            }
        }
    }

}


