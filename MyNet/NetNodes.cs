using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace MyNet
{
    class NetNodes : List<Node>
    {
        public void AddNode(Node node)
        {
            if (Exists(node.Name))
                throw new Exception($"Node already exists with the name {node.Name}");
           
            Add(node);
        }

        public bool Exists(string name) => this.Any(item => item.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        private static string AppDir => Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JD", "MyNet")).FullName;

        private static string ConfigFile => Path.Combine(AppDir, "config.dat");

        public void Save() =>
            File.WriteAllBytes(ConfigFile, ProtectedData.Protect(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(this)), null, DataProtectionScope.CurrentUser));

        
        public void Export(string filename) => File.WriteAllText(filename, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
      
        public static NetNodes Load()
        {
            try
            {
                return JsonSerializer.Deserialize<NetNodes>(Encoding.UTF8.GetString(ProtectedData.Unprotect(File.ReadAllBytes(ConfigFile), null, DataProtectionScope.CurrentUser)));
            }
            catch
            {
                return new NetNodes();
            }
        }

        public static NetNodes Import(string filename) => JsonSerializer.Deserialize<NetNodes>(File.ReadAllText(filename));
    }
}
