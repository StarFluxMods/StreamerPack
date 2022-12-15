using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class ItsGNGHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "itsgnghat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("ItsGNGHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "ItsGNG Hat").GetComponent<SkinnedMeshRenderer>());
			
            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "ItsGNG Hat", new Material[] { MaterialUtils.GetExistingMaterial("Cooked Batter") });
        }
    }
}
