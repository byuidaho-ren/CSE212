using System.Diagnostics;


public static class Arrays
{
    // Run
    public static void Run() 
    {
        // TEST MultiplesOf
        var multiples = Arrays.MultiplesOf(3, 5);
        Console.WriteLine("MultiplesOf(3,5): " + string.Join(", ", multiples));

        // TEST RotateListRight
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Before Rotate: " + string.Join(", ", list));

        Arrays.RotateListRight(list, 3);

        Console.WriteLine("After Rotate: " + string.Join(", ", list));
    }

    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    // public static double[] MultiplesOf(double number, int length)
    // {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    //    return []; // replace this return statement with your own
    // }

    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array of doubles with the specified size (length)
        // This will store all the multiples we generate
        double[] result = new double[length];

        // Loop from 0 to length - 1
        // Each iteration fills one position in the array
        for (int i = 0; i < length; i++)
        {
            // i starts at 0, but we want multiples starting at 1
            // So we use (i + 1) to get: 1, 2, 3, ..., length

            // Multiply the base number by (i + 1)
            // Example: if number = 3
            // i = 0 → 3 * 1 = 3
            // i = 1 → 3 * 2 = 6
            // i = 2 → 3 * 3 = 9
            result[i] = number * (i + 1);
        }

        // Return the completed array of multiples
        return result;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    // public static void RotateListRight(List<int> data, int amount)
    // {
        
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    // }


    public static void RotateListRight(List<int> data, int amount)
    {
        // STEP 1: Find the index where the list should be split
        // If we rotate right by 'amount', the last 'amount' elements move to the front
        int splitIndex = data.Count - amount;

        // STEP 2: Extract the right part of the list (the elements that move to the front)
        // Example: if data = [1,2,3,4,5,6,7,8,9] and amount = 3
        // rightPart = [7,8,9]
        List<int> rightPart = data.GetRange(splitIndex, amount);

        // STEP 3: Extract the left part of the list (the elements that stay behind)
        // Example: leftPart = [1,2,3,4,5,6]
        List<int> leftPart = data.GetRange(0, splitIndex);

        // STEP 4: Clear the original list
        // We will rebuild it in the correct rotated order
        data.Clear();

        // STEP 5: Add the right part first (these move to the front)
        data.AddRange(rightPart);

        // STEP 6: Add the left part after it
        data.AddRange(leftPart);

        // RESULT: The list is now rotated to the right by 'amount'
    }

}

