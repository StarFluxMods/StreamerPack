using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class MissMonicaHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "missmonicahat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("MissMonicaHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Glasses").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Golden Chef Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Glasses", new Material[] { MaterialUtils.GetExistingMaterial("Piano Black") });
            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Golden Chef Hat", new Material[] { MaterialUtils.GetExistingMaterial("Paint - Gold") });
        }
    }
}
