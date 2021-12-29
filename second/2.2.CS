using System;

namespace LB_2
{
    class B : A
    {
        float d = 19.4;

        public B(float d, float A, float B) : base(A,B)
        {
            this.d = d;
        }

        public float c2
        {
            get 
            {
                switch(d)
                {
                    case 1:
                        d /= c;
                        break;
                    default:
                        d += c;
                        break;
                }
                return d;
            }
        }
    }
}
