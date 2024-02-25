using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btXuong
{
    internal class SinhVien
    {
        private string maSinhVien;
        private string ten;
        private int namSinh;
        private double diem;
        public SinhVien()
        {
            
        }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.maSinhVien = maSinhVien;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{maSinhVien}|{ten}|{namSinh}|{diem}");
        }
    }
}
