using System;

    namespace LB_2
    {
    class B : A
    {
        private float d;
        private float[] arr;
        public B(float D, float A, float B) : base(A, B)
        {
            d = D;
        }

        public B(float d, float a, float b, int coef) : this(d, a, b)
        {
            arr = new float[(int)a + coef];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = c2 * i;
            }
        }

        public void printArr()
        {
            int k = 0;
            foreach (int i in arr)
            {
                Console.WriteLine($"arr [{k++}]: {i}");
            }
        }
        public float c2
        {
            get 
            {
                switch(d)
                {
                    case 1:
                        d /= a + b;
                        break;
                    default:
                        d += a + b;
                        break;
                }
                return d;
            }
        }
    }
}
