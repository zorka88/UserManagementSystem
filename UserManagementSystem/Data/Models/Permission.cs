using System.Collections.Generic;

namespace UserManagementSystem.Data.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<UserPermission> Users { get; set; }
    }
}
