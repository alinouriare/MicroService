using Domain;
using Infrastructure.DbContexts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extentions
{
   public static class MediatorExtention
    {

        public static async Task DispacherDomainEventAsync(this IMediator mediator ,APPContext ctx)
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>().Where(x => x.Entity.Events != null && x.Entity.Events.Any());
            var domainEvents = domainEntities.SelectMany(x => x.Entity.Events).ToList();

            domainEntities.ToList().ForEach(entity => entity.Entity.ClearEvent());

            var task = domainEvents.Select(async (domainEvents) => { await mediator.Publish(domainEvents); });

            await Task.WhenAll(task);
        }
    }
}
