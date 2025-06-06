﻿using myCleanArchitecture.Shared.FeatureModels.Categories;

namespace myCleanArchitecture.Shared.FeatureModels.Products
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto? Category { get; set; }
    }
}
