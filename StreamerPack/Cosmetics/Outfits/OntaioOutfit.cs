using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class OntaioOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "ontariooutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("OntarioOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Ontario Shirt").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Ontario Pants").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Ontario Shirt", new Material[] { MaterialUtils.GetExistingMaterial("Egg - White") });
            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Ontario Pants", new Material[] { MaterialUtils.GetExistingMaterial("Plastic - Blue") });
        }
    }
}