using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9 };
            int[] c = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

     
           
         
         
        
            RotatingArray(b, 3);
        }

        public static int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        public static double AverageArray(int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return (sum / nums.Length);
        }

        public static void ReverseArray(int [] nums)
        {
            int x = 0;
            int[] newArray = new int[nums.Length]; 
            for(int i = nums.Length-1; i >0; i--)
            {
                newArray[x] = nums[i];
                x++;
            }
            newArray[nums.Length - 1] = nums[0];

            foreach(int i in newArray)
            {
                Console.Write(i+"|");
            }
        }

        public static int MaximumArray(int[] nums)
        {
            int max = nums[0];
            foreach (int i in nums)
            {
                if (i > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static void RotatingArray(int[] nums, int rotation)
        {
            
            }



        public static void SortingArray(int[] nums)
        {
            //my sort
            //compare first num to last num
            //switch if necc
            //

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            foreach (int i in nums)
            {
                Console.Write(i + ",");
            }


        }
    }
}

