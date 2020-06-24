using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctClassOrderProcessing
{
    public abstract class PaymentType
    {
        public abstract void TypeOfTask();
    }

    public class PhysicalProduct : PaymentType
    {
        public override void TypeOfTask()
        {
            Console.WriteLine("Generate packing slip for shipping");
        }
    }
}
