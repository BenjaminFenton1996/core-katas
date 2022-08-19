using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas
{
    public static class BouncingBallKata
    {
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
