﻿using AutoMapper;
using Basket.API.Entities;
using EventBusRabbitMQ.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.API.Mapping
{
    public class BasketMapping: Profile
    {
        public BasketMapping()
        {
            CreateMap<BasketCheckOut, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
