<Query Kind="Program" />

/*
1.	Sorted Squared Array - You are given an array of Integers in which each subsequent value is not less than the previous value. 
Write a function that takes this array as an input and returns a new array with the squares of each number sorted in ascending order.
*/

void Main()
{
	List<(int[], int[])> data = new ()
	{		
		(new int[] {1}, new int[] {1}),
		(new int[] {1, 2}, new int[] {1, 4}),
		(new int[] {-7, -1, 4, 5, 6}, new int[] {1, 16, 25, 36, 49}),
		(new int[] {-7, -5, 0, 1, 3, 5}, new int[] {0, 1, 9, 25, 25, 49})
	};
	foreach (var element in data)
	{
		if (GetSortedSquared(element.Item1).SequenceEqual(element.Item2))
			Console.WriteLine("Test Case Passed");
		else
			Console.WriteLine("Test Case Failed");
	}
}

private int[] GetSortedSquared(int[] array)
{
	if (array == null || array.Length == 0)
		return array;
	
	var sortedSquared = new int[array.Length];
	var left = 0;
	var right = array.Length - 1;
	var position = right;
	while(position >= 0)
	{
		if (array[left] * array[left] >= array[right] * array[right])
			sortedSquared[position--] = array[left] * array[left++];
		else
			sortedSquared[position--] = array[right] * array[right--];
	}
	return sortedSquared;
}