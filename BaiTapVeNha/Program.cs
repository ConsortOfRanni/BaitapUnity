    Console.WriteLine("Chon bai tap");
    int n =Convert.ToInt32( Console.ReadLine());
    
    // Bài 1:
    
    if (n == 1)
    {
        Console.WriteLine("Nhap diem cac mon hoc: ");
        Console.WriteLine("Nhap diem mon Toan:");
        double math = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap diem mon Ly:");
        double physic = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap diem mon Hoa:");
        double chemistry = Convert.ToDouble(Console.ReadLine());
        
        if (math >= 0 && math <= 10 && physic >= 0 && physic <= 10 && chemistry >= 0 && chemistry <= 10)
        {
            double average = (math + physic + chemistry) / 3;
            Console.WriteLine($"Diem trung binh la: {average:F2}");
            if (average >= 8)
            {
                Console.WriteLine("Hoc luc gioi");
            }

            else if (average < 8 && average >= 6.5)
            {
                Console.WriteLine("Hoc luc kha");
            }

            else if (average < 6.5 && average >= 5)
            {
                Console.WriteLine("Hoc luc trung binh");
            }
            else
            {
                Console.WriteLine("Hoc luc yeu");
            }
        }
        else
        {
            Console.WriteLine("Diem so khong hop le!");
        }
    }

    // Bài 2:
    
    else if (n == 2)
    {
        Console.WriteLine("Nhap so tien USD can chuyen doi: ");
        decimal moneyUsd = decimal.Parse(Console.ReadLine());
        if (moneyUsd > 0)
        {
            decimal moneyVnd = moneyUsd * 25300;
            decimal fees = moneyVnd * 0.5m / 100m;
            Console.WriteLine($"So tien USD ban da nap: {moneyUsd}$");
            Console.WriteLine($"So tien Vnd tuong ung: {moneyVnd} VND");
            Console.WriteLine($"Phi chuyen khoan: {fees:N0} VND");
            Console.WriteLine($"Tong tien can tra: {(moneyVnd + fees):N0} Vnd");
        }
    
        else
        {
            Console.WriteLine("So tien khong hop le!");
        }
    }

    // Bài 3:
    
   else if (n == 3)
    {
        Console.WriteLine("Nhap lan luot thong tin 2 hinh chu nhat: ");
        Console.WriteLine("Hay nhap chieu dai hinh chu nhat dau tien: ");
        double length1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu rong hinh chu nhat dau tien: ");
        double width1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu dai hinh chu nhat thu hai: ");
        double length2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu rong hinh chu nhat thu hai: ");
        double width2 = double.Parse(Console.ReadLine());
        
        if (length1 > 0 && length2 > 0 && width1 > 0 && width2 > 0)
        {
            double area1 = length1 * width1;
            double area2 = length2 * width2;
            double perimeter1 = (length1 + width1) * 2;
            double perimeter2 = (length2 + width2) * 2;
            
            Console.WriteLine("Hinh chu nhat 1: ");
            Console.WriteLine($"Dien tich: {area1} m^2");
            Console.WriteLine($"Chu vi: {perimeter1} m");
            Console.WriteLine("Hinh chu nhat 2: ");
            Console.WriteLine($"Dien tich: {area2} m^2");
            Console.WriteLine($"Chu vi: {perimeter2} m");

            if (area1 > area2)
            {
                Console.WriteLine("Hinh chu nhat dau tien co dien tich lon hon!");
            }

           else if (area1 < area2)
            {
                Console.WriteLine("Hinh chu nhat thu hai co dien tich lon hon!");
            }
            else
            {
                Console.WriteLine("Hai hinh chu nhat co dien tich bang nhau!");
            }
        }
        else
        {
            Console.WriteLine("So lieu khong hop le!");
        }
    }
    else
    {
        Console.WriteLine("Khong co bai tap nay!");
    }