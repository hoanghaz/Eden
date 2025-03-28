using System.Linq;

namespace Eden
{
    public class LoginDAL
    {
        private readonly QLBanHoaEntities db = new QLBanHoaEntities();

        // Kiểm tra đăng nhập và lấy thông tin người dùng
        public NGUOIDUNG ValidateUser(string username, string password)
        {
            return db.NGUOIDUNGs
                     .Include("NHOMNGUOIDUNG") // Nạp thông tin nhóm người dùng
                     .Where(nd => nd.TenDangNhap == username && nd.MatKhau == password) // Cần mã hóa mật khẩu nếu cần
                     .FirstOrDefault();
        }

        // Lấy danh sách quyền của nhóm người dùng thông qua navigation properties
        public IQueryable<string> GetUserPermissions(int userGroupId)
        {
            return db.NHOMNGUOIDUNGs
                     .Where(nnd => nnd.id == userGroupId)
                     .SelectMany(nnd => nnd.CHUCNANGs.Select(cn => cn.TenChucNang));
        }
    }
}