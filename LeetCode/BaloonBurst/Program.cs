using System;

namespace BaloonBurst {
    class Program {
        static void Main (string[] args) {
            int[] arr = {3,1,5,8};

            Console.WriteLine(maxCoins(arr));
        }

        public static  int maxCoinUtil(int [] nums, int i, bool[] busted)
        {
            // breaking condition
            if(i== nums.Length)
            {
                return 0;
            }

            // not including
            int x = maxCoinUtil(nums, i+1, busted);

            // including i
            int val =GetValueafterBurst(nums, i, busted);
            busted[i]= true;
            int y =  val+maxCoinUtil(nums, i+1, busted);

            return Math.Max(x,y);

        }

        private static int GetValueafterBurst(int[] nums, int i, bool[] busted)
        {
            int val = nums[i];
            int left= i-1;
            while(left>=0)
            {
                if(busted[left]== false)
                {
                    break;
                }
                left--;
            }

            if(left>=0)
            {
                val*=nums[left];
            }

            int right= i+1;

            while(right<nums.Length)
            {
                if(busted[right]== false)
                {
                    break;
                }
                right++;
            } 

            if(right<nums.Length)
            {
                val*=nums[right];
            }

            return val;

        }

        public static int maxCoins (int[] nums) {
            
            bool[] busted = new bool[nums.Length];
            for(int i=0; i< nums.Length;i++)
            {
                busted[i]= false;
            }

            return maxCoinUtil(nums, 0, busted);
        }
    }
}