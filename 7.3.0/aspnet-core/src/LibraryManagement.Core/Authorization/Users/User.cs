using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using static LibraryManagement.Constants.Enum.UserEnums;

namespace LibraryManagement.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }

        public string AvatarPath { get; set; }
        public UserType UserType { get; set; }
        public DateTime? DOB { get; set; }
        public Job Job { get; set; }
    }
}
