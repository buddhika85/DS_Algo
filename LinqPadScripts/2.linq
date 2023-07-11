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

}

private bool IsMonotonic(int[] array)
{
	bool? isIncreasing = null;
	var prev = array[0];
	for (var i = 1; i < array.Length; i++)
	{
		if (isIncreasing == null)
		{
			if (array[prev] < array[i])
				isIncreasing = true;
			else if (array[prev] > array[i])
				isIncreasing = false;
		}
		else if (isIncreasing.Value)
		{
			if (array[prev] > array[i])
				return false;
		}
		else
		{
			if (array[prev] < array[i])
				return false;
		}
		prev = array[i];
	}
	return true;
}