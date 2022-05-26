using System;
using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder
{
    static class ColorMap
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorMap()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        /// <summary>
        /// Get Color index.
        /// </summary>
        /// <param name="color">
        /// Color for which Index need to found.
        /// </param>
        /// <param name="colorMap">
        /// Color array.
        /// </param>
        /// <returns>
        /// Index of Color.
        /// </returns>
        public static int GetColorIndex(Color color, Color[] colorMap) =>
            Array.IndexOf(colorMap, color);

        /// <summary>
        /// Tel Co color code pair.
        /// </summary>
        /// <returns>
        /// Major and Minor color matching.
        /// </returns>
        public static List<(Color, Color)> PrintColorCode()
        {
            var colorPair = new List<(Color, Color)>();
            foreach (Color majorColor in colorMapMajor)
            {
                foreach (Color minorColor in colorMapMinor)
                {
                    colorPair.Add((majorColor, minorColor));
                }
            }

            return colorPair;
        }

        /// <summary>
        /// Gets Table header.
        /// </summary>
        /// <returns>
        /// Header.
        /// </returns>
        public static string PrintColorCodeHeader()
        {
            return "Pair No. Major Color  \t Minor Color";
        }
    }
}
