using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OnlineExamSystem.Localization
{
    public static class OnlineExamSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OnlineExamSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OnlineExamSystemLocalizationConfigurer).GetAssembly(),
                        "OnlineExamSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
