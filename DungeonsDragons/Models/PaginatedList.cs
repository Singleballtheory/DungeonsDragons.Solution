using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DungeonsDragons.Models
{
  public class PaginatedList<T> : List<T>
  {
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
      // where count is the length of item List
      // pageSize is the amount of items on page
      PageIndex = pageIndex;
      TotalPages = (int)Math.Ceiling(count / (double)pageSize); // total number of items divided by amount of items on page

      this.AddRange(items); // adds current items to already existing paginated list
    }

    public bool HasPreviousPage
    {
      get
      {
        return (PageIndex > 1); // returns true is page index is greater than 1
      }
    }

    public bool HasNextPage
    {
      get
      {
        return (PageIndex < TotalPages); // returns true if current page is less than total pages
      }
    }
    
    public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
    {
      var count = await source.CountAsync(); //async return of number of elements in source
      var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
      // bypasses specified number of elements and then returns remaining elements
      // page 1 with page size of 2: skip (1-1)*2 = skip 0, returns all elements of list
      // page 2 with page size of 2: skip (2-1)*2 = skip 2, returns everything but the first two elements
      // .take: returns the first `page size` elements of list
      return new PaginatedList<T>(items, count, pageIndex, pageSize);
    }
  }
}