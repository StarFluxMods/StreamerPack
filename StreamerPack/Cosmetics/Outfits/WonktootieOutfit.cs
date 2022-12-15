using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class WonktootieOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "wonktootieoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("WonktootieOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Wonktootie Sweater").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Wonktootie Sweater", new Material[] {
                MaterialUtils.GetExistingMaterial("Egg - White"),
                MaterialUtils.GetExistingMaterial("Raw Potato - Skin"),
                MaterialUtils.GetExistingMaterial("Coffee - Black"),
                MaterialUtils.GetExistingMaterial("Floor - Carpet - Red"),
                MaterialUtils.GetExistingMaterial("Clothing Black"),
                MaterialUtils.GetExistingMaterial("Cooked Fish Pink")
            });
        }
    }
}
