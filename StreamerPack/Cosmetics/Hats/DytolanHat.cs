using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class DytolanHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "dytolanhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("DytolanHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Dytolan Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Dytolan Hat", new Material[] {
				MaterialUtils.GetExistingMaterial("Clothing Black"),
				MaterialUtils.GetExistingMaterial("Olive"),
				MaterialUtils.GetExistingMaterial("Paint - Blue"),
				MaterialUtils.GetExistingMaterial("Paper - Postit Green"),
				MaterialUtils.GetExistingMaterial("Painting - Yellow"),
				MaterialUtils.GetExistingMaterial("Pumpkin"),
				MaterialUtils.GetExistingMaterial("AppleRed")
			});
        }
    }
}
