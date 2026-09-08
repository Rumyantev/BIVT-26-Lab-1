namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if  (Math.Abs(d) >= 1)
                {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if (((d+f) / 2) >0) { answer = true; }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a+b)>((Math.Abs(a) +Math.Abs(b)) / 2)) { answer = true; }

            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            int first = Math.Max(a, b);
            int second = Math.Max(b, c);
            { answer = Math.Max(first, second); }



            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double a = x * x;
            if (Math.Abs(x) <= 1) { answer = x * x - 1; }
            else
            { answer = 0; }


                // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n  <0) { answer = false; }
            else
                if (n%2 == 0 ) { answer = false; }
                    



                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            double wake = 14*60;
            double sleepstart = 4*60;
            bool tea = true;
            for (int day = 1; day < X; day++)
            {
                if (wake > 7*60) { wake = wake - 60; }
                if (tea == true) { sleepstart = sleepstart - Y; }
                if (tea == true)
                { tea = false; }
                else
                { tea = true; }
            }
            double hoursofsleep = (wake - sleepstart);
            bool wakeup = wake <= 7*60;
            bool sleeptime = hoursofsleep >=7 && hoursofsleep<=9;
            if ((wakeup == true) && (sleeptime == true)) { answer = true; }

                // end

                return answer;
        }
    }
}
