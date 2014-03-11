namespace VHPSerienummerPrinter.Converters
{
    public static class PixelConverter
    {
        public static int MilimeterToPixels(float milimeters)
        {
            float lengteInInch = milimeters / (float)25.4;

            return (int)(lengteInInch * 100);
        }
    }
}
