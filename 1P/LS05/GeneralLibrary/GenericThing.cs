using System;
namespace GeneralLibrary
{
    public class GenericThing<T> where T : IComparable
    {
        public T Data = default(T);
        public string Process (object input)
        {
            if(Data.CompareTo(input) == 0)
            {
                return "Data input are the same.";
            }
            else
            {
                return "Data input are NOT the same.";
            }
        }
    }
}