Console.WriteLine("Please enter your membership type - Gold, Silver, or Guest:");
string membershipType = Console.ReadLine();

if (membershipType == "Gold")
{
    Console.WriteLine("Welcome, Gold Member!");
}
else if (membershipType == "Silver")
{
    Console.WriteLine("Welcome, Silver Member!");
}
else
{
    Console.WriteLine("Welcome, Guest!");
}

// using ternary operator to handle multiple conditions
string message = membershipType == "Gold" ? "Welcome, Gold Member!" :
    membershipType == "Silver" ? "Welcome Silver Member!" :
   "Welcome, Guest!";
Console.WriteLine(message);

double discount = membershipType == "Gold" ? 0.20 :
    membershipType == "Silver" ? 0.10 :
    0.0;
Console.WriteLine($"Your discount rate: {discount:P2}");

double pre_discount_price = 100.0;
double final_price = pre_discount_price * (1-discount);
Console.WriteLine($"The final price is: {final_price:F2}");