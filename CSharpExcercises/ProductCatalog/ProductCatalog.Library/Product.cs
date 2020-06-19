using System;

namespace ProductCatalog.Library
{
    public class Product
    {
        private double _price;
        // an "auto-implemented property" or just "auto-property"
        public double Price 
        { 
            get => _price; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "price can't be nonpositive.");
                }
                _price = value;
            } 
        }

        public string Color { get; set; }

        // the backing field for Name property
        private string _name;

        //"full property" - no hidden field, full control over validation etc.
        public string Name 
        {
            get { return _name;}
            set { _name = value;}
        }
       
       public void ApplyDiscount(int percentage)
       {
           double multiplier = 1 - percentage / 100.0; 
           Price *= multiplier;
       }
    }
}