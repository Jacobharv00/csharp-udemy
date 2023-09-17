using System;
using System.Collections.Generic;


namespace Example
{
	/// <summary>
	/// Does a binary search on list of elements
	/// </summary>
	class BinarySearch
	{
		static int binarySearch(List<int> elements, int x)
		{
			int start = 0;
			int stop = elements.Count - 1;
			int middle = (int)((start + stop) / 2);

			while (elements[middle] != x && start < stop)
			{
				if(x < elements[middle])
				{
					stop = middle - 1;
				}
				else
				{
					start = middle + 1;
				}

                middle = (int)((start + stop) / 2);
            }

			return (elements[middle] != x) ? -1 : middle;
		}
	}
}

