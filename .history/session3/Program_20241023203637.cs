#region if-else statements
// Nhập số nguyên từ bàn phím. In ra số đó là số lẻ hay số chẵn
// Input
// using System.Text;

// Console.OutputEncoding = Encoding.UTF8;
// string? number = Console.ReadLine();
// // int formatNumber = Convert.ToInt32(number);
// int formatNumber = 2 ;
// if (formatNumber % 2 == 0)
// {
//     Console.WriteLine($"Số {number} là số chẵn");
// }
// else
// {
//     Console.WriteLine($"Số {number} là số lẻ");
// }

#endregion

#region 
// nhập điểm trung bình của học sinh. Xuất ra học lực của học sinh đó
// >=9: Xuất sắc
// 8 <= điểm < 9: giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm <6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém

// Console.WriteLine("Nhập điểm trung bình");
// string diemTB = Console.ReadLine();
// // string diemTB = null;
// // diemTB ??= "Vui lòng nhập lại !";
// // Console.WriteLine(diemTB);
// // Console.WriteLine("diemTB" + diemTB);
// if (diemTB != "")
// {
//     double fomatDiemTB = Convert.ToDouble(diemTB);
//     if (fomatDiemTB >= 9)
//     {
//         Console.WriteLine("Xuất sắc");
//     }
//     else if (fomatDiemTB >= 8 && fomatDiemTB <= 9)
//     {
//         Console.WriteLine("Giỏi");
//     }
//     else if (fomatDiemTB >= 6.5 && fomatDiemTB < 8)
//     {
//         Console.WriteLine("Khá");
//     }
//     else if (fomatDiemTB >= 5 && fomatDiemTB < 6.5)
//     {
//         Console.WriteLine("Khá");
//     }
//     else if (fomatDiemTB >= 3.5 && fomatDiemTB < 5)
//     {
//         Console.WriteLine("Yếu");
//     }
//     else
//     {
//         Console.WriteLine("Kém");
//     }
// }
// else
// {
//     diemTB = null;
//     diemTB ??= "Vui lòng nhập lại !";
//     Console.WriteLine(diemTB);
// }
#endregion

#region
Console.WriteLine("Nhập số cóa 3 chữ số:");
string? number = Console.ReadLine();
int fomatNumber = Convert.ToInt32(number); 
if (fomatNumber >= 100 && fomatNumber <= 1000){
    int a = (fomatNumber%100);
    int b = (fomatNumber/100)/10;
    int c = (fomatNumber%100)%10;
    int result = a+b+c;
    Console.WriteLine($"Result = {b} ");
}
#endregion