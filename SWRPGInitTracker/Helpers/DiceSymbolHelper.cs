namespace SWRPGInitTracker.Helpers
{
    public static class DiceSymbolHelper
    {
        //dice
        private static readonly string _htmlBoost = "<span class=\"swicon boost\"></span>";
        private static readonly string _htmlAbility = "<span class=\"swicon ability\"></span>";
        private static readonly string _htmlProficiency = "<span class=\"swicon proficiency\"></span>";
        private static readonly string _htmlSetback = "<span class=\"swicon setback\"></span>";
        private static readonly string _htmlDifficulty = "<span class=\"swicon difficulty\"></span>";
        private static readonly string _htmlChallenge = "<span class=\"swicon challenge\"></span>";
        private static readonly string _htmlForce = "<span class=\"swicon force\"></span>";

        //dice symbols
        private static readonly string _htmlSuccess = "<span class=\"swicon success\"></span>";
        private static readonly string _htmlAdvantage = "<span class=\"swicon advantage\"></span>";
        private static readonly string _htmlTriumph = "<span class=\"swicon triumph\"></span>";
        private static readonly string _htmlFailure = "<span class=\"swicon failure\"></span>";
        private static readonly string _htmlThreat = "<span class=\"swicon threat\"></span>";
        private static readonly string _htmlDespair = "<span class=\"swicon despair\"></span>";

        //Force pips
        private static readonly string _htmlForcePip = "<span class=\"swicon forcepip\"></span>";
        private static readonly string _htmlLightSide = "<span class=\"swicon lightside\"></span>";
        private static readonly string _htmlDarkSide = "<span class=\"swicon darkside\"></span>";

        /// <summary>
        /// Replaces :placeholders: with their respective symbols.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <remarks>Big and ugly, not sure if there's a better way.</remarks>
        public static string Format(string input)
        {
            return input.Replace(":boost:", _htmlBoost)
                .Replace(":ability:", _htmlAbility)
                .Replace(":proficiency:", _htmlProficiency)
                .Replace(":setback:", _htmlSetback)
                .Replace(":difficulty:", _htmlDifficulty)
                .Replace(":challenge:", _htmlChallenge)
                .Replace(":force:", _htmlForce)
                .Replace(":success:", _htmlSuccess)
                .Replace(":advantage:", _htmlAdvantage)
                .Replace(":triumph:", _htmlTriumph)
                .Replace(":failure:", _htmlFailure)
                .Replace(":threat:", _htmlThreat)
                .Replace(":despair:", _htmlDespair)
                .Replace(":forcepip:", _htmlForcePip)
                .Replace(":lightside:", _htmlLightSide)
                .Replace(":darkside:", _htmlDarkSide);
        }
    }
}
