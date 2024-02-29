using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LopHinhChuNhat
{
    public class Rectangle
    {
        double width, height; //nếu không khi public/private thì giá trị bảo vệ mặc định là private
        public Rectangle() //khởi tạo cách 1
        {
        }
        //một đối tượng có nhiều cách khởi tạo, có thể khai báo nhiều cách khởi tạo
        public Rectangle(double width, double height) //khởi tạo cách 2
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
            //return (width + height) * 2;
        }

        public string Display()
        {
            return "Rectangle " + "width = " + width + ", height = " + height;
        }
    }
}
