using AutoMapper;
using AutomapperMvcDemo.Domain.Entities;
using AutomapperMvcDemo.Models;

namespace AutomapperMvcDemo.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void RegisterMappings()
        {
            Mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentViewModel>().ReverseMap();
                cfg.CreateMap<StudentViewModel, Student>().ReverseMap();

            }));
        }
    }

}