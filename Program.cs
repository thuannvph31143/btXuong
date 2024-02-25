namespace btXuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SinhVienService service = new SinhVienService();

            int choice;

            do
            {
                Console.WriteLine(" 1 nhap danh sach doi tuong ");
                Console.WriteLine(" 2 xuat danh sach doi tuong");
                Console.WriteLine(" 3 xuat danh sach doi tuong >=8");
                Console.WriteLine(" 4 xoa doi tuong");
                Console.WriteLine(" 5 ke thua");
                Console.WriteLine("0 thoat");
                Console.WriteLine("xin moi lua chon:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.NdsDoiTuongYesNo();
                        break;
                    case 2:
                        service.XuatDsDoiTuong();
                        break;
                    case 3:
                        service.XuatDsSvDiemLonHon8();
                        break;
                    case 4:
                        service.XoaSv();
                        break;
                    case 5:
                        service.keThua();
                        break;
                    case 0:
                        break;
                    default: Console.WriteLine("ko co trong menu, moi nhsp lsi");
                        break;
                }
            } while (choice !=0);
        }
    }
}