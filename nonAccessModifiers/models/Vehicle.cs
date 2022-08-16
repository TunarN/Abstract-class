using System;
using System.Collections.Generic;
using System.Text;

namespace nonAccessModifiers.models
{
    abstract class Vehicle
    {
        public float DrivePath { get; set; }
        public float DriveTime { get; set; }
        public abstract float AvarageSpeed();


    }
    interface IEngine 
    {
        public int HorsePower { get; set; }
        public float TankSize { get; set; }
        public float CurrentOil { get; set; }
        public float FullType { get; set; }
        public float RemainOilAmount();
    }
    interface IWhell
    {
        public float WhellThickness { get; set; }
    }
    interface ITransmission
    {
        public float TransmissonKind { get; set; }
    }


}
