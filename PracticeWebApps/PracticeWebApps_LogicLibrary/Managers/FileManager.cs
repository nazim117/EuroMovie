namespace PracticeWebApps_LogicLibrary.Managers
{
    public class FileManager
    {
        private string originalFileName;
        public string SaveFile(string selectedFilePath)
        {
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                throw new ArgumentException("Select a file before saving");
            }

            try
            {
                string wwwrootPath = "C:\\Sem2-project-repository\\individual-project-nazim-ahmedov-s2\\PracticeWebApps\\PracticeWebApps\\wwwroot\\";

                string destinationFolder = Path.Combine(wwwrootPath, "images");

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                originalFileName = Path.GetFileName(selectedFilePath);

                string destinationPath = Path.Combine(destinationFolder, originalFileName);

                if (!File.Exists(destinationPath))
                {
                    File.Copy(selectedFilePath, destinationPath, true);
                }

                return destinationPath;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"An error occured: {ex}");
            }
            
        }
        public string CreateRelativePath(string subfolder)
        {
            try
            {
                string relativePath = Path.Combine(subfolder, originalFileName).Replace('\\', '/');

                return $"~/{relativePath}";

            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"An error occured: {ex}");
            }
        }
    }
}
