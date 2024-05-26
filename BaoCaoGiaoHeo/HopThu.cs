using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BaoCaoGiaoHeo
{
    public class HopThu
    {
        private static HopThu instance;
        public static HopThu Instance
        {
            get { if (instance == null) instance = new HopThu(); return instance; }
            private set { instance = value; }
        }
        public bool SendMail(TaiKhoan tk, MailMessage mailMessage)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(tk.TenTaiKhoan, tk.MatKhau);
                smtp.Send(mailMessage);
				return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                return false;
            }
        }
        public static string getStringImage(Image image)
        {
            if (image == null) return "";
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageData = ms.ToArray();
                    string base64String = Convert.ToBase64String(imageData);
                    return base64String;
                }
            }
            catch
            {
                return "";
            }
        }
        public static Image getImageFromByteString(string byteString)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch
            {
                return null;
            }
        }
    }
}

