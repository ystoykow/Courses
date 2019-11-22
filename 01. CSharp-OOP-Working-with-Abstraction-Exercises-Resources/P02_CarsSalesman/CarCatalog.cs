namespace P02_CarsSalesman
{
    using System.Collections;
    using System.Collections.Generic;

    public class CarCatalog : IEnumerable
    {
        private List<Car> cars;

        public CarCatalog()
        {
            this.cars= new List<Car>();
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                yield return cars[i];
            }
        }
    }
}
