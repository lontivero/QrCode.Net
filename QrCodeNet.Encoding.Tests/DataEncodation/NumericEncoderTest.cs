﻿using System.Collections.Generic;
using QrCodeNet.Encoding.DataEncodation;
using NUnit.Framework;

namespace QrCodeNet.Encoding.Tests.DataEncodation
{
    [TestFixture]
    public class NumericEncoderTest : EncoderTestBase
    {
        [Test, TestCaseSource(typeof(NumericEncoderTestCaseFactory), "TestCasesFromReferenceImplementation")]
        public override void Test_against_reference_implementation(string inputString, IEnumerable<bool> expected)
        {
            base.Test_against_reference_implementation(inputString, expected);
        }

        [Test, TestCaseSource(typeof(NumericEncoderTestCaseFactory), "TestCasesFromCsvFile")]
        public override void Test_against_csv_DataSet(string inputString, IEnumerable<bool> expected)
        {
            base.Test_against_csv_DataSet(inputString, expected);
        }
        
        [Test, TestCaseSource(typeof(NumericEncoderTestCaseFactory), "TestCasesDataEncodeReferenceImplementation")]
        public override void DataEncode_Test_against_reference_DataSet(string inputString, IEnumerable<bool> expected)
        {
            base.DataEncode_Test_against_reference_DataSet(inputString, expected);
        }

        [Test, TestCaseSource(typeof(NumericEncoderTestCaseFactory), "TestCasesDataEncodeFromCsvFile")]
        public override void DataEncode_Test_against_csv_DataSet(string inputString, IEnumerable<bool> expected)
        {
            base.DataEncode_Test_against_reference_DataSet(inputString, expected);
        }
        
        protected override EncoderBase CreateEncoder()
        {
            return new NumericEncoder();
        }
        
        //[Test]
        public void Generate()
        {
            new NumericEncoderTestCaseFactory().GenerateTestDataSet("encoder");
        }
        
        //[Test]
        public void DataEncodeGenerate()
        {
            new NumericEncoderTestCaseFactory().GenerateTestDataSet("dataencode");
        }
    }
}
