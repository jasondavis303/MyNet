﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace MyNet
{
    class NetNodes : List<Node>
    {
        private const string FILENAME = "NetNodes.json";

        public void Save()
        {
            using var store = IsolatedStorageFile.GetUserStoreForApplication();
            using var stream = store.CreateFile(FILENAME);
            using var sw = new StreamWriter(stream);
            sw.Write(Convert.ToBase64String(ProtectedData.Protect(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this)), null, DataProtectionScope.CurrentUser)));
        }


        public static NetNodes Load()
        {
            try
            {
                using var store = IsolatedStorageFile.GetUserStoreForApplication();
                using var stream = store.OpenFile(FILENAME, FileMode.Open);
                using var sr = new StreamReader(stream);
                return JsonSerializer.Deserialize<NetNodes>(Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(sr.ReadToEnd()), null, DataProtectionScope.CurrentUser)));
            }
            catch
            {
                return new NetNodes();
            }
        }
    }
}
