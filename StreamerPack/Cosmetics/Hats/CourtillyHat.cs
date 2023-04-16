using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class CourtillyHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "CourtillyHat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("CourtillyHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Courtilly Hat").GetComponent<SkinnedMeshRenderer>());
        }
    }
}
