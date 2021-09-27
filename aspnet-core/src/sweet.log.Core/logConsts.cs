using sweet.log.Debugging;

namespace sweet.log
{
    public class logConsts
    {
        public const string LocalizationSourceName = "log";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d831446b4b264f1f921b6b4fef1b9679";
    }
}
