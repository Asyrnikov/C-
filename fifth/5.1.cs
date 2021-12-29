using System;

amespace LB_2
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

    public float c
        {
            get { return (a + b);}
        }
    }
}
