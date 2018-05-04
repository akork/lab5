using System;
using _3.Data;

namespace _3
{
    class Program
    {
        static void Main()
        {
            LifeInTown life = new LifeInTown(2034);
            //пописываемся на событие изменения года
            life.YearChangeEvent += LifeOnYearChangeEvent;

            #region Добавление людей

            Homo homo = new Homo("Иван", "Иванов", 2017, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Дмитрий", "Карпов", 2018, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Александр", "Яшин", 2019, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Василий", "Иванов", 2020, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Сергей", "Печкин", 2021, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Александр", "Громов", 2022, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Петр", "Волошин", 2021, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Дмитрий", "Донской", 2021, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Григорий", "Сковорода", 2025, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Евгений", "Трошин", 2026, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Даниил", "Иванов", 2026, Gender.Male);
            life.AddPeople(homo);

            homo = new Homo("Иван", "Дорофеев", 2028, Gender.Male);
            life.AddPeople(homo);
            //===================================================================

            homo = new Homo("Татьяна", "Ларина", 2017, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Татьяна", "Троечкина", 2018, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Михалина", "Романова", 2018, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Ангелина", "Дальняя", 2020, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Валентина", "Петрова", 2021, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Дарья", "Михеева", 2022, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Анастасия", "Дорохина", 2023, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Нина", "Бирюкова", 2020, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Юлия", "Попова", 2025, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Татьяна", "Ларина", 2024, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Рада", "Мнишек", 2027, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Софья", "Копытова", 2028, Gender.Female);
            life.AddPeople(homo);

            homo = new Homo("Нина", "Бортинова", 2026, Gender.Female);
            life.AddPeople(homo);

            for (int i = 0; i < life.PeopleCount; i++)
            {
                life[i].HomoEvent += HomoOnHomoEvent;
            }

            #endregion

            Console.WriteLine(" Жизнь в городе за последние 15 лет");
            for (int i = 0; i < 15; i++)
            {
                life.YearOfLife();
            }

            Console.ReadKey();

        }

        /// <summary>
        /// Обработчик ждя для события объекта LifeInTown
        /// </summary>
        private static void LifeOnYearChangeEvent(int i)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine(" Прошёл " + i + " год");
            Console.WriteLine("****************************************************************");
        }

        /// <summary>
        /// Обработчик события для объекта Homo
        /// </summary>
        private static void HomoOnHomoEvent(Homo sender, HomoEventArgs args)
        {
            // совершеннолетие
            if (args.HomoType == HomoType.Majority)
            {
                Console.WriteLine(sender.FirstName + " " + sender.LastName + " достиг(ла) совершеннолетия");

            }
            // бракосочетание
            if (args.HomoType == HomoType.Marriage)
            {
                Console.WriteLine(sender.FirstName + " " + sender.LastName + " " + sender.YearOfBirth + " г.р. и " +
                                  sender.Partner.FirstName + " " + sender.Partner.LastName + " "
                                  + sender.Partner.YearOfBirth + " г.р. сочетались законным браком");

            }
        }


    }
}
