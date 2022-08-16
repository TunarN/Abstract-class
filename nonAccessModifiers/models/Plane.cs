using System;
using System.Collections.Generic;
using System.Text;

namespace nonAccessModifiers.models
{
    class Plane:Vehicle
    {
        public float WingLength { get; set; }

        public override float AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
