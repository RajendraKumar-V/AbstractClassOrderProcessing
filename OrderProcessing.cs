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

    public class Book : PaymentType
    {
        public override string TypeOfTask()
        {
            return "Create a duplicate packing slip for the royality department";
        }
    }

    public class Membership : PaymentType
    {
        public override string TypeOfTask()
        {
            return "activate that membership";
        }
    }

    public class UpgradeMembershipp : PaymentType
    {
        public override string TypeOfTask()
        {
            return "upgarde to membership";
        }
    }

    public class MembershipOrUpgrade : PaymentType
    {
        public override string TypeOfTask()
        {
            return "email the owner and inform them";
        }
    }

    public class Video : PaymentType
    {
        public override string TypeOfTask()
        {
            return "add a free first aid video";
        }
    }
}
