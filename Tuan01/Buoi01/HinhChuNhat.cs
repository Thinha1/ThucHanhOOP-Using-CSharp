using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01
{
    class HinhChuNhat
    {
        private double chieuDai;
        private double chieuRong;

        public double ChieuDai
        {
            get
            {
                return chieuDai;
            }
            set
            {
                if (value > 0)
                    chieuDai = value;
                else chieuDai = 1;
            }
        }
        public double ChieuRong
        {
            get
            {
                return chieuRong;
            }
            set
            {
                if (value > 0)
                    chieuRong = value;
                else chieuRong = 1;
            }
        }
        public HinhChuNhat()
        {
            
        }
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }
        public HinhChuNhat(HinhChuNhat hcn1)
        {
            ChieuDai = hcn1.ChieuDai;
            ChieuRong = hcn1.ChieuRong;
        }
        public double tinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }
        public double tinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public double tinhDuongCheo()
        {
            return Math.Sqrt(ChieuDai * ChieuDai + ChieuRong * ChieuRong);
        }
        public void nhapTT()
        {
            Console.Write("Nhập chiều dài: ");
            ChieuDai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            ChieuRong = double.Parse(Console.ReadLine());
        }
        public void changeSize(int tx, int ty, int kieu) 
        {
            if (kieu == 1) 
            { 
                ChieuDai += tx;
                ChieuRong += ty;
            }
            else if(kieu == 0)
            {
                ChieuDai -= tx;
                ChieuRong -= ty;
            }
        }

        public void changeSize(HinhChuNhat a, int kieu)
        {
            if (kieu == 1)
            {
                ChieuDai += a.ChieuDai;
                ChieuRong += a.ChieuRong;
            }
            else if (kieu == 0)
            {
                ChieuDai -= a.ChieuDai;
                ChieuRong -= a.ChieuRong;
            }
        }

        public void xuatTT()
        {
            Console.WriteLine($"Chiều dài : {ChieuDai}\nChiều rộng: {ChieuRong}" +
                $"\nChu vi: {tinhChuVi()}\nDiện tích: {tinhDienTich()}\nĐộ dài dường chéo: {tinhDuongCheo()}");
        }
    }
}
