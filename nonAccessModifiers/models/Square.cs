using System;
using System.Collections.Generic;
using System.Text;

namespace nonAccessModifiers.models
{
    class Square : Figure
    {
       
        public Square(float side)
        {
            Side=side;
        }
        private float _side;
        public float  Side {
            get
            {
                return _side;
            }
            set
            {
                if (value>=0)
                {
                   _side=value;
                }
            }
        }
        public override float CalcArea()
        {
            return Side * Side;
        }
    }
}
