using CPHDevFest9.Domain.Events;
using Microsoft.Extensions.Logging;

namespace CPHDevFest9.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CPHDevFest9 Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
