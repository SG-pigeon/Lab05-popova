// int dayNumber = 6;

// switch (dayNumber) {
//     case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

// int score = 78;

// switch (score) {
//     case >= 0 and < 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// int temperature = 20;

// string result = temperature switch {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко"
// };

// Console.WriteLine(result);

// string role = "user";

// string result1 = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" => "Ограниченный доступ"
// };

// Console.WriteLine(result1);

// int age = 20;
// bool hasTicket = true;

// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// Console.Write("Введите номер месяца: ");
// int month = int.Parse(Console.ReadLine());

// string season = month switch {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);

// Console.Write("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine());

// string result = day switch {
//     1 or 2 or 3 or 4 or 5 => "Будний",
//     6 or 7 => "Выходной",
//     _ => "Неверный день"
// };

// Console.WriteLine(result);

Console.Write("Введите результат: ");
int score = int.Parse(Console.ReadLine());

string result = score switch {
    >= 0 and <= 39 => "Неудовлетворительно",
    >= 40 and <= 59 => "Удовлетворительно",
    >= 60 and <= 79 => "Хорошо",
    >= 80 and <= 100 => "Отлично",
    _ => "Ошибка"
};

Console.WriteLine(result);

Console.Write("Введите количество очков: ");
int points = int.Parse(Console.ReadLine());

string level = points switch {
    < 0 => "Ошибка",
    >= 0 and <= 999 => "Новичок",
    >= 1000 and <= 4999 => "Опытный",
    >= 5000 and <= 9999 => "Продвинутый",
    >= 10000 => "Мастер"
};

Console.WriteLine(level);
