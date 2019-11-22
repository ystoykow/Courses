namespace ValidationAttributes
{
    using System;
    
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int maxValue;
        private int minValue;

        public MyRangeAttribute(int minValue , int maxValue)
        {
            this.maxValue = maxValue;
            this.minValue = minValue;
        }

        public override bool isValid(object obj)
        {
            int value = Convert.ToInt32(obj);
            if (value <= this.minValue || value >= this.maxValue)
            {
                return false;
            }

            return true;
        }
    }
}
