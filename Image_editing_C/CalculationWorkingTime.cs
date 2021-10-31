using System;

namespace Image_editing_C
{
    internal class CalculationWorkingTime
    {
        public static void Main(string[] args)
        {
            CountWorkingTime(1001, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(1000, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(100, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(14, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(13, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(12, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(6, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(5, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(2, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(1, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(0, new Worker(2), new Worker(3), new Worker(4));
            CountWorkingTime(6, new Worker(2), new Worker(3));
            CountWorkingTime(9, new Worker(2));
        }

        public static void CountWorkingTime(int images, params Worker[] workers)

        {
            var minutes = 0;

            while (true)
            {
                var teamWork = 0;
                for (var i = 0; i < workers.Length; i++)
                    teamWork = (int) (teamWork + Math.Round((double) (minutes / workers[i].GetImageEditingTime())));
                if (teamWork >= images)
                {
                    Console.WriteLine(images + " images in " + minutes + " minutes are edited by " + workers.Length + " workers ");
                    break;
                }

                minutes++;
            }
        }
    }
}