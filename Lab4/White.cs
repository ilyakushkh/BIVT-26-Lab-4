namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here

            // end

        }
        public void Task4(int[] array)
        {

            // code here

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here

            // end

        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
    {
        array = null;
    }
    else if (n == 1)
    {
        if (a == b)
            array = new double[] { a };
        else
            array = null;
    }
    else if (a == b)
    {
        array = null;
    }
    else
    {
        array = new double[n];
        double step = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            array[i] = a + i * step;
        }
    }

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
    {
        restored = null;
    }
    else
    {
        bool allDamaged = true;
        for (int i = 0; i < raw.Length; i++)
        {
            if (raw[i] != -1)
            {
                allDamaged = false;
                break;
            }
        }

        if (allDamaged)
        {
            restored = (double[])raw.Clone();
        }
        else
        {
            restored = (double[])raw.Clone();

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    int leftIndex = (i == 0) ? raw.Length - 1 : i - 1;
                    int rightIndex = (i == raw.Length - 1) ? 0 : i + 1;

                    double left = raw[leftIndex];
                    double right = raw[rightIndex];

                    if (left != -1 && right != -1)
                    {
                        restored[i] = (left + right) / 2.0;
                    }
                }
            }
        }
    }

            // end

            return restored;
        }
    }
}
