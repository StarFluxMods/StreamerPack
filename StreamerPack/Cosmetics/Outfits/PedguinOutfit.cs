using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class PedguinOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "pedguinoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("PedguinOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Pedguin Outfit").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Pedguin Outfit", new Material[] {
                MaterialUtils.GetExistingMaterial("Plastic - Blue"),
                MaterialUtils.GetExistingMaterial("Egg - White") });
        }
    }
}