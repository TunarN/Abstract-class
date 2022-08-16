using System;
using System.Collections.Generic;
using System.Text;

namespace nonAccessModifiers.models
{
    class Bicycle:Vehicle
    {
        public float PedalKind { get; set; }

        public override float AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
