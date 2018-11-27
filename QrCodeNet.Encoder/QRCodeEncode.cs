using System;
using QrCodeNet.Encoding.DataEncodation;
using QrCodeNet.Encoding.ErrorCorrection;
using QrCodeNet.Encoding.Positioning;
using QrCodeNet.Encoding.EncodingRegion;
using QrCodeNet.Encoding.Masking;
using QrCodeNet.Encoding.Masking.Scoring;
using System.Collections.Generic;

namespace QrCodeNet.Encoding
{
	internal static class QRCodeEncode
	{
		internal static BitMatrix Encode(string content, ErrorCorrectionLevel errorLevel)
		{
			EncodationStruct encodeStruct = DataEncode.Encode(content, errorLevel);

            return ProcessEncodationResult(encodeStruct, errorLevel);
			
		}

        internal static BitMatrix Encode(IEnumerable<byte> content, ErrorCorrectionLevel errorLevel)
        {
            EncodationStruct encodeStruct = DataEncode.Encode(content, errorLevel);

            return ProcessEncodationResult(encodeStruct, errorLevel);
        }

        private static BitMatrix ProcessEncodationResult(EncodationStruct encodeStruct, ErrorCorrectionLevel errorLevel)
        {
            BitList codewords = ECGenerator.FillECCodewords(encodeStruct.DataCodewords, encodeStruct.VersionDetail);

            TriStateMatrix triMatrix = new TriStateMatrix(encodeStruct.VersionDetail.MatrixWidth);
            PositioninngPatternBuilder.EmbedBasicPatterns(encodeStruct.VersionDetail.Version, triMatrix);

            triMatrix.EmbedVersionInformation(encodeStruct.VersionDetail.Version);
            triMatrix.EmbedFormatInformation(errorLevel, new Pattern0());
            triMatrix.TryEmbedCodewords(codewords);

            return triMatrix.GetLowestPenaltyMatrix(errorLevel);
        }
		
	}
}
