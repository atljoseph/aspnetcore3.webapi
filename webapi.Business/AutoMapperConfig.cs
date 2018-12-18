using System;
using AutoMapper;
using webapi.Models;
using webapi.AuthDAL;

namespace webapi.Business
{
    public class AutoMapperBusinessProfile : Profile
    {
        public AutoMapperBusinessProfile()
        {
            CreateMap<webapi.AuthDAL.Entities.User, webapi.Models.User>();
        }
    }

    public class ObjectMapper
    {
        public static IMapper Mapper
        {
            get { return mapper.Value; }
        }

        public static IConfigurationProvider Configuration
        {
            get { return config.Value; }
        }

        public static Lazy<IMapper> mapper = new Lazy<IMapper>(() =>
        {
            var mapper = new Mapper(Configuration);
            return mapper;
        });

        public static Lazy<IConfigurationProvider> config = new Lazy<IConfigurationProvider>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperBusinessProfile>();
            });

            return config;
        });
    }

    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }

    public abstract class AutoMapperService : IAutoMapperService
    {
        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }
    }
}


