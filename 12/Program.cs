// This program simulates a coin flip and prints the result.
Random coin = new Random();
int flip = coin.Next(0, 2);// 0 for yazı, 1 for tura
Console.WriteLine((flip == 0) ? "yazı" : "tura");