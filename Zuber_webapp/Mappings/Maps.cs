using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zuber_webapp.Data;
using Zuber_webapp.Models;

namespace Zuber_webapp.Mappings
{
    public class Maps: Profile 
    {
        public Maps()
        {
            CreateMap<Driver, DriverVM>().ReverseMap();
            CreateMap<Trip, TripVM>().ReverseMap();
            CreateMap<CarType, CarTypeVM>().ReverseMap();
            CreateMap<Person, PersonVM>().ReverseMap();
            CreateMap<Customer, PersonVM>().ReverseMap();
           /* CreateMap<Admin, Driver>().ReverseMap();
            CreateMap<Admin, Trip>().ReverseMap();
            CreateMap<Admin, Customer>().ReverseMap();
            */
        }
    }
}
