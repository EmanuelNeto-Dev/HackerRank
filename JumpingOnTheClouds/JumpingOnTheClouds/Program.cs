using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] clouds, int sizeOfJump)
        {
            int energy = 100;
            int sPoint = 0;
            int fPoint = 0;

            while (energy > 0)
            {
                if (fPoint + sizeOfJump >= clouds.Length)
                {
                    fPoint = (sPoint + sizeOfJump) - clouds.Length;
                    sPoint = fPoint;
                }
                else
                {
                    fPoint = sPoint + sizeOfJump;
                    sPoint = fPoint;
                }

                if (fPoint == 0 && clouds[fPoint] == 1)
                {
                    energy = energy - 3;
                    break;
                }
                else if (fPoint == 0 && clouds[fPoint] == 0)
                {
                    energy = energy - 1;
                    break;
                }
                else if (clouds[fPoint] == 1)
                {
                    energy = energy - 3;
                }
                else
                {
                    energy = energy - 1;
                }

            }

            return energy;
        }

        static void Main(string[] args)
        {
            #region Test Cases

            /*
             * 
             * 8 2
             * 0 0 1 0 0 1 1 0
             * 
             * 10 3
             * 1 1 1 0 1 1 0 0 0 0
             * 
             */

            #endregion

            string[] nk = "10 3".Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] c = Array.ConvertAll("1 1 1 0 1 1 0 0 0 0".Split(' '), cTemp => Convert.ToInt32(cTemp));
            
            int result = jumpingOnClouds(c, k);

            Console.WriteLine(result);

            
        }
    }
}
