using UserManagementSystem.Models;

namespace UserManagementSystem.Data.Models
{
    public class UserPermission
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Permission Permission { get; set; }
        public int PermissionId { get; set; }
    }
}
