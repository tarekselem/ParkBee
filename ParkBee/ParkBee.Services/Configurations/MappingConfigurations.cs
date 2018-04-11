using AutoMapper;


namespace ParkBee.Services.Configurations
{
    public class MappingConfigurations
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                #region From Binding Models to Entity
                config.CreateMap<BindingModels.Garage, Entities.Garage>();

                #endregion

                #region From Entity to View Model
                config.CreateMap<Entities.Garage, ViewModels.Garage>();

                //config.CreateMap<Entities.Order, ViewModels.Order>()
                //.ForMember(dest => dest.CustomerName, opts => opts.MapFrom(src => src.Customer.ContactName));
                #endregion
            });
        }
    }
}
