using System;
using System.Collections.Generic;
using System.Text;

namespace nonAccessModifiers.models
{
    class Car:Vehicle
    {
        public float DoorCount { get; set; }
        public float WindCode { get; set; }

        public override float AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
