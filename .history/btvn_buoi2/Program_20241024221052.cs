﻿using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
#region Bài 1: tính số tuần, và số ngày lẻ trong tuần:
/*
    - input: số ngày nhập vào
    - process: 
        int soNgayCanTinh
        int soTuan = soNgayCantinh / 4
        int soNgayLe = soNgayCantinh % 4
    - output: in ra số ngày lẻ và số tuần
*/
Console.WriteLine("============ Bài 1 ==============");
Console.Write("Nhập số ngày cần tính: ");
string? soNgayCanTinh = Console.ReadLine();
int fomatSoNgayCanTinh = Convert.ToInt32(soNgayCanTinh);
Console.WriteLine($"Số tuần tính được:{fomatSoNgayCanTinh / 7}");
Console.WriteLine($"Số ngày lẻ tính được:{fomatSoNgayCanTinh % 7}");
#endregion
#region Bài 2: tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
/*
    -Input: Giá tiền ly trà sữa và % giảm giá
    -Process: long tienGiam = % giảm giá * giá tiền
              long soTienTra = giá triền ly trà sữa - tienGiam
    -Output: In ra số tiền giảm giá
             In ra số tiền phải trả sau khi giảm
*/
Console.Write("Nhập giá trị đơn hàng");
string defaultValueOrder = Console.ReadLine();
Console.Write("Nhập phần trăm giảm giá");
string discountPercent = Console.ReadLine();
int PriceDiscount = Convert.ToI(defaultValueOrder);
int PriceTotal = int.Parse(defaultValueOrder) - int.Parse(PriceDiscount);
// Console.WriteLine($"Số tiền giảm:{PriceDiscount}");
// Console.WriteLine($"Số tiền phải trả:{PriceTotal}");
// string number = "100";
// int result = int.Parse(number) + 50;  
// Console.WriteLine(result);
#endregion
