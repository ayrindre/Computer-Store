using System;

namespace ComputerStore
{
    class Laptop
    {
        public string brand;
        protected string cpu ,model;
        protected int ram , hard;
        public void print()
        {
            System.Console.Write("What brand do you want? ( Dell - Hp - Mac ) : ");
            brand=Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            while (brand!="DELL"&& brand!="HP" && brand!="MAC")
            {
                System.Console.Write("Just one of these ---->> ( Dell - Hp - Mac ) : ");
                brand=Console.ReadLine().ToUpper();
                System.Console.WriteLine();
            }
            if (brand=="DELL")
            {
                LaptopDell d = new LaptopDell();
                System.Console.WriteLine("============================= stock =============================");
                System.Console.WriteLine();
                d.dell1();
                d.dell2();
            }else if (brand=="HP")
            {
                LaptopHp h = new LaptopHp();
                System.Console.WriteLine("============================= stock =============================");
                System.Console.WriteLine();
                h.Hp1();
                h.Hp2();
                h.Hp3();
            }else if (brand=="MAC")
            {
                LaptopMac m = new LaptopMac();
                System.Console.WriteLine("============================= stock =============================");
                System.Console.WriteLine();
                m.mac1();
                m.mac2();
            }
        }
    }
    class LaptopDell : Laptop
    {
        protected double weight;
        
        public void dell1()
        {
            model="latitude D620";
            cpu = "Core i2 Duo";
            ram=2;
            hard=160;
            weight = 2.5;
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" Dell - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} GB \n Weight: {4} Kg",model,cpu,ram,hard,weight);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
        public void dell2()
        {
            model="XPS 13";
            cpu = "Core i7";
            ram=16;
            hard=1;
            weight = 2.750;
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" Dell - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} TB \n Weight: {4} Kg",model,cpu,ram,hard,weight);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
    }
    class LaptopHp : Laptop
    {
        protected string Windows;
        public void Hp1()
        {
            model="10210U MX130";
            cpu = "Core i5";
            ram=8;
            hard=1;
            Windows = "10";
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" HP - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} TB \n Windows: {4} ",model,cpu,ram,hard,Windows);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
        public void Hp2()
        {
            model="10510U MX330";
            cpu = "Core i7";
            ram=16;
            hard=1;
            Windows = "7";
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" HP - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} TB \n Windows: {4} ",model,cpu,ram,hard,Windows);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
        public void Hp3()
        {
            model="1165G7 Iris Xe";
            cpu = "Core i7";
            ram=8;
            hard=320;
            Windows = "8";
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" HP - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} GB \n Windows: {4} ",model,cpu,ram,hard,Windows);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
    }
    class LaptopMac : Laptop
    {
        protected double screenSize;
        public void mac1()
        {
            model="Air MGND3 2020";
            cpu = "Apple M1 chip";
            ram=8;
            hard=256;
            screenSize = 13;
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" MacBook - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} GB \n screenSize: {4} inch",model,cpu,ram,hard,screenSize);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
        public void mac2()
        {
            model="Pro MYD82 2020";
            cpu = "Apple M1 chip";
            ram=8;
            hard=1;
            screenSize = 13;
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" Dell - Model {0}\n CUP:  {1} \n Ram: {2} GB \n Hard: {3} TB \n screenSize: {4} inch",model,cpu,ram,hard,screenSize);
            Console.ResetColor();
            System.Console.WriteLine("---------------------------------------");
        }
    }
}