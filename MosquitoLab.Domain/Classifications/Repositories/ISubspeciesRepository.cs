﻿using System.Collections.Generic;
using MosquitoLab.Domain.Accounts.Filters;
using MosquitoLab.Domain.Classifications.Dto;
using MosquitoLab.Domain.Classifications.Entities;
using MosquitoLab.Domain.Common.Repositories;

namespace MosquitoLab.Domain.Classifications.Repositories
{
    public interface ISubspeciesRepository : IRepository<Subspecies>

    {
        IList<SimpleSelectDto> All(AdancedSearchFilter filter);
    }
}
