﻿using QrCodeNet.Encoding.Masking.Scoring;
using NUnit.Framework;

namespace QrCodeNet.Encoding.Tests.PenaltyScore
{
	[TestFixture]
	public class Penalty3Test : PenaltyTestBase
	{
		[Test, TestCaseSource(typeof(Penalty3TestCaseFactory), "TestCasesFromReferenceImplementation")]
		public override void Test_against_reference_implementation(BitMatrix input, PenaltyRules penaltyRule, int expected)
		{
			base.Test_against_reference_implementation(input, penaltyRule, expected);
		}
		
		[Test]
        [TestCaseSource(typeof(Penalty3TestCaseFactory), "TestCasesFromTxtFile")]
        public void Test_against_DataSet(BitMatrix input, PenaltyRules penaltyRule, int expected)
        {
            base.Test_against_reference_implementation(input, penaltyRule, expected);
        }
		
		//[Test]
        public void Generate()
        {
        	new Penalty3TestCaseFactory().GenerateTestDataSet();
        }
	}
}
