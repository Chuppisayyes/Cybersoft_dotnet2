﻿#region Bài 1:
#endregion
#region Bài 2:
/*
    -Input: Giá tiền ly trà sữa và % giảm giá
    -Process: long tienGiam = % giảm giá * giá tiền
              long soTienTra = giá triền ly trà sữa - tienGiam
    -Output: In ra số tiền giảm giá
             In ra số tiền phải trả sau khi giảm
*/

Console.WriteLine("Nhập giá trị đơn hàng");
string defaultValueOrder = Console.ReadLine();
Console.WriteLine("Nhập phần trăm giảm giá");
string discountPercent = Console.ReadLine();

ulong PriceDiscount = (ulong)defaultValueOrder * discountPercent;
ulong PriceTotal = defaultValueOrder - PriceDiscount;
Console.WriteLine($"Số tiền giảm:{PriceDiscount}");
Console.WriteLine($"Số tiền phải trả:{PriceTotal}");

#endregion
#region Bài 1:
#endregion
#region Bài 1:
#endregion
#region Bài 1:
#endregion
#region Bài 1:
#endregion
#region Bài 1:
#endregion