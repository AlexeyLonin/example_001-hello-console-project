Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "белка")
{
    Console.WriteLine("Ура, это же Белка!");

}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}