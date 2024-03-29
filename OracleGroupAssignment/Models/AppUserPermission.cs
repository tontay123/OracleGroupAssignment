namespace OracleGroupAssignment.Models
{
    public class AppUserPermission
    {
        public int AppUserPermissionId { get; set; }
        public int AppUserId { get; set; }
        public string? UserPermission {  get; set; }
        
    }
}
