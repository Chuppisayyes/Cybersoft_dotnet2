﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Học phép toán cơ bản
// học +, -, *, / (Chia lấy phần nguyên), % (chia lấy phần dư)
// khai báo biến
// int a = 1 + 1;
// Console.WriteLine($"kết quả cộng 2 số 1 và 1 là: {a}");

// int minus = 123 - 45;
// Console.WriteLine($"kết quả trừ 2 số 123 và 45 là: {minus}");

// double devided = 5 / 2;
// Console.WriteLine($"kết quả chia 2 số 5 và 2 lấy phần nguyên là: {devided}");

// double devided2 = 5 % 2;
// Console.WriteLine($"kết quả chia 2 số 5 và 2 lấy phần dư là: {devided2}");
#endregion


#region numberic toán tử
// int cong = 0; // Định nghĩa biến cộng có giá trị mặc định là 0
// cong +=10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");

// int nhan = 1;
// nhan *= 100;
// Console.WriteLine($"Numberic toán tử nhân: {nhan}");
#endregion

#region 
// Convert
// Nhập dữ liệu từ bàn phím => ReadLine (string)
// string? number = Console.ReadLine();
// int converNumber = Convert.ToInt32(number);
// Console.WriteLine($"ValueNumber: {converNumber}");
#endregion


#region Tính chỉ số BMI
/* Input: Chiều cao và cân nặng được nhập từ bàn phím
 * Output: In ra mức chỉ số BMI và chú thích về giới tính
 * BMI = Cân nặng / (Chiều cao * Chiều cao)
 * BMI < 18.5 => Giới tính: Nam
 * 18.5 <= BMI < 25 => Giới tính: Nữ
 * BMI >= 25 => Giới tính: Nam giới tình
*/
// Console.WriteLine("Mời bạn nhập chiều cao (m)");
// string? height = Console.ReadLine();
// Console.WriteLine("Mời bạn nhập cân nặng (kg)");
// string? weight = Console.ReadLine();

// double BMI = Convert.ToDouble(weight) /(Convert.ToDouble(height)*Convert.ToDouble(height));
// if (BMI < 18.5){
//     Console.WriteLine($"Chỉ số BMI: {BMI} - Giới tính: Nam");    
// } else if( BMI >= 18.5 && BMI <= 25){
//     Console.WriteLine($"Chỉ số BMI: {BMI} - Giới tính: Nữ");    
// } else{
//     Console.WriteLine($"Chỉ số BMI: {BMI} - Something is wrong");    
// }
#endregion


#region
/*
    input: nhập vào bán kính
    output: in ra chu vi và diện tích hình tròn
    process: chu vi: 2 pi bán kính
             diện tích: pi * bán kính^2
*/
Console.WriteLine("Mời bạn nhập bán kính hình tròn");
string? r = Console.ReadLine();

double pi = Math.PI; 
Console.WriteLine($"Chu vi hình tròn là: P = {2*pi*Convert.ToDouble(r)}");
Console.WriteLine($"Diện tích hình tròn là: S = {pi*Math.Pow(Convert.ToDouble(r),2)}");

#endregion