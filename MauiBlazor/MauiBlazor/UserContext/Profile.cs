using MauiBlazor.UserContext.Enums;
using MauiBlazor.UserContext.Data;

namespace MauiBlazor.UserContext
{
    public class Profile
    {
        public Profile(string email, EAccessLevel accessLevel)
        {
            GUID = Guid.NewGuid();
            Email = email;
            AccessLevel = accessLevel;
        }

        public Guid GUID { get; private set; }
        public string Email { get; set; }
        public EAccessLevel AccessLevel { get; set; }
        public List<EActions> AuthorizedActions { get => Actions.GetListActions(AccessLevel); }
    }
}
