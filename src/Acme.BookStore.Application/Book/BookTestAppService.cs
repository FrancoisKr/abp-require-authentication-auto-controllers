using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Book
{
    [AllowAnonymous]
    public class BookTestAppService : ApplicationService, IBookTestAppService
    {
        public virtual async Task<bool> BookTestAsync()
        {
            return true;
        }
    }
}
