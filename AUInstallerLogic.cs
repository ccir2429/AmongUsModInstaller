using AmongUsModLauncher.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmongUsModLauncher
{
    partial class AUInstallerForm
    {
        private async Task GetModReleaseFromGit(ModModel mod)
        {
            List<ModModel> modReleases;
            try
            {
                if (ModProcessor.Processing)
                    return;
                ModProcessor.Processing = true;
                // if selected mod has custom version skip loading assets
                ModModel release = mod;
                if (!mod.Is_custom_version)
                {
                    release = await ModProcessor.LoadModReleases(mod.Dev_mod);
                    release.Name = mod.Name;
                }

                ModProcessor.Version = release.Tag_name;
                ModProcessor.ModName = release.Name;
                ModProcessor.AutoStart = chkAutoStart.Checked;
                ModProcessor.AddShortcut = chkShortcut.Checked;

                #region DownloadZip_Mod
                var zipDataDownloadUrl = release.Assets.Count > 0 ? release.Assets[0] : null;
                if (zipDataDownloadUrl == null) throw new Exception("No zip file found!");
                string steamPath = txtPath.Text;
                bool didReqDownload = ModProcessor.DownloadModRelease(zipDataDownloadUrl.Browser_download_url, steamPath);
                #endregion DownloadZip_Mod

                if (!didReqDownload)
                    throw new Exception("Error while downloading content");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
