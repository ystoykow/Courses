namespace GenericsExercise
{
    public class Tuple<T,K,U>
    {
        private T item1;
        private K item2;
        private U item3;

        public Tuple(T item1, K item2, U item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
