﻿namespace Lesson
{
    public interface IPaymentSystem
    {
        public string GetPayingLink(Order order);
    }
}