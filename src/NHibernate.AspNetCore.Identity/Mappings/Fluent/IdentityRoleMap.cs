using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityRoleMap : IdentityRoleMap<IdentityRole> { }

    public class IdentityRoleMap<T> : ClassMap<T> where T : IdentityRole
    {
        public IdentityRoleMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.NormalizedName);
            Map(x => x.ConcurrencyStamp);
        }
    }
}
