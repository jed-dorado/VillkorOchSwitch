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
        Console.WriteLine("Det är frost");
        break;
    case int n when (n >= 0 && n <= 20):
        Console.WriteLine("Lite kyligt");
        break;
    case int n when (n >= 20):
        Console.WriteLine("Det är varmt");
        break;

}