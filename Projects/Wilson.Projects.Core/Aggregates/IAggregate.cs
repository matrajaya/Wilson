﻿namespace Wilson.Projects.Core.Aggregates
{
    public interface IAggregate<TEntity> where TEntity : class
    {
        void Load(TEntity source);
        bool Validate();      
    }
}