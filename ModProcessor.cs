using AmongUsModLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModLauncher
{
    public class ModProcessor
    {
        public static bool Processing = false;
        public static string ModsFolderName { get; set; } = "AULauncher - Mods";
        private static void InstallLatestRelease()
        {
            CreateGameCopy($"{Version}");
        }
        public static int InstallProgress = 0;
        private static string ModInstalationPath = string.Empty;
        private static void CreateGameCopy(string folderName)
        {
            string modsFolderPath = $"{ SteamCommPath }\\{ModsFolderName}\\";
            #region init_All_Mods_folder
            CreateDirIfNotExist(modsFolderPath);
            InstallProgress += 10;
            #endregion init_All_Mods_folder
            #region CopyAmongUs
            // Create Mod folder if it doesn't exist
            var modFolderPath = modsFolderPath +$"{ModName}\\";
            CreateDirIfNotExist(modFolderPath);
            InstallProgress += 10;

            // Drop and create the version folder
            var versionFolderPath = modFolderPath + Version+"\\"; 
            DropAndCreate(versionFolderPath);
            InstallProgress += 10;

            // Copy among us folder into the version folder
            DirectoryCopy(SteamCommPath + "Among Us", versionFolderPath, true);
            ModInstalationPath = versionFolderPath;
            InstallProgress += 20;
            #endregion

            // UnzipArchive
            ZipFile.ExtractToDirectory(DownloadedPath, ModInstalationPath);
            InstallProgress += 20;

            if (File.Exists(DownloadedPath))
                File.Delete(DownloadedPath);
            InstallProgress += 15;

        }

        private static void CreateDirIfNotExist(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName); // among us folder
            
            //DropAndCreate(versionFolderPath);
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                // If the destination directory doesn't exist, create it.   
                CreateDirIfNotExist(destDirName);

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(tempPath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string tempPath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                    }
                }
            }
            catch (Exception e) { return; }

        }

        private static void DropAndCreate(string destPath)
        {
            DirectoryInfo dir = new DirectoryInfo(destPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(destPath);
            }
            else
            {
                dir.Delete(true);
                Directory.CreateDirectory(destPath);
            }
        }

        public static string ModName { get; set; }
        public static string Version { get; set; }
        public static async Task<ModModel> LoadLatestModRelease(string dev_modName)
        {
            string url = $"http://api.github.com/repos/{ dev_modName }/releases";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<ModModel> allReleases = await response.Content.ReadAsAsync<List<ModModel>>();

                    return allReleases.FirstOrDefault();
                }
                else
                {
                    throw new Exception("Incorrect mod or developer name");
                }
            }
        }
        public static string DownloadedPath { get; private set; } = string.Empty;
        public static string SteamCommPath;
        public static bool DownloadModRelease(string zipDownloadUrl, string fileName, string steamPath)
        {
            using (var client = new WebClient())
            {
                try
                {
                    InstallProgress += 10;
                    steamPath.Concat(ModsFolderName);
                    string filePath = steamPath.Length > 0 ? steamPath : @"C:\Program Files (x86)\Steam\steamapps\common\" + ModsFolderName;
                    SteamCommPath = filePath;
                    var fileUri = new Uri(zipDownloadUrl);
                    DownloadedPath = filePath + $"{fileName}.zip";
                    client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                    client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadZip_OnDownloadFileCompleted);

                    client.DownloadFileAsync(fileUri, DownloadedPath);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    client.Dispose();
                }
            }
        }
        
        public static bool DownloadModRelease(string zipDownloadUrl, string steamPath)
        {
            using (var client = new WebClient())
            {
                try
                {
                    steamPath.Concat(ModsFolderName);
                    string filePath = steamPath.Length > 0 ? steamPath : @"C:\Program Files (x86)\Steam\steamapps\common\" + ModsFolderName;
                    SteamCommPath = filePath;
                    var fileUri = new Uri(zipDownloadUrl);
                    DownloadedPath = filePath + $"{ModName}.zip";
                    client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                    client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadZip_OnDownloadFileCompleted);

                    client.DownloadFileAsync(fileUri, DownloadedPath);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    client.Dispose();
                }
            }
        }

        internal static async Task<bool> IsLatestInstalled(string dev_mod)
        {
            var release = await LoadLatestModRelease(dev_mod);
            var latestTag = release.Tag_name;
            return (InstalledVersions.Any(x => x.Tag_name.ToLower().Equals(latestTag.ToLower())));
                
        }

        public static bool AutoStart = false;
        public static bool AddShortcut = false;
        public static void DownloadZip_OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            InstallProgress += 10;
            InstallLatestRelease();
            InstallProgress = 100;
            if (AutoStart)
            {
                //Process.Start(ModInstalationPath + "Among Us");
                ProcessStartInfo info = new ProcessStartInfo(ModInstalationPath+"Among Us.exe");
                Process.Start(info);
            }
            else
            {
                MessageBox.Show("Mod installed succesfully!\nYou can find it here: " + ModInstalationPath);
            }
            if (AddShortcut)
            {

            }
            Processing = false;
        }

        public static List<ModModel> InstalledVersions = new List<ModModel>();

        public static bool CheckFolderExists(string folderPath = default)
        {
            string modsFolderPath = $"{ SteamCommPath }\\{ModsFolderName}\\";
            if (folderPath != null)
                modsFolderPath += $"{folderPath}\\";
            DirectoryInfo dir = new DirectoryInfo(modsFolderPath);
            return dir.Exists;
        }

        public static List<ModModel> GetInstalledVersions(string modName)
        {
            List<ModModel> versions = new List<ModModel>();
            string versionsFolderPath = $"{ SteamCommPath }\\{ModsFolderName}\\{modName}\\";
            DirectoryInfo dir = new DirectoryInfo(versionsFolderPath);

            List<DirectoryInfo> versionDirs = dir.GetDirectories().ToList();

            foreach(var versionDir in versionDirs)
            {
                versions.Add(new ModModel
                {
                    Name = modName,
                    Tag_name = versionDir.Name
                });
            }

            return versions;
        }

        
    }
}
