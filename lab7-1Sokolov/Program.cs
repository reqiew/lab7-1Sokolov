try
{
    Console.Write("Введите кол-во работников:");
    int n = int.Parse(Console.ReadLine());
    Rab[] rab = new Rab[n];
    for (int i = 0; i < n; i++)
    {
        rab[i] = new Rab();
        Console.WriteLine("Введите фамилию работника");
        rab[i].fam = Console.ReadLine();
        Console.WriteLine("Введите должность работника");
        rab[i].dol = Console.ReadLine();



        Console.WriteLine("Введите год заключения контракта");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите месяц заключения контракта");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите день заключения контракта");
        int day = int.Parse(Console.ReadLine());
        rab[i].dat = new DateTime(year, month, day);


        Console.WriteLine("Введите отработанное кол-во лет");
        int year1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите отработанное кол-во месяцев");
        int month1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите отработанное кол-во дней");
        int day1 = int.Parse(Console.ReadLine());
        rab[i].srok = new DateTime(year1, month1, day1);


        Console.WriteLine("Введите текущий год");
        int year2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите текущий месяц");
        int month2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите текущий день");
        int day2 = int.Parse(Console.ReadLine());
        rab[i].tod = new DateTime(year2, month2, day2);


        Console.WriteLine("Введите оклад работника(В рублях)");
        rab[i].oclad = double.Parse(Console.ReadLine());

    }
    for (int i = 0; i < n; i++)
    {
        {
            if (rab[i].tod.Subtract(rab[i].dat).TotalDays / 365 < 1)
            {
                Console.Write("Фамилия:  " + rab[i].fam);
                Console.Write("Должность:  " + rab[i].dol);
                Console.Write("Дата заключения контракта:  " + rab[i].dat);
                Console.Write("Срок заключения контракта:  " + rab[i].srok);
                Console.Write("Оклад:  " + rab[i].oclad);
            }



        }

    }



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Rab
{
    public string fam;
    public string dol;
    public DateTime dat;
    public DateTime srok;
    public double oclad;
    public DateTime tod;
}

