
Console.WriteLine("Chon bai tap: ");
int index = int.Parse(Console.ReadLine());
if (index == 1)
{
    Console.WriteLine("Cac so tu 1 den 100: ");
    for (int i=1; i<=100; i++)
        Console.WriteLine(i);
}
else if (index == 2)
{
    Console.WriteLine("Cac so chan tu 1 den n: ");
    Console.WriteLine("Nhap n: ");
    int n= int.Parse(Console.ReadLine());
    for (int i = 2; i <= n; i +=2)
    {
        Console.WriteLine(i);
    }
}
else if (index == 3)
{
    Console.WriteLine("Tong cac so tu 1 den n: ");
    Console.WriteLine("Nhap n: ");
    int n= int.Parse(Console.ReadLine());
    int s = 0;
    for (int i = 0; i <= n; i++)
    {
        s = s + i;
    }
    Console.WriteLine("Dap an: " + s);
}
else if (index == 4)
{
    Console.WriteLine("Bang cuu chuong cua n: ");
    Console.WriteLine("Nhap n: ");
    int n= int.Parse(Console.ReadLine());
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{i}x{n}={i*n}");
    }
}
else if (index == 5)
{
    Console.WriteLine("Giai thua cua n: ");
    Console.WriteLine("Nhap n: ");
    int n= int.Parse(Console.ReadLine());
    int r = 1;
    for (int i=1; i<=n; i++)
    {
        r = r * i;
    }
    Console.WriteLine("Ket qua: "+r);
}
else if (index == 6)
{
    Console.WriteLine("Tong day phan so 1/n: ");
    Console.WriteLine("Nhap n: ");
    int n= int.Parse(Console.ReadLine());
    int s = 0;
    for (int i = 1; i <= n; i++)
    {
         s = s + 1 / i;
    }
    Console.WriteLine("Ket qua: " + s);
}
else if (index == 7)
{
    Console.WriteLine("Day Fibonaci: ");
    Console.WriteLine("Nhap n: ");
    int n = int.Parse(Console.ReadLine());
    int f1 = 0;
    int f2 = 1;
    int f=1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(f +", ");
        f = f1 + f2;
        f1 = f2;
        f2 = f;
    }
    Console.Write("...7");
}
else if (index == 8)
{
    Console.WriteLine("Hinh chu nhat: ");
    Console.WriteLine("Nhap n: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            Console.Write("*");
        }
    }
}
else if (index == 9)
{
    Console.WriteLine("Tam giac vuong can: ");
    Console.WriteLine("Nhap h: ");
    int h = int.Parse(Console.ReadLine());
    int count;
    for (int i = 1; i <= h; i++)
    {
        count = i;
        while (count!=0)
        {
            Console.Write("*");
            count--;
        }
        Console.WriteLine();
    }
}
else if (index == 10)
{
    Console.WriteLine("Tam giac can: ");
    Console.WriteLine("Nhap h: ");
    int h = int.Parse(Console.ReadLine());
    int blank = (h*2-1)/2;
    
    
    for (int i = 1; i <= h; i++)
    {
        for (int j = 0; j < blank; j++)
        {
            Console.Write(" ");
        }

        for (int k = 0; k < (h*2-1-2*blank); k++)
        {
            Console.Write("*");
        }
        for (int j = 0; j < blank; j++)
        {
            Console.Write(" ");
        }
      
        blank--;
        Console.WriteLine();
    }
}
else Console.WriteLine("Khong co bai tap nay ");