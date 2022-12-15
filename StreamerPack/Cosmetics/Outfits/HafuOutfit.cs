using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class HafuOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "hafuoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("HafuOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Hafu Sweater").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Hafu Sweater", new Material[] {
                MaterialUtils.GetExistingMaterial("Cheese - Default"),
                MaterialUtils.GetExistingMaterial("Egg - White"),
                MaterialUtils.GetExistingMaterial("Clothing Black")
            });
        }
    }
}
