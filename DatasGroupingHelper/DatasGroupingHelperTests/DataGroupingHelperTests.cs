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
			var expected = new[] { 6, 15, 24, 21 };
			var actual = sumRowHelper.GetSpecificDataSumWithRowCounts("id", 3);
			//assert
			expected.ToExpectedObject().ShouldEqual(actual);
		}
	}
}
