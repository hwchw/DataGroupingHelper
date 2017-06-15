using System;
using System.Collections.Generic;
using DatasGroupingHelper;
using ExpectedObjects;
using FluentAssertions;
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
		public void GetSpecificDataSumWithRowCounts_given_DataName_id_countPerGroup_4_expected_is_10_26_30()
		{
			var sumRowHelper = new DataGroupingHelper();

			var expected = new List<int>() { 10, 26, 30 };
			var actual = sumRowHelper.GetSpecificDataSumWithRowCounts("id", 4);

			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod()]
		public void GetSpecificDataSumWithRowCounts_given_DataName_Revenue_countPerGroup_3_expected_is_36_45_54_41()
		{
			var sumRowHelper = new DataGroupingHelper();

			var expected = new List<int>() { 36, 45, 54, 41 };
			var actual = sumRowHelper.GetSpecificDataSumWithRowCounts("Revenue", 3);

			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod()]
		public void GetSpecificDataSumWithRowCounts_given_DataName_empty_expected_ArgumentException()
		{
			var sumRowHelper = new DataGroupingHelper();

			Action act = () => sumRowHelper.GetSpecificDataSumWithRowCounts(" ", 3);

			act.ShouldThrow<ArgumentException>();
		}

		[TestMethod()]
		public void GetSpecificDataSumWithRowCounts_given_DataName_id_rowCountOfOneGroup_0_expected_ArgumentException()
		{
			var sumRowHelper = new DataGroupingHelper();

			Action act = () => sumRowHelper.GetSpecificDataSumWithRowCounts("id", 0);

			act.ShouldThrow<ArgumentException>();
		}
	}
}
