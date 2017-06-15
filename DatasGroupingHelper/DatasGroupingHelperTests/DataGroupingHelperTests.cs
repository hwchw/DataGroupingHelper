using System.Collections.Generic;
using DatasGroupingHelper;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatasGroupingHelperTests
{
	[TestClass()]
	public class DataGroupingHelperTests
	{
		[TestMethod()]
		public void GetSpecificDataSumWithRowCounts_given_DataName_id_countPerGroup_3_expected_is_6_15_24_21()
		{
			//arrange
			var sumRowHelper = new DataGroupingHelper();
			//act
			var expected = new List<int>() { 6, 15, 24, 21 };
			var actual = sumRowHelper.GetSpecificDataSumWithRowCounts("id", 3);
			//assert
			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod()]
		public void GetSpecificDataSumWithRowCounts_given_DataName_id_countPerGroup_4_expected_is_6_15_24_21()
		{
			var sumRowHelper = new DataGroupingHelper();

			var expected = new List<int>() { 10, 26, 30 };
			var actual = sumRowHelper.GetSpecificDataSumWithRowCounts("id", 4);

			expected.ToExpectedObject().ShouldEqual(actual);
		}
	}
}
