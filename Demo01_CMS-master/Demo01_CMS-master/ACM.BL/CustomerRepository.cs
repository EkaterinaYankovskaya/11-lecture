using System.Collections.Generic;

namespace CMS.BusinessLayer
{
    public class CustomerRepository
    {
        /// <summary>
        /// Извлекает одного клиента по его ID.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // Временный код/заглушка для демонстрации
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Извлекает список всех клиентов.
        /// </summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Сохраняет текущего клиента.
        /// </summary>
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.Validate())
            {
                // Логика сохранения в базу данных или файл
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}