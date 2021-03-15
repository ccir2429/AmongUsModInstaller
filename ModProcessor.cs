using AmongUsModLauncher.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static string ModsFolderName { get; set; } = "Among Us Mods";
        private static void InstallLatestRelease(string modName, string steamPath)
        {
            CreateGameCopy($"{ modName } - {Version}", ModsFolderName, steamPath);
        }
        private static string ModFolderPath;
        private static void CreateGameCopy(string modName, string modsFolderName, string steamCommonsPath)
        {
            string modsFolderPath = $"{ steamCommonsPath }{modsFolderName}\\";
            #region init_All_Mods_folder
            DirectoryInfo dir = new DirectoryInfo(modsFolderPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(modsFolderPath);
            }
            #endregion init_All_Mods_folder

            // CopyAmongUs
            ModFolderPath = modsFolderPath + modName;
            DirectoryCopy(steamCommonsPath + "Among Us", ModFolderPath, true);

            // UnzipArchive
            ZipFile.ExtractToDirectory(DownloadedPath, ModFolderPath);
            if (File.Exists(DownloadedPath))
                File.Delete(DownloadedPath);
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DropAndCreate(destDirName);
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();

                // If the destination directory doesn't exist, create it.       
                Directory.CreateDirectory(destDirName);

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
        public static async Task<List<ModModel>> LoadModReleases(string dev_modName)
        {
            string url = $"http://api.github.com/repos/{ dev_modName }/releases";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<ModModel> allReleases = await response.Content.ReadAsAsync<List<ModModel>>();

                    return allReleases;
                }
                else
                {
                    throw new Exception("Incorrect mod or developer name");
                }
            }
        }
        public static string DownloadedPath { get; private set; } = string.Empty;
        private static string SteamCommPath;
        public static bool DownloadModRelease(string zipDownloadUrl, string fileName, string steamPath)
        {
            using (var client = new WebClient())
            {
                try
                {
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

        public static void DownloadZip_OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            InstallLatestRelease(ModName, SteamCommPath);
            MessageBox.Show("Mod installed succesfully!\nYou can find it here: " + ModFolderPath);
        }
    }
}
