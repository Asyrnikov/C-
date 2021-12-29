using System;

    namespace LB_2
{
    class C<Param>
    {
        public static String value = "static";
        private Param val;

        public Param forParam
        {
            get { return val; }
            set { val = value; }
        }
    }
}
