﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "таня")
{
    Console.WriteLine("Ура, это же ТАНЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

