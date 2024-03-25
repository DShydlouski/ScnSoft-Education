namespace LeetCodeTraining.ContainerWithMostWater
{
    public static class ContainerWithMostWaterSolution
    {
        public static int MaxArea(int[] height)
        {
            int max = 0;

            if (height != null)
            {
                int x = 0;
                int y = height.Length - 1;

                while (x < y)
                {
                    int leftLine = height[x];
                    int rightLine = height[y];

                    if (leftLine < rightLine)
                    {
                        max = Math.Max(max, leftLine * (y - x));
                        ++x;
                    }
                    else
                    {
                        max = Math.Max(max, rightLine * (y - x));
                        --y;
                    }

                }

            }

            return max;
        }
    }
}
