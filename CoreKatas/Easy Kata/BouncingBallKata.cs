using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas
{
    public static class BouncingBallKata
    {
        /// <summary>
        /// Count the number of times a ball can be seen through a window when dropped from a certain height, including when the ball is rebounding and falling
        /// </summary>
        /// <param name="height">Height to drop the ball from, must be greater than 0 and greater than the window height</param>
        /// <param name="bounce">Factor determining how high ball rebounds, with 0 meaning no bouncing and 1 meaning never losing height on bounces</param>
        /// <param name="windowHeight">Height of the window, if the ball bounces above this height then it can be seen</param>
        /// <returns></returns>
        public static int BouncingBall(double height, double bounce, double windowHeight)
        {
            if (height <= 0 || bounce <= 0 || bounce >= 1 || windowHeight >= height)
            {
                return -1;
            }

            int visibleCount = 1;
            while (height > windowHeight)
            {
                height *= bounce;
                if (height > windowHeight)
                {
                    visibleCount += 2;
                }
            }

            return visibleCount;
        }
    }
}
