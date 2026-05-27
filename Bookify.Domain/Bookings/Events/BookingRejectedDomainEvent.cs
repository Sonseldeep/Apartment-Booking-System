using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Domain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;