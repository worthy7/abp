﻿using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Components.Web.BasicTheme.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebBasicThemeModule)
        )]
    public class AbpAspNetCoreComponentsWebBasicThemeServerModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebBasicThemeServerModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BasicThemeToolbarContributor());
            });
        }
    }
}