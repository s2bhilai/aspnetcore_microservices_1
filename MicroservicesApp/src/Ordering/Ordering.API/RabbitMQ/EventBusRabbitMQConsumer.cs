﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EventBusRabbitMQ;
using EventBusRabbitMQ.Common;
using EventBusRabbitMQ.Events;
using MediatR;
using Newtonsoft.Json;
using Ordering.Application.Commands;
using Ordering.Core.Repositories;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Ordering.API.RabbitMQ
{
    public class EventBusRabbitMQConsumer
    {
        private IRabbitMQConnection _connection;
        private IMediator _mediator;
        private IMapper _mapper;
        private IOrderRepository _orderRepository;

        public EventBusRabbitMQConsumer(IRabbitMQConnection connection,
            IMediator mediator,
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _connection = connection;
            _mediator = mediator;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public void Consume()
        {
            var channel = _connection.CreateModel();
            channel.QueueDeclare(queue: EventBusConstants.BasketCheckoutQueue,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var consumer = new EventingBasicConsumer(channel);

            //Create Event when something received
            consumer.Received += Consumer_Received;

            channel.BasicConsume(queue: EventBusConstants.BasketCheckoutQueue,
                autoAck: true,
                consumer: consumer);
        }

        private async void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            if (e.RoutingKey == EventBusConstants.BasketCheckoutQueue)
            {
                var message = Encoding.UTF8.GetString(e.Body.Span);
                var basketCheckoutEvent = JsonConvert.DeserializeObject<BasketCheckoutEvent>(message);

                // EXECUTION : Call Internal Checkout Operation
                var command = _mapper.Map<CheckoutOrderCommand>(basketCheckoutEvent);
                var result = await _mediator.Send(command);
            }
        }

        public void Disconnect()
        {
            _connection.Dispose();
        }
    }
}
