﻿using QrCodeNet.Encoding.Positioning.Stencils;

namespace QrCodeNet.Encoding.Positioning
{
    internal static class PositioninngPatternBuilder
    {
        internal static void EmbedBasicPatterns(int version, TriStateMatrix matrix)
        {
            new PositionDetectionPattern(version).ApplyTo(matrix);
            new DarkDotAtLeftBottom(version).ApplyTo(matrix);
            new AlignmentPattern(version).ApplyTo(matrix);
            new TimingPattern(version).ApplyTo(matrix);
        }
    }
}