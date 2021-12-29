using System;

    namespace LB_2
{
    class B : A
    {
        private float d;
        private float[] arr;
        private float[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
        private float cTwo;

        public static bool operator | (B objA, B objB)
        {
            if (objA == objB)
                return true;
            return false;
        }
        public static bool operator false(B obj)
        {
            if(obj.d >= 0)
                return false;
            return true;
        }

        public static bool operator true(B obj)
        {
            if (obj.d <= 0)
                return true;
            return false;
        }

        public float this[int ind1, int ind2]
        {
            get { return array[ind1, ind2]; }
            set { array[ind1, ind2] = value; }
        }
        public float this[int ind1]
        {
            get { return arr[ind1]; }
            set { arr[ind1] = value; }
        }


        public B(float D, float A, float B) : base(A, B)
        {
            d = D;
            cTwo = c2;
        }

        public B(float d, float a, float b, int coef) : this(d, a, b)
        {
            arr = new float[(int)a];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = cTwo * i;
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
