using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityUserTokenMap : ClassMap<IdentityUserToken>
    {
        public IdentityUserTokenMap()
        {
            CompositeId()
                .KeyProperty(x => x.UserId)
                .KeyProperty(x => x.LoginProvider)
                .KeyProperty(x => x.Name);

            Map(x => x.Value);
        }
    }
}
