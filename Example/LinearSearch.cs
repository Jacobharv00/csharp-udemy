using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Example

{
	class LinearSearch
	{
		/// <summary>
		/// Does a linear search of a list of elements
		/// </summary>
		static int linearSearch(List<int> elements, int x)
		{
			int length = elements.Count();

			for (int i = 0; i < length; i++)
			{
				if (elements[i] == x)
				{
					return i;
				}
			}

			return -1;
		}
	}

}

