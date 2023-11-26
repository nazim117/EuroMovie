using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class FileManager
    {
        string originalFileName;
        public string SaveFile(string selectedFilePath)
        {
            if (string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                throw new ArgumentException("Select a file before saving");
            }

            try
            {
                string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

                string destinationFolder = Path.Combine(wwwrootPath, "images");

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                originalFileName = Path.GetFileName(selectedFilePath);

                string destinationPath = Path.Combine(destinationFolder, originalFileName);

                File.Copy(selectedFilePath, destinationPath, true);

                return destinationPath;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"An error occured: {ex.Message}");
            }
            
        }
        public string GetFileName()
        {
            return originalFileName;
        }
        public string CreateRelativePath(string originalFileName, string subfolder)
        {
            try
            {

                string relativePath = Path.Combine(subfolder, originalFileName).Replace('\\', '/'); ;

                return $"~/{relativePath}";

            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"An error occured: {ex.Message}");
            }
        }
    }
}
