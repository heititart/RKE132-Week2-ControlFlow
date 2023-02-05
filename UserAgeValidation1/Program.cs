// See https://aka.ms/new-console-template for more information


// Rakendus palub kasutajal sisestada vanuse
// kui kasutaja vanus on väiksem kui 13 siis konsoolis kuvatakse "U R to young too use Instagram!"
// Muul juhul konsoolis kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age:");
int  userAge = Int32.Parse(Console.ReadLine()); // "13" - heap 13, 13- stack


if (userAge >= 13)
{
    Console.WriteLine("Welcome too Instagram!");
}

//else if (userAge == 13)
//{
//    Console.WriteLine("Welcome too Instagram!");
//}

else
{
            Console.WriteLine("U R to young to use Instagram!");    
}

