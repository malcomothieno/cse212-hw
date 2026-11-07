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
        // PLAN:
        // 1. Create a new array of doubles with a size equal to 'length'.
        //    This array will hold the multiples and will be returned at the end.
        // 2. Use a for loop with an index variable 'i' that starts at 0 and
        //    runs while 'i' is less than 'length' (so it visits every slot once).
        // 3. On each pass through the loop, the multiple for slot 'i' is
        //    'number' multiplied by (i + 1). We add 1 because the first
        //    multiple is number * 1, not number * 0.
        // 4. Store that value in the array at index 'i'.
        // 5. After the loop finishes, return the filled array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
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
        // PLAN:
        // 1. Rotating right by 'amount' means the LAST 'amount' items move to
        //    the front of the list, and everything else shifts to the right.
        // 2. Work out where the split happens: the index where the tail starts
        //    is data.Count - amount.
        // 3. Use GetRange(data.Count - amount, amount) to copy the last
        //    'amount' items into a new temporary list called 'tail'.
        // 4. Use RemoveRange(data.Count - amount, amount) to delete those same
        //    items from the end of the original list.
        // 5. Use InsertRange(0, tail) to put the saved items at the front of
        //    the original list. The remaining items automatically shift right.
        // 6. The function modifies 'data' in place, so nothing needs returning.
        //    (If amount == data.Count the whole list moves to the front, which
        //    leaves the list unchanged - exactly what a full rotation should do.)

        int splitIndex = data.Count - amount;

        List<int> tail = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, tail);
    }
}
