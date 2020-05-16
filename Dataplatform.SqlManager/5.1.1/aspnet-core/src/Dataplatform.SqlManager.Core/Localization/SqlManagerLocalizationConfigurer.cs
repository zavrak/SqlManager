using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Dataplatform.SqlManager.Localization
{
    public static class SqlManagerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SqlManagerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SqlManagerLocalizationConfigurer).GetAssembly(),
                        "Dataplatform.SqlManager.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
