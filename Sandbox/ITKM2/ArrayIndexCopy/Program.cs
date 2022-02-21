using System;

namespace ArrayIndexCopy
{
    class Program
    {
        static T[] ArrayIndexCopy<T>(T[] sourceArray, int startIndex, int endIndex)
            where T : notnull
        {
            T[] destination = new T[endIndex - startIndex + 1];

            for (int sourceArrayIndex = startIndex, destinationArrayIndex = 0; sourceArrayIndex <= endIndex; sourceArrayIndex++, destinationArrayIndex++)
            {
                destination[destinationArrayIndex] = sourceArray[sourceArrayIndex];
            }
            return destination;
        }
        static void Main()
        {
            string[] source = new string[] { "3", "2", "44", "5", "12" };
            string[] destination = ArrayIndexCopy(source, 2, 4);
            Console.WriteLine(string.Join(", ", destination));
            //ToDo - abstract array type
        }
    }
}
