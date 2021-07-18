using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using Camaro.Foundation.Common.ORM.Models;

namespace Camaro.Foundation.Common.ORM
{
    public class GlassMappings : SitecoreGlassMap<IGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Info(f => f.BaseTemplateIds).InfoType(SitecoreInfoType.BaseTemplateIds);
            });
        }
    }
}