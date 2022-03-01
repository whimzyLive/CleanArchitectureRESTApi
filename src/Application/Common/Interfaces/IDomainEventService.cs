using ProjectX.Domain.Common;

namespace ProjectX.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
