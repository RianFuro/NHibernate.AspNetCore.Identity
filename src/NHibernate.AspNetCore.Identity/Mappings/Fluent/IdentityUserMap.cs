using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityUserMap : IdentityUserMap<IdentityUser> { }

    public class IdentityUserMap<T> : ClassMap<T> where T : IdentityUser
    {
        public IdentityUserMap()
        {
            Id(x => x.Id);
            Map(x => x.AccessFailedCount);
            Map(x => x.ConcurrencyStamp);
            Map(x => x.Email);
            Map(x => x.EmailConfirmed);
            Map(x => x.LockoutEnabled);
            Map(x => x.LockoutEndUnixTimeMilliseconds, "LockoutEnd");
            Map(x => x.PasswordHash);
            Map(x => x.PhoneNumber);
            Map(x => x.PhoneNumberConfirmed);
            Map(x => x.TwoFactorEnabled);
            Map(x => x.UserName);
            Map(x => x.NormalizedUserName);
            Map(x => x.SecurityStamp);
        }
    }
}
