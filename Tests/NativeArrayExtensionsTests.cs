using NUnit.Framework;
using Unity.Collections;

namespace bx2h.Collections.Tests
{
   public class NativeArrayExtensionsTests
   {
      [Test]
      public void Reverse_EmptyArray_NoChange()
      {
         var array = new NativeArray<int>(0, Allocator.Temp);
         array.Reverse();
         Assert.AreEqual(0, array.Length);
         array.Dispose();
      }

      [Test]
      public void Reverse_SingleElement_NoChange()
      {
         var array = new NativeArray<int>(new int[] { 1 }, Allocator.Temp);
         array.Reverse();
         Assert.AreEqual(1, array[0]);
         array.Dispose();
      }

      [Test]
      public void Reverse_EvenNumberOfElements_CorrectlyReversed()
      {
         var array = new NativeArray<int>(new int[] { 1, 2, 3, 4 }, Allocator.Temp);
         array.Reverse();
         CollectionAssert.AreEqual(new int[] { 4, 3, 2, 1 }, array);
         array.Dispose();
      }

      [Test]
      public void Reverse_OddNumberOfElements_CorrectlyReversed()
      {
         var array = new NativeArray<int>(new int[] { 1, 2, 3, 4, 5 }, Allocator.Temp);
         array.Reverse();
         CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, array);
         array.Dispose();
      }

      [Test]
      public void Reverse_FloatArray_CorrectlyReversed()
      {
         var array = new NativeArray<float>(new float[] { 1.1f, 2.2f, 3.3f }, Allocator.Temp);
         array.Reverse();
         CollectionAssert.AreEqual(new float[] { 3.3f, 2.2f, 1.1f }, array);
         array.Dispose();
      }
   }
}
