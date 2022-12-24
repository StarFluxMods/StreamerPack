using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class StumptHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "stumpthat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("StumptHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Stumpt Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Stumpt Hat", new Material[] {
				MaterialUtils.GetExistingMaterial("Bread - Cooked"),
				MaterialUtils.GetExistingMaterial("Bread - Bun"),
				MaterialUtils.GetExistingMaterial("Bread - Inside Cooked"),
				MaterialUtils.GetExistingMaterial("Clothing Black") });
		}
    }
}
