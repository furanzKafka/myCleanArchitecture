﻿
namespace myCleanArchitecture.Shared.FeatureModels.Categories
{
    public class CategoryDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
