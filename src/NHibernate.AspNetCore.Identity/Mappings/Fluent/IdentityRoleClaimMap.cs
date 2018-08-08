using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityRoleClaimMap : ClassMap<IdentityRoleClaim>
    {
        public IdentityRoleClaimMap()
        {
            Id(x => x.Id);
            Map(x => x.ClaimType);
            Map(x => x.ClaimValue);
        }
    }
}
