using System;

namespace DoAnNMLT
{
    class Product
    {
        public string productCode;
        public string productName;
        public string expiryDate;
        public string productOf;
        public ProductType productType;
        public string manufactureYear;

        public Product(string code, string name, string expiryTime, string producer, ProductType type, string yearOfManufacture)
        {
            productCode = code;
            productName = name;
            expiryDate = expiryTime;
            productOf = producer;
            productType = type;
            manufactureYear = yearOfManufacture;
        }
    }
}
