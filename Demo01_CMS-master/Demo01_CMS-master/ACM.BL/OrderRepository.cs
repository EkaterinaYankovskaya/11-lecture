using System;

namespace CMS.BusinessLayer
{
    public class OrderRepository
    {
        /// <summary>
        /// Извлекает один заказ по ID.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            // Временный тестовый объект
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Сохраняет текущий заказ.
        /// </summary>
        public bool Save(Order order)
        {
            var success = true;

            if (order.Validate())
            {
                // Сохранение в БД
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
