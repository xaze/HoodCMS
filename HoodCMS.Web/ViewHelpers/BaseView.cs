using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace HoodCMS.Web.ViewHelpers
{
    public class BaseView
    {
        public Guid UserId
        {
            get
            {
                return (Guid)Membership.GetUser().ProviderUserKey;
            }
        }

        public bool IsUserLoggedIn
        {
            get
            {
                return UserId != null;
            }
        }
    }
}