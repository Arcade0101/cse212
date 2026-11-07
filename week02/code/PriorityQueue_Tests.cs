using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities (Low=1, High=10, Medium=5) and dequeue them.
    // Expected Result: The items come out sorted by highest priority first: High, Medium, then Low.
    // Defect(s) Found: Before fixing PriorityQueue, the queue failed to check the last item and didn't remove items, so priority sorting failed.
    public void TestPriorityQueue_DifferentPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 10);
        priorityQueue.Enqueue("Medium", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items that share the exact same priority (Priority 5).
    // Expected Result: Items with equal priority are removed in FIFO (First-In, First-Out) order.
    // Defect(s) Found: Using '>=' instead of '>' in the loop would pick the newer item instead of keeping the first one added.
    public void TestPriorityQueue_EqualPrioritiesFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstIn", 5);
        priorityQueue.Enqueue("SecondIn", 5);
        priorityQueue.Enqueue("ThirdIn", 2);

        Assert.AreEqual("FirstIn", priorityQueue.Dequeue());
        Assert.AreEqual("SecondIn", priorityQueue.Dequeue());
        Assert.AreEqual("ThirdIn", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from a brand-new, empty priority queue.
    // Expected Result: Throws an InvalidOperationException with the exact message "The queue is empty."
    // Defect(s) Found: Verifies that the empty check correctly throws the required exception message.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}