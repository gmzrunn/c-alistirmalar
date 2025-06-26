//This code checks user permissions and levels to determine access rights.
string permission = "Admin|Manager";
int level = 10;
bool messageShown = false;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
    messageShown = true;
}
else if (permission.Contains("Admin") && level <= 55)
{
    // Admin ama yetkisiz → Manager kontrolü yapılmalı
}

if (!messageShown && permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
        messageShown = true;
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
        messageShown = true;
    }
}

if (!messageShown)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
