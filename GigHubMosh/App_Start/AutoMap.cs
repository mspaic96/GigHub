using AutoMapper;

namespace GigHubMosh.App_Start
{
    public static class AutoMap
    {
        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            var mapperConfiguration = new MapperConfiguration(
                config =>
                {
                    config.AddProfile<MappingProfile>();
                });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}