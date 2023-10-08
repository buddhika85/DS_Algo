<Query Kind="Program" />

void Main()
{
	var array = new int []{5,4,4,2,1};
	SelectionSort(array);
	Console.WriteLine(string.Join(',', array));
}

void SelectionSort(int[] array)
{
	for (var i = 0; i < array.Length - 1; i++)
	{
		var minIndex = i;
		for (var j = i + 1; j < array.Length; j++)
		{
			if (array[minIndex] > array[j])
				minIndex = j;
		}
		if (minIndex != i)
		{
			var temp = array[i];
			array[i] = array[minIndex];
			array[minIndex] = temp;
		}
	}
}
