using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class FileManager
    {
        public string SaveFilePath(string selectedFilePath)
        {
            string currentDirectory = Environment.CurrentDirectory;

            string relativeFileLocation = Path.GetRelativePath(currentDirectory, selectedFilePath);

            string destinationFolderPath = Path.GetRelativePath(currentDirectory,
                "C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\PracticeWebApps\\Pages\\Shared\\images\\");

            return CopyFilePath(selectedFilePath, relativeFileLocation, destinationFolderPath);
        }
        private string CopyFilePath(string selectedFilePath, string relativeFileLocation, string destinationFolderPath)
        {
            string relativeDestinationFilePath;
            try
            {
                string fileName = Path.GetFileName(relativeFileLocation);
                relativeDestinationFilePath = Path.Combine(destinationFolderPath, fileName);
                File.Copy(selectedFilePath, relativeDestinationFilePath, true);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occured: {ex.Message}");
            }

            return relativeDestinationFilePath;
        }
    }
}
