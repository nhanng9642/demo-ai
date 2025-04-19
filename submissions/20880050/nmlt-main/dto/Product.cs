using System;

namespace product_management.dto
{
    public class Product : Entity
    {
        public string CategoryId;
        public string Producer;
        public DateTime Mfg;
        public DateTime Exp;

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Category: {CategoryId} | Producer: {Producer} | Mfg: {Mfg.Date} | Exp: {Exp.Date}";
        }
    }
}
