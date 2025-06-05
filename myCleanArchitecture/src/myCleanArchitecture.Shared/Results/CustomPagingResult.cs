﻿namespace myCleanArchitecture.Shared.Results
{
    public class CustomPagingResult<T, TEntity>
    {
        public PagingResult<T>? PagingResult { get; set; }
        public TEntity? Entity { get; set; }
    }
}
