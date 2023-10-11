<Query Kind="Program" />

void Main()
{
	var array = new int []{4,-4,3,2,1};
	InsertionSort(array);
	Console.WriteLine(string.Join(',', array));
}

void InsertionSort(int[] array)
{
	for (var i = 1; i < array.Length; i++)
	{
		var current = array[i];
		var j = i - 1;
		var wasShifted = false;
		while (j >= 0 && array[j] > current)
		{		
			// shift left to right - to make space for current
			array[j + 1] = array[j]; 		
			wasShifted = true;
			j--;
		}
		if (wasShifted)
			array[j + 1] = current;
	}
}
