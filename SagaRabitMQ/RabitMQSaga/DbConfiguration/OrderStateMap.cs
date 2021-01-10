using MassTransit.EntityFrameworkCoreIntegration.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RabitMQSaga.StateMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabitMQSaga.DbConfiguration
{
    public class OrderStateMap :
  SagaClassMap<OrderStateData>
    {
        protected override void Configure(EntityTypeBuilder<OrderStateData> entity, ModelBuilder model)
        {
            entity.Property(x => x.CurrentState).HasMaxLength(64);
            entity.Property(x => x.OrderCreationDateTime);
        }
    }
}
