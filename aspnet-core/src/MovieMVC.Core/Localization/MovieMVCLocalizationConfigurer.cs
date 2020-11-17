using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MovieMVC.Localization
{
    public static class MovieMVCLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MovieMVCConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MovieMVCLocalizationConfigurer).GetAssembly(),
                        "MovieMVC.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
