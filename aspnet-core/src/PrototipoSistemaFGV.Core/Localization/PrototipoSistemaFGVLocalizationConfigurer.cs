using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PrototipoSistemaFGV.Localization
{
    public static class PrototipoSistemaFGVLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PrototipoSistemaFGVConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PrototipoSistemaFGVLocalizationConfigurer).GetAssembly(),
                        "PrototipoSistemaFGV.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
