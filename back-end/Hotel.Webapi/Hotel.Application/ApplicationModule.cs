// See https://aka.ms/new-console-template for more information

using AutoMapper;
using DaLatFood.Application.Common;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        //Mapper
        var mapperConfig = new MapperConfiguration(mc =>
        {
        });
        IMapper mapper = mapperConfig.CreateMapper();
        service.AddSingleton(mapper);
        
        //Validate
        service.AddTransient<IValidateModel, ValidateModel>();
        service.AddValidatorsFromAssembly(typeof(ValidateModel).Assembly);
        // service.AddFluentValidationAutoValidation();

        //Service
        return service;
    }
}