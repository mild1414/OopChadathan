using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChadathan.cs
{
    internal abstract class Flower    //คลาสดอกไม้
    {
        private void smell() //กลิ่น
        {

        }
        public void Meaning()   //ความหมาย
        {

        }
        public void color()     //สี
        {

        }

    }

    class Rose : Flower  //คลาสดอกกุหลาบ
    {
        private void smell()
        {

        }
        public void Meaning()
        {
            Console.WriteLine("Rose means love"); //ดอกกุหลาบหมายถึงความรัก
        }


        public void color()
        {
            Console.WriteLine("Roses are red"); //ดอกกุหลาบมีสีแดง
        }
    }

    class Jasmine : Flower  //คลาสดอกมะลิ
    {
        private void smell()
        {

        }
        public void Meaning()
        {
            Console.WriteLine("Jasmine means people who worship the noble loved ones"); //ดอกมะลิ หมายถึงคนที่บูชา คนที่รัก ผู้สูงส่ง
        }
        public void color()
        {
            Console.WriteLine("Jasmine are white");  //ดอกมะลิมีสีขาว
        }
    }

    class Sunflower : Flower  //คลาสดอกทานตะวัน
    {
        private void smell()
        {

        }
        public void Meaning()
        {
            Console.WriteLine("Sunflower means the stability of the sun"); //ดอกทานตะวัน หมายถึงความมั่นคงดั่งดวงอาทิตย์
        }
        public void color()
        {
            Console.WriteLine("Sunflowers are yellow");  //ดอกทานตะวันมีสีเหลือง
        }
    }

    class Lotus : Flower  //คลาสดอกบัว
    {
        private void smell()
        {

        }
        public void Meaning()
        {
            Console.WriteLine("Lotus flower means faith Praiseworthy"); //ดอกบัว หมายถึงความศรัทธา ความน่ายกย่อง
        }
        public void color()
        {
            Console.WriteLine("Lotus are pink");  //ดอกบัวมีสีชมพู
        }
    }


}
