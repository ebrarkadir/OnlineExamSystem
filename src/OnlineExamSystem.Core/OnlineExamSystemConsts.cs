using OnlineExamSystem.Debugging;

namespace OnlineExamSystem
{
    public class OnlineExamSystemConsts
    {
        public const string LocalizationSourceName = "OnlineExamSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "549fca6865b94eb6888d4485b58fc39c";
    }
}
