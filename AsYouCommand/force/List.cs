using System;
namespace AsYouCommand
{
    class ListMaker
    {
        static void Main(string[] args)
        {
            int[] Command()
            {
                
                Console.WriteLine("How long do you want your list to be?");

                string LengthNumberList = Console.ReadLine();

                int Nr_1 = Int32.Parse(LengthNumberList);
                int[] list = new int[Nr_1];

                Console.WriteLine("Is there a limit to how big the numbers are allowed to be?");

                string maxNum = Console.ReadLine();

                int Nr_2 =  Int32.Parse(maxNum);



                Random num = new Random();
                

                int rnum = num.Next(0, Nr_2);

                for(int i = 0; i < Nr_2; i++)
                {
                    list[Nr_1] = new int{rnum};
                }

                

                return list;
            
            }
            
            Command();


        }
        
    }
    
}



            

            

        
            
        
    