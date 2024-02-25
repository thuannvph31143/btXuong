using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btXuong
{
    internal class SinhVienService
    {
        private List<SinhVien> lstsv;

        public SinhVienService()
        {

        }

        public void NdsDoiTuong()
        { SinhVien sinhVien = new SinhVien();
            Console.WriteLine(" moi ban nhap ma : ");
            sinhVien.MaSinhVien = Console.ReadLine();
            Console.WriteLine(" moi ban nhap ten: ");
            sinhVien.Ten = Console.ReadLine();
            Console.WriteLine(" moi ban nhap nam sinh: ");
            sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moi ban nhap diem :");
            sinhVien.Diem = Convert.ToDouble(Console.ReadLine());

            lstsv.Add(sinhVien);

            Console.WriteLine("them thanh cong");

        }

        public void NdsDoiTuongYesNo()
        {
            string yesno = "N";
            do
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine(" moi ban nhap ma : ");
                sinhVien.MaSinhVien = Console.ReadLine();
                Console.WriteLine(" moi ban nhap ten: ");
                sinhVien.Ten = Console.ReadLine();
                Console.WriteLine(" moi ban nhap nam sinh: ");
                sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("moi ban nhap diem :");
                sinhVien.Diem = Convert.ToDouble(Console.ReadLine());

                lstsv.Add(sinhVien);

                Console.WriteLine("them thanh cong");
                Console.WriteLine(" ban muon tiep tuc ko ?(ko thi hay an N/ tiep tuc thi an phim khac) ");
                yesno = Console.ReadLine();
                

            } while (yesno != "N");
        }
        public void XuatDsDoiTuong()
        {
            foreach (var sv in lstsv)
            {
                sv.InThongTin();
            }

        }

        public void XuatDsSvDiemLonHon8()
        {
            bool isfound =false;

            foreach (var sv in lstsv)
            {
                if(sv.Diem >= 8)
                {
                    sv.InThongTin();
                    isfound = true;
                    Console.WriteLine(" dc ve vip HappyBee");
                }
                if (isfound== false)
                {
                    Console.WriteLine(" ko dc ve vip HappyBee ");
                }
            }   

        }

        public void XoaSv()
        {
            SinhVien xsv = new SinhVien();
            foreach (var sv in lstsv)
            {
                if (xsv.NamSinh > 25)
                {
                    
                    xsv = sv;
                }
            }
            
            lstsv.Remove(xsv);
            Console.WriteLine("Xóa thành công");

        }

        public void keThua()
        {
            SinhVienUD sinhVienUD;
            sinhVienUD = new SinhVienUD();
            sinhVienUD.InThongTin();
        }
    }
}
