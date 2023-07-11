<Query Kind="Program" />


/*
2.	Monotonic Array - An array is monotonic if it is either monotone increasing or monotone decreasing. 
An array is monotone increasing if all its elements from left to right are non-decreasing. 
[1,2,3,3]
An array is monotone decreasing if all its elements from left to right are non-increasing. 
[3,3,2,1]
Given an integer array return true if the given array is monotonic, or false otherwise.

*/

void Main()
{
	List<(int[], bool)> data = new()
	{
		(new int[] {1,2,1}, false),
		(new int[] { -1, -2, 0 }, false),
		(new int[] { 1, 2, 1, 2 }, false),
		(new int[] { -1, -2, 0, -2 }, false),
		(new int[] { 1, 2, 3, 3 }, true),
		(new int[] { 3, 3, 2, 1 }, true),
		(new int[] { 1, 2, 3, 3, 4, 4, 4, 5 }, true),
		(new int[] { 3, 3, 2, 1, 1, 1, -10, -100 }, true),
	};
	foreach (var element in data)
	{
		var result = IsMonotonic(element.Item1) == element.Item2 ? "Passed" : "Failed";
		Console.WriteLine(result);
	}
}

private bool IsMonotonic(int[] array)
{
	bool? isIncreasing = null;
	var prevIndex = 0;
	for (var i = 1; i < array.Length; i++)
	{
		if (isIncreasing == null)
		{
			if (array[prevIndex] < array[i])
				isIncreasing = true;
			else if (array[prevIndex] > array[i])
				isIncreasing = false;
		}
		else if (isIncreasing.Value)
		{
			if (array[prevIndex] > array[i])
				return false;
		}
		else
		{
			if (array[prevIndex] < array[i])
				return false;
		}
		prevIndex = i;
	}
	return true;
}