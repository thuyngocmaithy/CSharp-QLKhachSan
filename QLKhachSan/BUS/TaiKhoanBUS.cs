using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLKhachSan.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO TaiKhoanDAO = new TaiKhoanDAO();

        public DataTable GetTaiKhoan()
        {
            return TaiKhoanDAO.getTaiKhoan();
        }
        public DataTable GetTaiKhoan(string sql)
        {
            return TaiKhoanDAO.getTaiKhoan(sql);
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.ThemTaiKhoan(tk);
        }

        public bool SuaTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.SuaTaiKhoan(tk);
        }

        public bool XoaTaiKhoan(string mataikhoan)
        {
            return TaiKhoanDAO.XoaTaiKhoan(mataikhoan);
        }
        public string TaoMaTaiKhoan()
        {
            string maloaiphong = TaiKhoanDAO.TaoMaTaiKhoan();
            return maloaiphong;
        }
        public TaiKhoanDTO checkLogin(string tentaikhoan, string password)
        {            
            return TaiKhoanDAO.checkLogin(tentaikhoan , password);
        }
        public string Encrypt(string toEncrypt, bool useHashing) //Mã hóa pass
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes("iloveit1208"));
            }
            else keyArray = Encoding.UTF8.GetBytes("iloveit1208");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
       
    }
}
