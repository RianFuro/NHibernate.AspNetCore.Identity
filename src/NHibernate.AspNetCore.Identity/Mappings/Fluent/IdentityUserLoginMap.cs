using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityUserLoginMap : ClassMap<IdentityUserLogin>
    {
        public IdentityUserLoginMap()
        {
            CompositeId()
                .KeyProperty(x => x.LoginProvider)
                .KeyProperty(x => x.ProviderKey);

            Map(x => x.ProviderDisplayName);
            Map(x => x.UserId);
        }
    }
}
