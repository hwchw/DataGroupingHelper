using System;
using System.Collections.Generic;
using System.Linq;

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

		public List<int> GetSpecificDataSumWithRowCounts(string dataName, int rowCountOfOneGroup)
		{
			var index = 0;
			var list = _products[dataName];
			var sumList = new List<int>();
			while (index < list.Count)
			{
				var count = list.Count - index > rowCountOfOneGroup ? rowCountOfOneGroup : list.Count - index;
				sumList.Add(list.GetRange(index, count).Sum(x => Convert.ToInt32(x)));
				index += rowCountOfOneGroup;
			}
			return sumList;
		}
	}

	internal interface IGroupingMethods
	{
		List<int> GetSpecificDataSumWithRowCounts(string dataName, int rowCountOfOneGroup);
	}
}