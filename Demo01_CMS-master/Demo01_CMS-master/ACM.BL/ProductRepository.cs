namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        /// <summary>
        /// Извлекает один товар по ID.
        /// </summary>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            // Временный тестовый объект
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "4 Yellow Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Сохраняет текущий товар.
        /// </summary>
        public bool Save(Product product)
        {
            var success = true;

            if (product.Validate())
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
