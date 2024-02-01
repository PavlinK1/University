/*
Да се програма, която образува цените за билети за театрални постановки.
За целта трябва да се създаде клас Потребител с необходимите полета в него.
Ако потребителят е учащ – той получава 18 % отстъпка от редовната цена.
Ако потребителят е пенсионер – получава 25 % отстъпка. Редовната цена е х лв.
Пенсионери са жени над 63 години и мъже над 66 години. Да се създадат два обекта
и да се отпечатат на каква цена са си купили билетите.
*/



using System;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public bool IsStudent { get; set; }

    public User(string name, int age, char gender, bool isStudent)
    {
        Name = name;
        Age = age;
        Gender = gender;
        IsStudent = isStudent;
    }

    public double CalculatePrice(double regularPrice)
    {
        if (IsStudent)
        {
            return regularPrice * 0.82; // 18% discount for students
        }
        else if ((Gender == 'F' && Age >= 63) || (Gender == 'M' && Age >= 66))
        {
            return regularPrice * 0.75; // 25% discount for pensioners
        }
        else
        {
            return regularPrice;
        }
    }
}

public class Program
{
    public static void Main()
    {
        double ticketPrice = 50;

        User student = new User("Alice", 20, 'F', true);
        User pensioner = new User("Bob", 70, 'M', false);

        Console.WriteLine($"{student.Name} bought the ticket at a price of: {student.CalculatePrice(ticketPrice)} BGN");
        Console.WriteLine($"{pensioner.Name} bought the ticket at a price of: {pensioner.CalculatePrice(ticketPrice)} BGN");
    }
}
