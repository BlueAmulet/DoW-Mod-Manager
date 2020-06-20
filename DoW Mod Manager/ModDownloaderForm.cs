﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DoW_Mod_Manager
{
    public partial class ModDownloaderForm : Form
    {
        public class Mod
        {
            public string Name;
            public string SiteLink;
            public string DownloadLink;
            public string PatchLink;

            public Mod (string name, string siteLink, string modDownloadLink, string patchDwonloadLink)
            {
                Name = name;
                SiteLink = siteLink;
                DownloadLink = modDownloadLink;
                PatchLink = patchDwonloadLink;
            }
        }

        private const string SEARCH_TEXT = "Search...";
        private readonly List<Mod> modlist = new List<Mod>();

        private readonly ModManagerForm modManager;
        
        public ModDownloaderForm(ModManagerForm form)
        {
            InitializeComponent();

            modManager = form;

            // Use the same icon as executable
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            if (modManager.CurrentGameEXE == ModManagerForm.GameExecutable.SOULSTORM)
            {
                popularModsLabel.Text += "Soulstorm:";

                modlist.Add(new Mod("Adeptus Mechanicus: Explorators mod",
                    "https://www.moddb.com/mods/adeptus-mechanicus",
                    "https://www.moddb.com/downloads/start/122435?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fadeptus-mechanicus%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Black Templars - No Remorse! No Fear!",
                    "https://www.moddb.com/mods/black-templars-kaurava-crusade",
                    "https://www.moddb.com/downloads/start/47751?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fblack-templars-kaurava-crusade%2Fdownloads",
                    "https://www.moddb.com/downloads/start/93653?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fblack-templars-kaurava-crusade%2Fdownloads"));

                modlist.Add(new Mod("Blood Angels mod: By the Blood of Sanguinius!",
                    "https://www.moddb.com/mods/stevocarty",
                    "https://www.moddb.com/downloads/start/103615?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fstevocarty%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Chaos Daemons Mod",
                    "https://www.moddb.com/mods/daemons-mod",
                    "https://www.moddb.com/downloads/start/93757?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdaemons-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("CornCobMan\'s Fun Mod",
                    "https://www.moddb.com/mods/corncobmans-fun-mod-for-soulstorm",
                    "https://www.moddb.com/downloads/start/196090?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fcorncobmans-fun-mod-for-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Dark Angels mod: Repent! For tomorrow you die!",
                    "https://www.moddb.com/mods/dark-angels-mod",
                    "https://www.moddb.com/downloads/start/179584?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdark-angels-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Dawn of War: Strongholds",
                    "https://www.moddb.com/mods/soulstorm-strongholds",
                    "https://www.moddb.com/downloads/start/136305?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsoulstorm-strongholds%2Fdownloads",
                    "https://www.moddb.com/downloads/start/195179?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsoulstorm-strongholds%2Fdownloads"));

                modlist.Add(new Mod("DoWPro",
                    "https://www.moddb.com/mods/dowpro",
                    "https://www.moddb.com/downloads/start/182958?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdowpro%2Fdownloads",
                    ""));

                modlist.Add(new Mod("DoW40k: Firestorm over Kaurava",
                    "https://www.moddb.com/mods/dawn-of-warhammer-40k-firestorm-over-kronus",
                    "https://www.moddb.com/downloads/start/82196?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdawn-of-warhammer-40k-firestorm-over-kronus%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Emperor\'s Children mod:For the Glory of Slaanesh!",
                    "https://www.moddb.com/mods/emperors-children-modfor-the-glory-of-slaanesh",
                    "https://www.moddb.com/downloads/start/178558?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Femperors-children-modfor-the-glory-of-slaanesh%2Fdownloads",
                    ""));

                modlist.Add(new Mod("FreeUI",
                    "https://www.moddb.com/mods/unification-mod-dawn-of-war-soulstorm/downloads/freeui",
                    "https://www.moddb.com/downloads/start/132081?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Funification-mod-dawn-of-war-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Hard_mod",
                    "https://www.moddb.com/mods/hard-mod",
                    "https://www.moddb.com/downloads/start/174556?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fhard-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("HD Dawn Of War",
                    "https://www.moddb.com/mods/sister-of-battle-hd-retextures-by-leonardgoog",
                    "https://www.moddb.com/downloads/start/63755?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsister-of-battle-hd-retextures-by-leonardgoog%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Inquisition: Daemonhunt",
                    "https://www.moddb.com/mods/daemonhunters-mod",
                    "https://www.moddb.com/downloads/start/177251?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdaemonhunters-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Legion of the Damned mod: In dedicato imperatum!",
                    "https://www.moddb.com/mods/legion-of-the-damned-modification-for-soulstorm",
                    "https://www.moddb.com/downloads/start/108154?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Flegion-of-the-damned-modification-for-soulstorm%2Fdownloads",
                    "https://www.moddb.com/downloads/start/122434?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Flegion-of-the-damned-modification-for-soulstorm%2Fdownloads"));

                modlist.Add(new Mod("Men of Praetoria",
                    "https://www.moddb.com/mods/men-of-praetoria",
                    "https://www.moddb.com/downloads/start/116144?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fmen-of-praetoria%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Night Lords mod: We have come for you!",
                    "https://www.moddb.com/mods/night-lords-modification-for-soulstorm",
                    "https://www.moddb.com/downloads/start/140247?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fnight-lords-modification-for-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Objective Points SS",
                    "https://www.moddb.com/mods/unification-mod-dawn-of-war-soulstorm/downloads/objective-points-ss-v1742020-for-dowdc-and-dowss",
                    "https://www.moddb.com/downloads/start/192702?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Funification-mod-dawn-of-war-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("RAGE:World Eaters Warbands",
                    "https://www.moddb.com/mods/rage-world-eaters-warband",
                    "https://www.moddb.com/downloads/start/101179?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Frage-world-eaters-warband%2Fdownloads",
                    "https://www.moddb.com/downloads/start/101765?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Frage-world-eaters-warband%2Fdownloads"));

                modlist.Add(new Mod("Redux Mod",
                    "https://www.moddb.com/mods/eranthis-project",
                    "https://www.moddb.com/downloads/start/190876?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Feranthis-project%2Fdownloads",
                    "https://www.moddb.com/downloads/start/195426?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Feranthis-project%2Fdownloads"));

                modlist.Add(new Mod("Renegade Guard",
                    "https://www.moddb.com/mods/renegade-guard",
                    "https://www.moddb.com/downloads/start/135315?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Frenegade-guard%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Salamanders mod REFORGED: Unto the Anvil of War!",
                    "https://www.moddb.com/mods/salamanders-mod-for-soulstorm",
                    "https://www.moddb.com/downloads/start/184518?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsalamanders-mod-for-soulstorm%2Fdownloads",
                    "https://www.moddb.com/downloads/start/184624?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsalamanders-mod-for-soulstorm%2Fdownloads"));

                modlist.Add(new Mod("Space Wolves",
                    "https://www.moddb.com/mods/space-wolves",
                    "https://www.moddb.com/downloads/start/189241?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fspace-wolves%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Steel Legion - Armageddon",
                    "https://www.moddb.com/mods/steel-legion-armageddon",
                    "http://www.mediafire.com/?etfl8eu94mkmbyk",
                    "http://www.mediafire.com/file/ec7st9hj8lnry7h/Steel_Legions_SS_1.0_Simple+Patch.rar"));

                modlist.Add(new Mod("Soulstorm Bugfix Mod",
                    "https://www.moddb.com/mods/soulstorm-bugfix-mod",
                    "https://www.moddb.com/downloads/start/124372?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fsoulstorm-bugfix-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Tartarus and Lorn V Campaigns for Soulstorm",
                    "https://www.moddb.com/mods/tartarus-and-lorn-v-campaigns-for-soulstorm",
                    "https://www.moddb.com/downloads/start/170256?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftartarus-and-lorn-v-campaigns-for-soulstorm%2Fdownloads",
                    "https://www.moddb.com/downloads/start/170654?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftartarus-and-lorn-v-campaigns-for-soulstorm%2Fdownloads"));

                modlist.Add(new Mod("The Dance Macabre - Harlequins Mod",
                    "https://www.moddb.com/mods/the-dance-macabre-harlequins-mod-for-soulstorm",
                    "https://www.moddb.com/downloads/start/181447?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fthe-dance-macabre-harlequins-mod-for-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Thirteenth Company Mod",
                    "https://www.moddb.com/mods/thirteenth-company-mod-for-dawn-of-war-soulstorm",
                    "https://www.moddb.com/downloads/start/176576?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fthirteenth-company-mod-for-dawn-of-war-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Thousand Sons mod: Knowledge Is Power!",
                    "https://www.moddb.com/mods/thousand-sons-mod",
                    "https://www.moddb.com/downloads/start/116283?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fthousand-sons-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Titanium Wars Mod for Soulstorm",
                    "https://www.moddb.com/mods/titanium-wars-mod-ss",
                    "https://rutracker.org/forum/dl.php?t=4859187",
                    ""));

                modlist.Add(new Mod("Tyranid Mod",
                    "https://www.moddb.com/mods/tyranid-mod",
                    "https://www.moddb.com/downloads/start/46895?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftyranid-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Unification Mod",
                    "https://www.moddb.com/mods/unification-mod-dawn-of-war-soulstorm",
                    "https://www.moddb.com/downloads/start/132080?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Funification-mod-dawn-of-war-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Ultimate Apocalypse Mod",
                    "https://www.moddb.com/mods/ultimate-apocalypse-mod",
                    "https://www.moddb.com/downloads/start/192014?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fultimate-apocalypse-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Vostroyan Firstborn Modification for Soulstorm",
                    "https://www.moddb.com/mods/vostroyan-firstborn-modification-for-soulstorm",
                    "https://www.moddb.com/downloads/start/127232?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fvostroyan-firstborn-modification-for-soulstorm%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Witch Hunters: Adepta Sororitas",
                    "https://www.moddb.com/mods/witch-hunters-mod-for-soulstorm",
                    "https://www.moddb.com/downloads/start/177550?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fwitch-hunters-mod-for-soulstorm%2Fdownloads",
                    ""));
            }
            else if (modManager.CurrentGameEXE == ModManagerForm.GameExecutable.DARK_CRUSADE)
            {
                popularModsLabel.Text += "Dark Crusade:";

                modlist.Add(new Mod("Dawn of Steel - Steel Legion Mod",
                    "https://www.moddb.com/games/dawn-of-war-dark-crusade/addons/dawn-of-steel-steel-legion-mod-1-0",
                    "https://www.moddb.com/addons/start/152298",
                    ""));

                modlist.Add(new Mod("Dawn of War: Dark Crusade Bugfix Mod",
                    "https://www.moddb.com/mods/dawn-of-war-dark-crusade-bugfix-mod",
                    "https://www.moddb.com/downloads/start/144937?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdawn-of-war-dark-crusade-bugfix-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("DoWPro",
                    "https://www.moddb.com/mods/dowpro",
                    "https://www.moddb.com/downloads/start/12671?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdowpro%2Fdownloads",
                    "https://www.moddb.com/downloads/start/12733?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdowpro%2Fdownloads"));

                modlist.Add(new Mod("Firestorm over Kronus",
                    "http://fok.dow-mods.com/viewtopic.php?f=141&t=4234",
                    "http://www.moddb.com/downloads/start/23967",
                    ""));

                modlist.Add(new Mod("Inquisition: Daemonhunt",
                    "https://www.moddb.com/mods/daemonhunters-mod",
                    "http://download1347.mediafire.com/delol5z1m9dg/zc41u4pexbg5rua/inquisition_daemonhunt_mod+DC.zip",
                    ""));

                modlist.Add(new Mod("D.O.W. Kingdom",
                    "https://www.moddb.com/mods/dow-kingdom",
                    "https://www.moddb.com/downloads/start/8179?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdow-kingdom%2Fdownloads",
                    ""));

                modlist.Add(new Mod("M42",
                    "https://www.moddb.com/mods/m42-dark-crusade",
                    "https://www.moddb.com/downloads/start/184047?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fm42-dark-crusade%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Tabletop Round-up",
                    "https://www.moddb.com/mods/tabletop-round-up",
                    "https://www.moddb.com/downloads/start/9231?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftabletop-round-up%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Titanium Wars Mod",
                    "https://www.moddb.com/mods/titanium-wars-mod",
                    "https://rutracker.org/forum/dl.php?t=4859187",
                    ""));

                modlist.Add(new Mod("Tyranid Mod",
                    "https://www.moddb.com/mods/tyranid-mod",
                    "https://www.moddb.com/downloads/start/11333?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftyranid-mod%2Fdownloads",
                    "https://www.moddb.com/downloads/start/11362?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftyranid-mod%2Fdownloads"));

                modlist.Add(new Mod("Updated Campaign Mod",
                    "https://www.moddb.com/mods/dc-updated-campaign-mod",
                    "https://www.moddb.com/downloads/start/75192?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdc-updated-campaign-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Veteran Mod",
                    "https://www.moddb.com/mods/dc-veteran-mod",
                    "https://www.moddb.com/downloads/start/131673?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdc-veteran-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Witch Hunters: Adepta Sororitas",
                    "https://www.moddb.com/mods/witch-hunters-mod-for-soulstorm",
                    "https://www.gamefront.com/files/witch-hunters-mod-beta/download",
                    ""));
            }
            else if (modManager.CurrentGameEXE == ModManagerForm.GameExecutable.WINTER_ASSAULT)
            {
                popularModsLabel.Text += "Winter Assault:";

                modlist.Add(new Mod("Dawn of Steel",
                    "https://www.moddb.com/mods/steel-legion-armageddon",
                    "https://www.moddb.com/downloads/start/165510?referer=https%3A%2F%2Fwww.google.com%2F",
                    ""));

                modlist.Add(new Mod("DoWPro",
                    "https://www.moddb.com/mods/dowpro",
                    "https://www.moddb.com/downloads/start/6548?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdowpro%2Fdownloads",
                    "https://www.moddb.com/downloads/start/6549?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fdowpro%2Fdownloads"));

                modlist.Add(new Mod("Necrons Mod - Mike's version",
                    "https://www.moddb.com/mods/necrons-mod",
                    "https://www.moddb.com/downloads/start/64724?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fnecrons-mod%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Tabletop Round-up",
                    "https://www.moddb.com/mods/tabletop-round-up",
                    "https://www.moddb.com/downloads/start/5311?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftabletop-round-up%2Fdownloads",
                    ""));

                modlist.Add(new Mod("Total War: Winter Assault",
                    "https://www.moddb.com/mods/total-war-winter-assault",
                    "https://www.moddb.com/downloads/start/1266?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Ftotal-war-winter-assault%2Fdownloads",
                    ""));

                modlist.Add(new Mod("WXP Necron Mod",
                    "https://www.moddb.com/mods/wxp-necron-mod",
                    "https://www.moddb.com/downloads/start/76841?referer=https%3A%2F%2Fwww.moddb.com%2Fmods%2Fwxp-necron-mod%2Fdownloads",
                    ""));
            }
            else if (modManager.CurrentGameEXE == ModManagerForm.GameExecutable.ORIGINAL)
            {
                popularModsLabel.Text += "Original:";

                modlist.Add(new Mod("First I have to find a few mods for Original :-)",
                    "",
                    "",
                    ""));

                openModPageButton.Enabled = false;
                downloadModButton.Enabled = false;
            }

            for (int i = 0; i < modlist.Count; i++)
            {
                modListBox.Items.Add(modlist[i].Name);
            }

            modListBox.Select();
        }

        private void OpenModDBButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.moddb.com/games/dawn-of-war/mods?sort=rating-desc");
        }

        private void OpenModPageButton_Click(object sender, EventArgs e)
        {
            if (modListBox.SelectedItem == null)
                return;
            
            string siteAddress = "";

            for (int i = 0; i < modlist.Count; i++)
            {
                if (modListBox.SelectedItem.ToString() == modlist[i].Name)
                    siteAddress = modlist[i].SiteLink;
            }

            if (siteAddress.Length > 0)
                Process.Start(siteAddress);
        }

        private void DownloadModButton_Click(object sender, EventArgs e)
        {
            if (modListBox.SelectedItem == null)
                return;

            string modAddress = "";
            string patchAddress = "";

            for (int i = 0; i < modlist.Count; i++)
            {
                if (modListBox.SelectedItem.ToString() == modlist[i].Name)
                    modAddress = modlist[i].DownloadLink;

                if (modListBox.SelectedItem.ToString() == modlist[i].Name)
                    patchAddress = modlist[i].PatchLink;
            }

            if (modAddress.Length > 0)
                Process.Start(modAddress);

            if (patchAddress.Length > 0)
            {
                Thread.Sleep(250);                                               // Some small delay before trying to download second file
                Process.Start(modAddress);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0 && searchTextBox.Text != SEARCH_TEXT)
            {
                modListBox.Items.Clear();

                for (int i = 0; i < modlist.Count; i++)
                {
                    string modLowerCase = modlist[i].Name.ToLower();
                    string searchLowerCase = searchTextBox.Text.ToLower();

                    if (modLowerCase.Contains(searchLowerCase))
                    {
                        modListBox.Items.Add(modlist[i].Name);
                    }
                }
            }
            else
            {
                modListBox.Items.Clear();

                for (int i = 0; i < modlist.Count; i++)
                {
                    modListBox.Items.Add(modlist[i].Name);
                }
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == SEARCH_TEXT)
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = SEARCH_TEXT;
                searchTextBox.ForeColor = Color.Gray;
            }
        }
    }
}