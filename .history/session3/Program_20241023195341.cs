﻿#region if-else statements
// Nhập số nguyên từ bàn phím. In ra số đó là số lẻ hay số chẵn
// Input
    string? number = Console.ReadLine();
    int formatNumber = Convert.ToInt32(number);
    if(formatNumber % 2 == 0)
    {   
        Console.WriteLine($"Số {number} là số chẵn");
    } else {
        Console.WriteLine($"Số {number} là số lẻ");
    }
    Console
#endregion