using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btXuong
{
    internal class SinhVienUD:SinhVien
    {
        private int kiHoc;

        public SinhVienUD()
        {
            
        }

        public SinhVienUD(int kiHoc)
        {
            this.kiHoc = kiHoc;
        }

        public int KiHoc { get => kiHoc; set => kiHoc = value; }

        public void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Kì học: {kiHoc}");
        }
    }
}
