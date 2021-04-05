using System;
using System.Security.Cryptography;
using System.Text;

namespace MyNet
{
    public class Node : IComparable
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public bool UsePuttyProfile { get; set; }
        public string PuttyProfile { get; set; }
        
        public bool UseWinScpProfile { get; set; }
        public string WinScpProfile { get; set; }

        public bool UseSshKey { get; set; }
        public string SshKeyData { get; set; }
        public string SshKeyFile { get; set; }

        public void CopyTo(Node dest)
        {
            dest.Name = Name;
            dest.IPAddress = IPAddress;
            dest.Username = Username;
            dest.Password = Password;
            dest.UsePuttyProfile = UsePuttyProfile;
            dest.PuttyProfile = PuttyProfile;
            dest.UseWinScpProfile = UseWinScpProfile;
            dest.WinScpProfile = WinScpProfile;
            dest.UseSshKey = UseSshKey;
            dest.SshKeyData = SshKeyData;
            dest.SshKeyFile = SshKeyFile;
        }

        public bool IsIdenticalTo(Node test)
        {
            return
                Name == test.Name &&
                IPAddress == test.IPAddress &&
                Username == test.Username &&
                Password == test.Password &&
                UsePuttyProfile == test.UsePuttyProfile &&
                PuttyProfile == test.PuttyProfile &&
                UseWinScpProfile == test.UseWinScpProfile &&
                WinScpProfile == test.WinScpProfile &&
                UseSshKey == test.UseSshKey &&
                SshKeyData == test.SshKeyData &&
                SshKeyFile == test.SshKeyFile;
        }

        public string HashName()
        {
            string data = Name.ToLower();
            var bytes = Encoding.UTF8.GetBytes(data);
            using (var md5 = MD5.Create())
            {
                return BitConverter.ToString(md5.ComputeHash(bytes)).Replace("-", null).ToLower();
            }
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Node)obj).Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
