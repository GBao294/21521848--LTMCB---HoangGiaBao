using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class ftp
    {
        public string host = null;
        public string user = null;
        public string pass = null;
        public FtpWebRequest ftpRequest = null;
        public FtpWebResponse ftpResponse = null;
        public Stream ftpStream = null;
        public int bufferSize = 2048;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Giải phóng tài nguyên quản lý
                if (ftpStream != null)
                {
                    ftpStream.Dispose();
                    ftpStream = null;
                }
                if (ftpRequest != null)
                {
                    ftpRequest = null;
                }
            }

            // Giải phóng tài nguyên không quản lý (không cần trong trường hợp này)
        }

    }
}
