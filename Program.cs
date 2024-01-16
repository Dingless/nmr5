string  lösenord = "nopass";
string rättlösenord = "";
while (lösenord != "rättlösenord")
{
    Console.WriteLine("Ange ditt lösenord");
    lösenord = Console.ReadLine();
    if (rättlösenord != "lösenord")
    {
        Console.WriteLine("Fel lösenord försök igen");
    }
}
