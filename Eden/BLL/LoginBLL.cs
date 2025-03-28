using System;
using System.Collections.Generic;
using System.Data;
using Guna.UI2.WinForms;

using System.Linq;

namespace Eden
{
    public class LoginBLL
    {
        private readonly LoginDAL loginDAL = new LoginDAL();

        public bool ValidateUser(string username, string password)
        {
            var user = loginDAL.ValidateUser(username, password);
            if (user != null)
            {
                CurrentUser.Id = user.id;
                CurrentUser.Username = user.TenNguoiDung;
                CurrentUser.Role = user.NHOMNGUOIDUNG?.TenNhomNguoiDung;
                CurrentUser.UserGroupId = user.idNhomNguoiDung;

                // Lấy quyền từ navigation properties
                CurrentUser.Permissions = loginDAL.GetUserPermissions(user.idNhomNguoiDung).ToList();

                return true;
            }
            return false;
        }
    }
}