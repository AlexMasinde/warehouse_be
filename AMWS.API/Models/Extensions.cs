﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Models
{
    public static class Extensions
    {
        public static async Task<PagedResult<T>> GetPagedAsync<T>(this IQueryable<T> query,
                                         int page, int pageSize) where T : class
        {
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();
          

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            List<T> lists = await query.Skip(skip).Take(pageSize).ToListAsync();
            result.Results = lists;

            return result;
        }
    }
}
