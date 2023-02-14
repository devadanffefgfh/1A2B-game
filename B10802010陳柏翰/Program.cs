using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10802010陳柏翰
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random one_rand = new Random();
            
            
            Console.WriteLine("1A2B數字遊戲");
            
           
            int one = one_rand.Next(0, 10);
            Random two_rand = new Random();
           
            int two = two_rand.Next(0, 10);
            while(one==two)
            {
                two = two_rand.Next(0, 10);
            }
            Random three_rand = new Random();
            int three = three_rand.Next(0, 10);
            while (one == three ||two==three)
            {
                three = three_rand.Next(0, 10);
            }
            Random four_rand = new Random();
            int four = four_rand.Next(0, 10);
            while (one == four || two == four || three==four)
            {
                four = four_rand.Next(0, 10);
            }

           
            Console.WriteLine($"{one},{two},{three},{four}");
            
            bool play = true;
            int b = 0;
            int a = 0;
            while(play==true)
            {
                Console.Write("請輸入4個數字:");
                string player_numbers = Console.ReadLine();



                if (player_numbers.Contains(one.ToString())==true&& Int32.Parse(player_numbers[0].ToString()) != one)
                {
                    b++;
                    
                }
                if (player_numbers.Contains(two.ToString()) == true && Int32.Parse(player_numbers[1].ToString()) != two)
                {
                    b++;
                }
                if (player_numbers.Contains(three.ToString()) == true && Int32.Parse(player_numbers[2].ToString()) != three)
                {
                    b++;
                }
                if (player_numbers.Contains(four.ToString()) == true && Int32.Parse(player_numbers[3].ToString()) != four)
                {
                    b++;
                }

                if (player_numbers.Contains(one.ToString()) == true && Int32.Parse(player_numbers[0].ToString()) == one)
                {
                    a++;

                }
                if (player_numbers.Contains(two.ToString()) == true && Int32.Parse(player_numbers[1].ToString()) == two)
                {
                    a++;
                }
                if (player_numbers.Contains(three.ToString()) == true && Int32.Parse(player_numbers[2].ToString()) == three)
                {
                    a++;
                }
                if (player_numbers.Contains(four.ToString()) == true && Int32.Parse(player_numbers[3].ToString()) == four)
                {
                    a++;
                }
                Console.WriteLine($"{a}A{b}B");
                if (a==4&&b==0)
                {
                    Console.WriteLine($"你猜對了，遊戲結束");
                    play = false;
                }
                a = 0;
                b = 0;
                /*
                if (Int32.Parse(player_numbers[0].ToString()) == one&&Int32.Parse(player_numbers[1].ToString()) == two&&Int32.Parse(player_numbers[2].ToString()) == three&& Int32.Parse(player_numbers[3].ToString()) == four)
                {

                    Console.WriteLine("4A0B");
                    
                }
                else if(Int32.Parse(player_numbers[0].ToString()) == one && Int32.Parse(player_numbers[1].ToString()) != two && Int32.Parse(player_numbers[2].ToString()) == three && Int32.Parse(player_numbers[3].ToString()) == four)
                 {
                     Console.WriteLine("3A0B");
                }
                else if (Int32.Parse(player_numbers[0].ToString()) == one && Int32.Parse(player_numbers[1].ToString()) != two && Int32.Parse(player_numbers[2].ToString()) != three && Int32.Parse(player_numbers[3].ToString()) == four)
                {
                     Console.WriteLine("2A0B");
                }
                else if (Int32.Parse(player_numbers[0].ToString()) == one && Int32.Parse(player_numbers[1].ToString()) != two && Int32.Parse(player_numbers[2].ToString()) != three && Int32.Parse(player_numbers[3].ToString()) != four)
                {
                     Console.WriteLine("1A0B");
                }
                else if (Int32.Parse(player_numbers[0].ToString()) != one && Int32.Parse(player_numbers[1].ToString()) != two && Int32.Parse(player_numbers[2].ToString()) != three && Int32.Parse(player_numbers[3].ToString()) == four)
                {

                }
                else if (Int32.Parse(player_numbers[0].ToString()) == one && Int32.Parse(player_numbers[1].ToString()) == two && Int32.Parse(player_numbers[2].ToString()) != three && Int32.Parse(player_numbers[3].ToString()) == four)
                {

                }
                else if (Int32.Parse(player_numbers[0].ToString()) == one && Int32.Parse(player_numbers[1].ToString()) == two && Int32.Parse(player_numbers[2].ToString()) == three && Int32.Parse(player_numbers[3].ToString()) != four)
                {

                }

                else if (Int32.Parse(player_numbers[0].ToString()) != one && Int32.Parse(player_numbers[1].ToString()) != two && Int32.Parse(player_numbers[2].ToString()) != three && Int32.Parse(player_numbers[3].ToString()) != four)
                {
                    Console.WriteLine("0A0B");
                }
                
                */




            }








         

          
          
            
            Console.ReadKey();
        }
    }
}
