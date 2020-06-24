using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctClassOrderProcessing
{
    public abstract class PaymentType
    {
        public abstract string TypeOfTask();
    }

    public class PhysicalProduct : PaymentType
    {
        public override string TypeOfTask()
        {
            return "Generate packing slip for shipping";
        }
    }
}
