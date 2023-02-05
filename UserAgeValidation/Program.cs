// See https://aka.ms/new-console-template for more information


// rakendus palub kasutajal valida oma sugu (m/f)
// rakendus palub kasutajal sisestada oma perekonnanimi
// lähtudes kasutaja valikust, rakenus tervitab kasutajat järgmiselt: 
// "Welcome Mr. [kasutaja perekonnanimi]!" või "Welcome Ms. [kasutaja perekonnanimi]!"

Console.WriteLine("Please enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your first name:");
string firstName = Console.ReadLine();  


Console.WriteLine("Plese enter your gender (f/m):");
char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist ainult string ehk sõne formaadis

if (userGender == 'm')
{
    Console.WriteLine($" Welcome Mr. {firstName} {lastName}!");
}
else if(userGender == 'f'){
    Console.WriteLine($" Welcome Ms. {firstName} {lastName}");
}
else
{
    Console.WriteLine($"Welcome {firstName} {lastName}");
}