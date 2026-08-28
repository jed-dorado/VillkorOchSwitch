//Console.Write("Ange din ålder");
//int age = int.Parse(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Du är myndig.");
//}
//else
//{
//    Console.WriteLine("Du är inte myndig.");
//}
//Betygs godkännande
//Console.Write("Ange betyg (A-F): ");
//string grade = Console.ReadLine().ToUpper();
//    if (grade== "F")
//    {
//        Console.WriteLine("Ej godkänd");
//    }
//    else
//    {
//        Console.WriteLine("Godkänd");
//    }


Console.Write("Skriv temperaturen i Celsius: ");
int temp = int.Parse(Console.ReadLine());

switch (temp)
    {
    case int n when (n <= 0):
        Console.WriteLine("Det är frost men jag ska iaf tillbringa vintrarna i Thailand");
        break;
    case int n when (n >= 0 && n <= 20):
        Console.WriteLine("Lite kyligt");
        break;
    case int n when (n >= 20 && n <= 30):
        Console.WriteLine("Det är varmt");
        break;
    case int n when (n > 30 && n <= 40):
        Console.WriteLine("Det är ganska varmt");
        break;
    case int n when (n > 40 && n <= 50):
        Console.WriteLine("det är frågan om det är dags att uppsöka en kyl att sova i");
        break;
    case int n when (n > 50):
        Console.WriteLine("stor skans att allmäna folket smällter");
        break;

}