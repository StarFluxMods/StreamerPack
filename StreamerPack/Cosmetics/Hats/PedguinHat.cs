using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class PedguinHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "pedguinhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("PedguinHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Pedguin Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Pedguin Hat", new Material[] {
				MaterialUtils.GetExistingMaterial("Cheese - Default"),
				MaterialUtils.GetExistingMaterial("Clothing Black"),
				MaterialUtils.GetExistingMaterial("Plastic - Blue"),
				MaterialUtils.GetExistingMaterial("Egg - White")
			});
        }
    }
}
