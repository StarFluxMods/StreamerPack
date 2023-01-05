using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class DytolanOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "dytolanoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("DytolanOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Suit").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Suit", new Material[] {
                MaterialUtils.GetExistingMaterial("Clothing Black"),
                MaterialUtils.GetExistingMaterial("Plastic - Black Dark"),
                MaterialUtils.GetExistingMaterial("Bread - Inside"),
                MaterialUtils.GetExistingMaterial("Book Cover - Red"),
                MaterialUtils.GetExistingMaterial("Plastic - Black Dark")
            });
        }
    }
}
