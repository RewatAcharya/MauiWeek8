namespace Form.Data.Utils
{
    public class Utils
    {
        public static string ApplicationDirectoryPath()
        {
            string directoryPath = @"C:\Users\zackz\OneDrive\Desktop\AD\Maui";
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    return directoryPath;
                }
                else
                {
                    return directoryPath;
                }
            } 
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ApplicationFilePath()
        {
            string directoryPathCreated = ApplicationDirectoryPath();
            string filePath = Path.Combine(directoryPathCreated, "FormData.json");
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    return filePath;
                }
                else
                {
                    return filePath;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
