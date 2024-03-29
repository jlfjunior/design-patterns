﻿using DesignPatterns.Behavorial.Decorator.Interface;

namespace DesignPatterns.Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(INotifier wrappee)
            :base(wrappee)
        {
        }

        public override string GetMessage()
        {
            return $"{Wrappee.GetMessage()} - Slack";
        }
    }
}
