using System;
using System.Linq;
namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            string temp = num.ToString();
            int value = 1;
            for (int i = 0; i < temp.Length; i++)
            {
                value *= int.Parse(temp[i].ToString());
            }
            return value;
        }

        
    }
}
