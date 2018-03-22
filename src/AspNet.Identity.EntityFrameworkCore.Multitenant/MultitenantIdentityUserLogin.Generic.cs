using System;
using System.Collections.Generic;
using System.Text;

namespace AspNet.Identity.EntityFrameworkCore.Multitenant
{
    using Microsoft.AspNetCore.Identity;

    public class MultitenantIdentityUserLogin<TKey, TTenantKey>
    :IdentityUserLogin<TKey>
    where TKey: IEquatable<TKey>
    {
        public virtual TTenantKey TenantId { get;set; }
    }
}
