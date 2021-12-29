using System;

namespace LB_2
{
    public class A
    {
        protected float a;
        protected float b;

        public A(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float getSetA
        {
            get 
            {
                return a; 
            }
            set
            {
                a = value;
            }
        }

        public float getSetB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public float c
        {
            get { return (a + b);}
        }
    }
}
