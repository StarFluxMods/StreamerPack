using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class LemurHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "lemurhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("LemurHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Lemur Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Lemur Hat", new Material[] {
				MaterialUtils.GetExistingMaterial("Clothing Black"),
				MaterialUtils.GetExistingMaterial("Cashew - Heap"),
				MaterialUtils.GetExistingMaterial("Clothing Black"),
				MaterialUtils.GetExistingMaterial("Egg - Yolk")
			});
        }
    }
}
