﻿using AutoMapper;

namespace LabsAndCoursesManagement.BusinessLogic.Mappers
{
    public class HomeworkMapper
    {
        protected HomeworkMapper() { }
        private static readonly Lazy<IMapper> Lazy =
           new(() =>
           {
               var config = new MapperConfiguration(cfg =>
               {
                   cfg.ShouldMapProperty = p =>
                   p.GetMethod.IsPublic ||
                   p.GetMethod.IsAssembly;
                   cfg.AddProfile<HomeworkMappingProfile>();
               });
               var mapper = config.CreateMapper();
               return mapper;
           });
        public static IMapper Mapper => Lazy.Value;
    }
}
