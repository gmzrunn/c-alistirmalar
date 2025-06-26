//This program reverses a string and counts the occurrences of the letter 'o'.
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int count = 0;

foreach (char i in charMessage)
{
    if (i == 'x')
    {
        count++;
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'x' appears {count} times.");