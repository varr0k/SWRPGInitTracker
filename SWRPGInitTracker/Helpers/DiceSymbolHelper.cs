namespace SWRPGInitTracker.Helpers
{
    public static class DiceSymbolHelper
    {
        private static readonly string _htmlBoost = "<span class=\"swicon boost\"></span>";

        public static string Format(string input)
        {
            return input.Replace(":boost:", _htmlBoost);
        }
    }
}
