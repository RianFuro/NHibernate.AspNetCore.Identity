using FluentNHibernate.Mapping;

namespace NHibernate.AspNetCore.Identity.Mappings.Fluent
{
    public class IdentityUserRoleMap : ClassMap<IdentityUserRole>
    {
        public IdentityUserRoleMap()
        {
            CompositeId()
                .KeyProperty(x => x.RoleId)
                .KeyProperty(x => x.UserId);
        }
    }
}
