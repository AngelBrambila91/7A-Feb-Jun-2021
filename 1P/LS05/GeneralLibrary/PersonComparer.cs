using System.Collections.Generic;

namespace GeneralLibrary
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Compare Name Lengths
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if(result == 0)
            {
                // Then compare by names
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return result;
            }
        }
    }
}