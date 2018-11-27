using QrCodeNet.Encoding.Common;
using NUnit.Framework;
using com.google.zxing.qrcode.encoder;
using QrCodeNet.Encoding.Masking;
using QrCodeNet.Encoding.Masking.Scoring;


namespace QrCodeNet.Encoding.Tests.PenaltyScore
{
	public class Penalty2TestCaseFactory : PenaltyScoreTestCaseFactory
	{
		protected override string TxtFileName { get { return "Penalty2TestDataSet.txt"; } }
		
		protected override NUnit.Framework.TestCaseData GenerateRandomTestCaseData(int matrixSize, System.Random randomizer, MaskPatternType pattern)
		{
			return base.GenerateRandomTestCaseData(matrixSize, randomizer, pattern, PenaltyRules.Rule02);
		}
		
	}
}
