using FluentValidation;
using FluentValidation.Results;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Services
{
    public abstract class BaseService
    {
        public INotificationContext _notificationContext;

        protected BaseService(INotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        protected void AddNotification(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                AddNotification(error.ErrorMessage);
            }
        }

        protected void AddNotification(string message)
        {
            _notificationContext.Handle(new Notification(message));
        }

        protected bool Validate<TV, TE>(TV validation, TE model) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validationRsult = validation.Validate(model);

            if (validationRsult.IsValid) return true;

            AddNotification(validationRsult);

            return false;
        }

    }
}
