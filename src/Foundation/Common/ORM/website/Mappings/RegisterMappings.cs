using Glass.Mapper.Sc.Pipelines.AddMaps;
using Camaro.Foundation.Common.ORM.Extensions;

namespace Camaro.Foundation.Common.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("Camaro.Foundation.Common.ORM");
        }
    }
}