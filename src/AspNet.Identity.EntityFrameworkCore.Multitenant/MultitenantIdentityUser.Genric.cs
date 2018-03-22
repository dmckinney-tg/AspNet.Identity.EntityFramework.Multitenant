using System;
using System.Collections.Generic;
using System.Text;

namespace AspNet.Identity.EntityFrameworkCore.Multitenant
{
    using Microsoft.AspNetCore.Identity;

    public class MultitenantIdentityUser<TKey, TTenantKey>
    :IdentityUser<TKey>
    where TKey: IEquatable<TKey>
    {
        public TTenantKey TenantId { get;set; }
    }
}
