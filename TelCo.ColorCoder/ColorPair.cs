using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of color pair
    /// </summary>
    internal class ColorPair
    {
        /// <summary>
        /// Major color.
        /// </summary>
        internal Color majorColor;
        /// <summary>
        /// Minor color.
        /// </summary>
        internal Color minorColor;
        /// <summary>
        /// To string.
        /// </summary>
        /// <returns>
        /// Formatted string.
        /// </returns>
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
