//Это программа приветствия пользователя

Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username == "Ориентальчик")
{
   Console.WriteLine("Ура, это же Ориентальчик!!!"); 
}

else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
