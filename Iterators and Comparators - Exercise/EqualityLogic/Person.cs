using System;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Age.GetHashCode();

            return hash;
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (person == null)
            {
                return false;
            }

            return person.Name == this.Name && person.Age == this.Age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Age != other.Age)
            {
                return this.Age.CompareTo(other.Age);
            }

            return 0;
        }
    }
}
