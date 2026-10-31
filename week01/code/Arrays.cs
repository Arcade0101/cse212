public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
                // TODO Problem 1 Start
        // Plan:
        // 1. Make a new double array with size 'length'.
        // 2. Loop through the array from start to finish.
        // 3. For each spot, multiply 'number' by (index + 1) to get the multiple.
        // 4. Save that result in the array.
        // 5. Hand back the finished array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Plan:
        // 1. Figure out how many items are in the list.
        // 2. Adjust the amount using modulo just in case it equals the list size.
        // 3. Grab the last 'amount' items (the tail) using GetRange.
        // 4. Remove those tail items from the end of the list.
        // 5. Insert those tail items right at the front (index 0) of the list.
        int count = data.Count;
        amount = amount % count;

        if (amount > 0)
        {
            List<int> tail = data.GetRange(count - amount, amount);
            data.RemoveRange(count - amount, amount);
            data.InsertRange(0, tail);
        }
    }
}
