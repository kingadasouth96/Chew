using System.Collections.Generic;
using Rust;
using System;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Oxide.Core;
using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;
using UnityEngine;
using Facepunch;

namespace Oxide.Plugins
{
    [Info("Chew Food", "Kingadasouth96", "1.0.0")]
    [Description("Quickly eat food to retrieve the seeds for farming.")]
    public class ChewFood : RustPlugin
    {
        [PluginReference] private Plugin RustTranslationAPI;
        private const string PERMISSION_USE = "chewfood.use";
        private void Init()
        {
            permission.RegisterPermission(PERMISSION_USE, this);
            cmd.AddChatCommand(config.command, this, nameof(cmdChewChat));
        }

        private void cmdChewChat(BasePlayer player)
        {
            if (!permission.UserHasPermission(player.UserIDString, PERMISSION_USE)) return;
            ChewYellow(player);
            ChewBlue(player);
            ChewRed(player);
            ChewWhite(player);
            ChewGreen(player);
            ChewBlack(player);
            ChewPumpkin(player);
            ChewCorn(player);
            ChewTatter(player);
        }


        private void ChewBlue(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "blue.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.blue.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewRed(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "red.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.red.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewYellow(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "yellow.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.yellow.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewWhite(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "white.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.white.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewGreen(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "green.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.green.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewBlack(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "black.berry").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Berries");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.black.berry", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewPumpkin(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "pumpkin").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No Pumkins");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.pumpkin", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewCorn(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "corn").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No corn");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.corn", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
        }

        private void ChewTatter(BasePlayer player)
        {
            var berryList = player.inventory.AllItems().Where(x => x.info.shortname == "potato").ToList();
            if (berryList.Count == 0)
            {
                Message(player, "No potatoes");
                return;
            }
            var countBerry = berryList.Sum(x => x.amount);
            var countSeeds = Convert.ToInt32(countBerry * config.rate);
            var seeds = ItemManager.CreateByName("seed.potato", countSeeds);
            foreach (var berry in berryList)
            {
                berry.GetHeldEntity()?.Kill();
                berry.Remove();
            }
            player.GiveItem(seeds);
            Message(player, "Finished Chewing");
        }

        private static ConfigData config;

        private class ConfigData
        {
            [JsonProperty(PropertyName = "Command")]
            public string command;

            [JsonProperty(PropertyName = "Rate")]
            public float rate;
        }

        private ConfigData GetDefaultConfig()
        {
            return new ConfigData
            {
                command = "chew",
                rate = 1
            };
        }

        protected override void LoadConfig()
        {
            base.LoadConfig();

            try
            {
                config = Config.ReadObject<ConfigData>();

                if (config == null)
                {
                    LoadDefaultConfig();
                }
            }
            catch
            {
                PrintError("Configuration file is corrupt! Unloading plugin...");
                Interface.Oxide.RootPluginManager.RemovePlugin(this);
                return;
            }

            SaveConfig();
        }

        protected override void LoadDefaultConfig()
        {
            config = GetDefaultConfig();
        }

        protected override void SaveConfig()
        {
            Config.WriteObject(config);
        }



        protected override void LoadDefaultMessages()
        {
            lang.RegisterMessages(new Dictionary<string, string>
            {
                {"No Berries", "You don't have berries to chew!."},
                {"Finished Chewing", "You chewed berries x{0} into seeds x{1}"},
            }, this);
        }

        private void Message(BasePlayer player, string messageKey, params object[] args)
        {
            if (player == null)
            {
                return;
            }

            var message = GetMessage(messageKey, player.UserIDString, args);
            player.SendConsoleCommand("chat.add", (object)0, (object)message);
        }

        private string GetMessage(string messageKey, string playerID, params object[] args)
        {
            return string.Format(lang.GetMessage(messageKey, this, playerID), args);
        }


    }
}