using NUnit.Framework;

using Huiswerk5;

namespace Tests
{
    [TestFixture]
    public class Ex3PriorityQueueTests
    {
        [Test, Sequential]
        public void PriorityQueue_07_AddFreely(
            [Values(
                new int[] {1},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {8, 7, 6, 5, 4, 3, 2, 1},
                new int[] {2, 1, 3, 8, 4, 7, 6, 5}
            )] int[] sequence,
            [Values(
                "1",
                "1 2 3 4 5 6 7 8",
                "8 7 6 5 4 3 2 1",
                "2 1 3 8 4 7 6 5"
            )] string expected)
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();

            // Act
            foreach (int element in sequence)
                q.AddFreely(element);
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test, Sequential]
        public void PriorityQueue_08_BuildHeap(
            [Values(
                new int[] {1},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {8, 7, 6, 5, 4, 3, 2, 1},
                new int[] {2, 1, 3, 8, 4, 7, 6, 5},
                new int[] {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            )] int[] sequence,
            [Values(
                "1",
                "1 2 3 4 5 6 7 8",
                "1 4 2 5 8 3 6 7",
                "1 2 3 5 4 7 6 8",
                "1 2 6 3 10 8 7 4 12 11 19 9 15 18 14 5 13 17 20 16"
            )] string expected)
        {
            // Arrange
            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueEmpty();
            foreach (int element in sequence)
                q.AddFreely(element);

            // Act
            q.BuildHeap();
            string actual = q.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
