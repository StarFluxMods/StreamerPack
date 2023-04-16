using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class ElseeOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "ElseeOutfit";
		public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("ElseeOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Suit").GetComponent<SkinnedMeshRenderer>());
        }
    }
}
