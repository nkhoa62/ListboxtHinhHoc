using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Hoc
{
    class HinhTron : HinhHoc
    {
        const double pi = 3.14;
        private double R;

        public double chuvi;
        public double dientich;

        public double BanKinh
        {
            get { return R; }
            set { R = value; }
        }

        public HinhTron(){}
        public HinhTron(double R) 
        {
            this.R = R;
        }
        public void ChuVi()
        {
            chuvi = R * 2 * pi;
        }

        public void DienTich()
        {
            dientich = 2 * pi * (R * R);
        }

    }
}
