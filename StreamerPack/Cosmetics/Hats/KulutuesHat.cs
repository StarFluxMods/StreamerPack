using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class KulutuesHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "KulutuesHat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("KulutuesHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Head.baked.baked").GetComponent<SkinnedMeshRenderer>());
        }
    }
}
