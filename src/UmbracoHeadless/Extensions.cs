using Umbraco.Cms.Core.Sections;
using Umbraco.Cms.Core.Dashboards;

namespace UmbracoHeadless;

public static class Extensions
{
    public static IUmbracoBuilder SanitizeBackOffice(this IUmbracoBuilder builder, bool isDevEnv = false)
    {
        builder.Sections().Remove<FormsSection>();

        if (!isDevEnv)
        {
            builder.Sections().Remove<SettingsSection>();
            builder.Sections().Remove<PackagesSection>();
        }

        builder.Dashboards().Remove<ContentDashboard>();

        return builder;
    }
}
