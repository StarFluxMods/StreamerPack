using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class TristerTwisterHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "tristertwisterhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("Trister_Twister_Hat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "TristerTwister Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "TristerTwister Hat", new Material[] {
                MaterialUtils.GetExistingMaterial("Raw Fish Blue Fin"),
                MaterialUtils.GetExistingMaterial("Egg - White") ,
                MaterialUtils.GetExistingMaterial("Clothing Black") });
        }
    }
}
