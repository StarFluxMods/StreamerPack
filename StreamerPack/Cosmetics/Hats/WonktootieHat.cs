using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class WonktootieHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "wonktootiehat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("WonktootieHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Wonktootie Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Wonktootie Hat", new Material[] {
				MaterialUtils.GetExistingMaterial("Raw Potato - Skin"),
				MaterialUtils.GetExistingMaterial("Clothing Black"),
				MaterialUtils.GetExistingMaterial("Cooked Fish Pink"),
				MaterialUtils.GetExistingMaterial("Floor - Carpet - Red")
			});
        }
    }
}
