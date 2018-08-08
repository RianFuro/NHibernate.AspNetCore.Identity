using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityUserClaimMap : ClassMap<IdentityUserClaim>
    {
        public IdentityUserClaimMap()
        {
            Id(x => x.Id);
            Map(x => x.ClaimType);
            Map(x => x.ClaimValue);
            Map(x => x.UserId);
        }
    }
}
