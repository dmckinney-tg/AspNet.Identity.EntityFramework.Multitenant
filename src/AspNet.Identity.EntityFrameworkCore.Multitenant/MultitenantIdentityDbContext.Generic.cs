using System;
using System.Collections.Generic;
using System.Text;

namespace AspNet.Identity.EntityFrameworkCore.Multitenant
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class MultitenantIdentityDbContext<TUser,TRole,TKey, TTenantKey,TUserClaim,TUserRole,TUserLogin,TRoleClaim,TUserToken>
        : IdentityDbContext<TUser,TRole,TKey,TUserClaim,TUserRole,TUserLogin,TRoleClaim,TUserToken>
    where TKey: IEquatable<TKey>
    where TUser: MultitenantIdentityUser<TKey, TTenantKey>
    where TRole: IdentityRole<TKey>
    where TUserClaim: IdentityUserClaim<TKey>
    where TUserRole: IdentityUserRole<TKey>
    where TUserLogin: MultitenantIdentityUserLogin<TKey, TTenantKey>
    where TRoleClaim: IdentityRoleClaim<TKey>
    where TUserToken: IdentityUserToken<TKey>
    {
        public MultitenantIdentityDbContext(DbContextOptions options)
        :base(options)
        {
            
        }


    }
}
