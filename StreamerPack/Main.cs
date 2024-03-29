﻿using KitchenLib;
using System.Reflection;
using UnityEngine;
using StreamerPack.Cosmetics.Hats;
using StreamerPack.Cosmetics.Outfits;
using KitchenLib.Event;
using Kitchen;
using System.Collections.Generic;
using KitchenLib.Customs;
using System.Linq;
using System.IO;
#if BEPINEX
using BepInEx;
#endif
#if WORKSHOP
using KitchenMods;
#endif

namespace StreamerPack
{
#if BEPINEX
	[BepInProcess("PlateUp.exe")]
	[BepInPlugin("streamerpack", "Streamer Outfit Pack", "0.1.5")]
#endif
	public class Main : BaseMod
	{
		public Main() : base("streamerpack", "Streamer Outfit Pack", "StarFluxGames", "0.1.6", ">=1.1.4", Assembly.GetExecutingAssembly()) { }

		public static AssetBundle bundle;
		public static List<int> OutfitIDS = new List<int>();
		public static List<int> HatIDS = new List<int>();

		public static List<string> OutfitNames = new List<string>();
		public static List<string> HatNames = new List<string>();
#if WORKSHOP
		protected override void OnPostActivate(Mod mod)
#else
		protected override void OnInitialise()
#endif
		{

#if WORKSHOP
			bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).ToList()[0];
#else
			bundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "streamerpack.assets"));
#endif

			RegisterOutfit<SipsOutfit>("Sips Outfit");
			
			RegisterOutfit<PedguinOutfit>("Pedguin Outfit");
			RegisterOutfit<HafuOutfit>("Hafu Outfit");
			RegisterOutfit<OntaioOutfit>("Ontaio Outfit");
			RegisterOutfit<WonktootieOutfit>("Wonktootie Outfit");
			RegisterOutfit<MissMonicaOutfit>("Miss Monica Outfit");
			RegisterOutfit<DytolanOutfit>("Dytolan Outfit");
			RegisterOutfit<ElseeOutfit>("Elsee Outfit");
			RegisterOutfit<CourtillyOutfit>("Courtilly Outfit");

			RegisterHat<CranchanHat>("Cranchan Hat");
			RegisterHat<CourtillyHat>("Courtilly Hat");
			RegisterHat<ItsGNGHat>("ItsGNG Hat");
			RegisterHat<LemurHat>("Lemur Hat");
			RegisterHat<OntarioHat>("Ontario Hat");
			RegisterHat<KulutuesHat>("Kulutues Hat");
			RegisterHat<PedguinHat>("Pedguin Hat");
			RegisterHat<SkootieHat>("Skootie Hat");
			RegisterHat<WonktootieHat>("Wonktootie Hat");
			RegisterHat<MissMonicaHat>("Miss Monica Hat");
			RegisterHat<CrispyfxHat>("Crispyfx Hat");
			RegisterHat<HatfilmsHat>("Hatfilms Hat");
			RegisterHat<Junkyard129Hat>("Junkyard129 Hat");
			RegisterHat<StumptHat>("Stumpt Hat");
			RegisterHat<DytolanHat>("Dytolan Hat");
			RegisterHat<FreedsirenHat>("Freedsiren Hat");
			RegisterHat<DrGluonHat>("Dr Gluon Hat");
			RegisterHat<TristerTwisterHat>("Trister Twister Hat");
			

			ModsPreferencesMenu<PauseMenuAction>.RegisterMenu("Streamer Outfit Pack", typeof(OutfitSelectionMenu<PauseMenuAction>), typeof(PauseMenuAction));

			Events.PreferenceMenu_PauseMenu_CreateSubmenusEvent += (s, args) => {
				args.Menus.Add(typeof(OutfitSelectionMenu<PauseMenuAction>), new OutfitSelectionMenu<PauseMenuAction>(args.Container, args.Module_list));
			};
		}

		public void RegisterOutfit<T>(string displayName) where T : CustomPlayerCosmetic, new()
		{
			CustomPlayerCosmetic outfit = AddGameDataObject<T>();
			OutfitIDS.Add(outfit.ID);
			OutfitNames.Add(displayName);
		}

		public void RegisterHat<T>(string displayName) where T : CustomPlayerCosmetic, new()
		{
			CustomPlayerCosmetic outfit = AddGameDataObject<T>();
			HatIDS.Add(outfit.ID);
			HatNames.Add(displayName);
		}
	}
}