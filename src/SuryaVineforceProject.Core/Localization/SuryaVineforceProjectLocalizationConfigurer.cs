using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SuryaVineforceProject.Localization
{
    public static class SuryaVineforceProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SuryaVineforceProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SuryaVineforceProjectLocalizationConfigurer).GetAssembly(),
                        "SuryaVineforceProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
