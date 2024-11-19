using Unity.Burst;
using Unity.Collections;

namespace bx2h.Collections
{
   [BurstCompile]
   public static class NativeArrayExtensions
   {
      /// <summary>
      /// NativeArray Extension Method: Reverses the array in place.
      /// Example usage:
      /// NativeArray<int> array = new NativeArray<int>(new int[] { 1, 2, 3, 4, 5 }, Allocator.Temp);
      /// array.Reverse();
      /// Debug.Log(array.ToArray()); // prints [5, 4, 3, 2, 1]
      /// </summary>
      /// <typeparam name="T">The type of the elements in the array.</typeparam>
      /// <param name="array">The array to reverse.</param>
      [BurstCompile]
      public static void Reverse<T>(this NativeArray<T> array) where T : struct
      {
         int length = array.Length;
         for (int i = 0; i < length / 2; i++)
         {
            (array[length - 1 - i], array[i]) = (array[i], array[length - 1 - i]);
         }
      }
   }
}
