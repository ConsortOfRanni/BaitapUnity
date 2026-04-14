    Console.WriteLine("Chon bai tap: ");
    
    int indexNumber = int.Parse(Console.ReadLine());
    
    //Bài 1:
    
    if (indexNumber == 1)
    {
        Console.WriteLine("Bai 1: ");
        Console.WriteLine("Nhap so nguyen n: ");
        int n =  int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Day la so chan!");
        }
        else Console.WriteLine("Day la so le!");
    }
    
    //Bài 2:
    
    else if (indexNumber == 2)
    {
        Console.WriteLine("Bai 2: ");
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("So lon hon la a: " + a);
        }
        else if (a < b)
        {
            Console.WriteLine("So lon hon la b: " + b);
        }
        else Console.WriteLine("Hai so bang nhau!");
    }
    
    //Bòi 3: 
    
    else if (indexNumber == 3)
    {
        Console.WriteLine("Bai 3: ");
        Console.WriteLine("Nhap so can kiem tra: ");
        double a = double.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("Day la so duong!");
        }
       else if (a == 0)
        {
            Console.WriteLine("Day la so 0!");
        }
        else Console.WriteLine("Day la so am!");
    }
    
    //Bài 4:
    
    else if (indexNumber == 4)
    {
        Console.WriteLine("Bai 4: ");
        Console.WriteLine("Nhap tuoi: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            if (a >= 18)
            {
                Console.WriteLine("Da du tuoi!");
            }
            else
            {
                Console.WriteLine("Chua du tuoi!");
            }
        }
        else  Console.WriteLine("Tuoi khong hop le!");
    }
    
    //Bài 5:
    
    else if (indexNumber == 5)
    {
        Console.WriteLine("Bai 5: ");
        Console.WriteLine("Nhap diem so: ");
        double a = double.Parse(Console.ReadLine());
        if (a >= 0 && a <= 10)
        {
            if (a >= 8)
            {
                Console.WriteLine("Diem gioi!");
            }
            else if (a >= 6.5)
            {
                Console.WriteLine("Diem kha!");
            }
            else if (a >= 5)
            {
                Console.WriteLine("Diem trung binh!");
            }
            else if (a < 5)
            {
                Console.WriteLine("Diem yeu!");
            }
        }
        else Console.WriteLine("Diem so khong hop le! ");
    }
    
    //Bài 6:
    
    else if (indexNumber == 6)
    {
        Console.WriteLine("Bai 6: ");
        Console.WriteLine("Nhap so dien (kWh):  ");
        double a = double.Parse(Console.ReadLine());
        if (a > 0)
        {
            if (a <= 50)
            {
                Console.WriteLine("Dien cua ban co gia 1.500d/kWh!");
                Console.WriteLine("Tien dien cua ban la: " + a * 1500 + " VND!");
            }
            else
            {
                Console.WriteLine("50 kWh dau cua ban co gia 1.500dd/kWh!");
                Console.WriteLine("Sau do dien cua ban co gia 2.000d/kWh! ");
                Console.WriteLine("Tien dien cua ban la: " + 50*1500+ (a-50) * 2000 + " VND!");
            }
        }
        else
        {
            Console.WriteLine("So lieu khong hop le!");
        }
    }
    //Bài 7:
    
    else if (indexNumber == 7)
    {
        Console.WriteLine("Bai 7: ");
        Console.WriteLine("Nhap nam: ");
        int year = int.Parse(Console.ReadLine());
        if (year > 0)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Day la nam nhuan!");
            }
            else Console.WriteLine("Day la nam khong nhuan!");
        }
        else Console.WriteLine("So lieu khong hop le!");
    }
    
    //Bài 8: 
    
    else if (indexNumber == 8)
    {
        Console.WriteLine("Bai 8: ");
        Console.WriteLine("Nhap so thu tu: ");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Thu hai!");
                break;
            case 2:
                Console.WriteLine("Thu ba!");
                break;
            case 3:
                Console.WriteLine("Thu tu!");
                break;
            case 4:
                Console.WriteLine("Thu nam!");
                break;
            case 5:
                Console.WriteLine("Thu sau!");
                break;
            case 6:
                Console.WriteLine("Thu bay!");
                break;
            case 7:
                Console.WriteLine("Chu nhat!");
                break;
            default:
                Console.WriteLine("So lieu khong hop le!");
                break;
        }
    }
    
    //Bài 9:
    
    else if (indexNumber == 9)
    {
        Console.WriteLine("Bai 9: ");
        Console.WriteLine("_____________MENU_____________ ");
        Console.WriteLine("1. Xem thong tin");
        Console.WriteLine("2. Cai dat");
        Console.WriteLine("3. Thoat");
        int a= int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Xem thong tin: ");
                break;
            case 2:
                Console.WriteLine("Cai dat: ");
                break;
            case 3:   
                Console.WriteLine("Thoat!");
                break;
              default: Console.WriteLine("Chuc nang khong hop le!");
                break;
        }
    }
    
    //Bài 10:
    
    else if (indexNumber == 10)
    {
        Console.WriteLine("Bai 10: ");
        Console.WriteLine("Phuong trinh bac 1: ax+b=0. ");
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Phuong trinh co vo so nghiem!");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem!");
        }
        else
        {
            Console.WriteLine("Phuong trinh co nghiem la: x= "+ -b/a );
        }
    }
    
    //Bài 11: 
    
    else if (indexNumber == 11)
    {
        Console.WriteLine("Bai 11: ");
        Console.WriteLine("Nhap chieu cao (m): ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap can nang (kg): ");
        double weight = double.Parse(Console.ReadLine());
        
        if (height > 0 && weight > 0)
        {
            double bmi = weight / (height * height);
            Console.WriteLine("Chi so BMI la: " + bmi);
            if (bmi<18.5)
            {
                Console.WriteLine("Gay!");
            }
            else if (bmi <25)
            {
                Console.WriteLine("Binh thuong!");
            }
            else if (bmi<30)
            {
                Console.WriteLine("Thua can!");
            }
            else
            {
                Console.WriteLine("Beo phi! ");
            }
        }
        else {Console.WriteLine("So lieu khong hop le!");}
    }
    
    else
    {
        Console.WriteLine("Khong co bai tap nay!");
    }
