using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class CranchanHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "cranchanhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("CranchanHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Cranchan Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Cranchan Hat", new Material[] {
                MaterialUtils.GetExistingMaterial("AppleGreen"),
                MaterialUtils.GetExistingMaterial("Strawberry") ,
                MaterialUtils.GetExistingMaterial("Clothing Black") });
        }
    }
}
