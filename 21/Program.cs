﻿string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($" {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($" {pallet}");
}

Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
