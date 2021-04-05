using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace MyNet
{
    class NetNodes : List<Node>
    {
        private const string FILENAME = "NetNodes.json";

        public void AddNode(Node node)
        {
            if (Exists(node.Name))
                throw new Exception($"Node already exists with the name {node.Name}");

            Add(node);
        }

        public bool Exists(string name) => this.Any(item => item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        public void Save()
        {
            using var store = IsolatedStorageFile.GetUserStoreForApplication();
            using var stream = store.CreateFile(FILENAME);
            using var sw = new StreamWriter(stream);
            sw.Write(Convert.ToBase64String(ProtectedData.Protect(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this)), null, DataProtectionScope.CurrentUser)));
        }

        public void Export(string filename) => File.WriteAllText(filename, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
      
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

        public static NetNodes Import(string filename) => JsonSerializer.Deserialize<NetNodes>(File.ReadAllText(filename));
    }
}
