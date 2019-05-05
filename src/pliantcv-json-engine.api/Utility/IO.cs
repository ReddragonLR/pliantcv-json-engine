//SDK
using System;
using System.IO;
using System.Reflection;

namespace pliantcv_json_engine.api.Utility {
    public static class IO {
        public static string PathRelativeToApplicationRoot(string relativePath) {
            var executingAssemblyFilePath = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var applicationRootPath = Path.GetDirectoryName(executingAssemblyFilePath);
            return Path.Combine(applicationRootPath, relativePath);
        }

        public static Stream EmbeddedResourceAsStream (string relativePath) {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var normalizedAssemblyName = executingAssembly.GetName().Name.Replace("-","_");
            var normalizedRelativePath = relativePath.Replace("/",".").Replace("\\",".");
            var resourceName = $"{normalizedAssemblyName}.{normalizedRelativePath}";
            var resourceStream = executingAssembly.GetManifestResourceStream(resourceName);
            return resourceStream;
        }
    }
}