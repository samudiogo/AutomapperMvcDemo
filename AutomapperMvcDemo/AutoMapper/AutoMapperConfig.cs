using AutoMapper;
using AutomapperMvcDemo.Domain.Entities;
using AutomapperMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomapperMvcDemo.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void RegisterMappings()
        {
            Mapper = new Mapper(new MapperConfiguration(m=> {
                m.AddProfile<DomainToViewModelProfile>();
                m.AddProfile<ViewModelToDomainProfile>();
            }));
        }
    }

    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Student, StudentViewModel>();
        }
    }

    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<StudentViewModel, Student>();
        }
    }
}