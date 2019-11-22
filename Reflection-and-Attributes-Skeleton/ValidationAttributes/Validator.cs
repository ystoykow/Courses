namespace ValidationAttributes
{
    using System.Linq;
    using System.Reflection;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propertyInfo = obj
                .GetType()
                .GetProperties();

            foreach (var property in propertyInfo)
            {
                MyValidationAttribute[] attributes =
                    property
                        .GetCustomAttributes()
                        .Where(a => a is MyValidationAttribute)
                        .Cast<MyValidationAttribute>()
                        .ToArray();

                foreach (var attribute in attributes)
                {
                    if (!attribute.isValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
