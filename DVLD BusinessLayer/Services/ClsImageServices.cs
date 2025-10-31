using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer.Services
{
    public static class ClsImageServices
    {
        private static readonly string ImageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PersonImages");
        private static readonly string RecycleFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RecycleImages");

        static ClsImageServices()
        {
            try
            {
                if (!Directory.Exists(ImageFolder))
                    Directory.CreateDirectory(ImageFolder);

                if (!Directory.Exists(RecycleFolder))
                    Directory.CreateDirectory(RecycleFolder);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creating image folders: {ex.Message}");
            }
        }

        public static async Task<string> SaveImageAsync(string imageSource)
        {
            try
            {
                if (string.IsNullOrEmpty(imageSource) || !File.Exists(imageSource))
                    return string.Empty;

                string extension = Path.GetExtension(imageSource);
                string destPath = Path.Combine(ImageFolder, Guid.NewGuid() + extension);

                await Task.Run(() => File.Copy(imageSource, destPath, true));
                return destPath;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error saving image: {ex.Message}");
                return string.Empty;
            }
        }

        public static async Task DeleteImageAsync(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    await Task.Run(() => File.Delete(imagePath));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error deleting image: {ex.Message}");
            }
        }

        public static async Task RecycleImageAsync(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                    return;

                string extension = Path.GetExtension(imagePath);
                string destPath = Path.Combine(RecycleFolder, Guid.NewGuid() + extension);

                await Task.Run(() => File.Move(imagePath, destPath));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error recycling image: {ex.Message}");
            }
        }

        public static async Task<Image> LoadImageAsync(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                    return null;

                return await Task.Run(() =>
                {
                    using (var img = Image.FromFile(imagePath))
                        return new Bitmap(img);
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }

        public static bool IsValidImageFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return false;

            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }

        public static async Task<long> GetImagesFolderSizeAsync()
        {
            try
            {
                if (!Directory.Exists(ImageFolder))
                    return 0;

                return await Task.Run(() =>
                {
                    var directoryInfo = new DirectoryInfo(ImageFolder);
                    return directoryInfo.GetFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
                });
            }
            catch
            {
                return 0;
            }
        }
    }
}
