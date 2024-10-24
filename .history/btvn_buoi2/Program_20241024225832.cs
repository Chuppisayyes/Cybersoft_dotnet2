using System.Text;

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
Console.WriteLine($"Số tuần tính được:{fomatSoNgayCanTinh / 7} tuần");
Console.WriteLine($"Số ngày lẻ tính được:{fomatSoNgayCanTinh % 7} ngày");
#endregion
#region Bài 2: tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
/*
    -Input: Giá tiền ly trà sữa và % giảm giá
    -Process: double PriceDiscount = % giảm giá * giá tiền
              double PriceTotal = giá triền ly trà sữa - tienGiam
    -Output: In ra số tiền giảm giá
             In ra số tiền phải trả sau khi giảm
*/
Console.WriteLine("============ Bài 2 ==============");
Console.Write("Nhập giá trị đơn hàng: ");
string? defaultValueOrder = Console.ReadLine();
Console.Write("Nhập phần trăm giảm giá: ");
string? discountPercent = Console.ReadLine();
double PriceDiscount = Convert.ToDouble(defaultValueOrder) * Convert.ToDouble(discountPercent) / 100;
double PriceTotal = Convert.ToDouble(defaultValueOrder) - Convert.ToDouble(PriceDiscount);
Console.WriteLine($"Số tiền giảm giá: {PriceDiscount}");
Console.WriteLine($"Số tiền phải trả: {PriceTotal}");
#endregion
#region Bài 3: Chuyển đổi thời gian từ phút sang giờ và phút
/*
    - input: số phút nhập vào
    - process:
        int soPhutCanTinh
        int soGio = soNgayCantinh / 4
        int soPhutLe = soNgayCantinh % 4
    - output: in ra số ngày lẻ và số tuần
*/
Console.WriteLine("============ Bài 3 ==============");
Console.Write("Nhập số phút cần tính: ");
string? soPhutCanTinh = Console.ReadLine();
int fomatSoPhutCanTinh = Convert.ToInt32(soPhutCanTinh);
Console.WriteLine($"Số giờ tính được: {fomatSoPhutCanTinh / 60} giờ");
Console.WriteLine($"Số phút tính được: {fomatSoPhutCanTinh % 60} phút");
#endregion

#region Bài 4: Tính tổng số tiền thuế sau khi cộng thêm thuế VAT
/*
    - input: số tiền gốc và tỷ lệ thuế VAT
    - process:
        double soTienGoc
        double thueVAT
        double tongTien = soTienGoc + (soTienGoc*thueVAT)
    - output: in ra tổng tiền
*/
Console.WriteLine("============ Bài 4 ==============");
Console.Write("Nhập số tiền gốc: ");
string? soTienGoc = Console.ReadLine();
Console.Write("Nhập tỷ lệ thuế VAT: ");
string? thueVAT = Console.ReadLine();
double fomatSoTienGoc= Convert.ToDouble(soTienGoc);
double fomatThueVAT= Convert.ToDouble(thueVAT);
Console.WriteLine($"Số tiền sau thi cộng thuế VAT: {fomatSoTienGoc + (fomatSoTienGoc * fomatThueVAT)}");
#endregion

#region Bài 5: Chuyển đổi đơn vị tiền tệ 
/*
    - input: nhập vào số tiền USD và tỷ giá chuyển đổi giữa USD và VND
    - process:
        double soUSD
        double tyGiaUV
        double soVND = soUSD * tyGiaUV
    - output: số tiền VND sau khi chuyển đổi từ USD sang VND
        
*/
Console.WriteLine("============ Bài 5 ==============");
Console.Write("Nhập số USD: ");
string? soUSD = Console.ReadLine();
Console.Write("Nhập tỷ giá giá VND/USD: ");
string? tyGiaUV = Console.ReadLine();
double fomatSoUSD= Convert.ToDouble(soUSD);
double fomatTyGiaUV= Convert.ToDouble(tyGiaUV);
Console.WriteLine($"Số tiền sau thi cộng thuế VAT: {fomatSo + (fomatSoTienGoc * fomatThueVAT)}");
#endregion