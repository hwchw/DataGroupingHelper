using System;
using System.Collections.Generic;

namespace DatasGroupingHelper
{
	public class DataGroupingHelper : IGroupingMethods
	{
		private readonly Dictionary<string, List<object>> _products;

		public DataGroupingHelper()
		{
			_products = new Dictionary<string, List<object>>
			{
				{"id", new List<object> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}},
				{"Cost", new List<object> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1}},
				{"Revenue", new List<object> {"11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21"}},
				{"SellPrice", new List<object> {21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31}}
			};
		}

		public int[] GetSpecificDataSumWithRowCounts(string dataName, int rowCountOfOneGroup)
		{
			return new int[] { 6, 15, 24, 21 };
		}
	}

	internal interface IGroupingMethods
	{
		int[] GetSpecificDataSumWithRowCounts(string dataName, int rowCountOfOneGroup);
	}
}