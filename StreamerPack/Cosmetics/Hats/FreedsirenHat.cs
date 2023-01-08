using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Hats
{
    public class FreedsirenHat : CustomPlayerCosmetic
    {
		public override string UniqueNameID => "freedsirenhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("FreedsirenHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Elmo Hat").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Elmo Hat", new Material[] {
                MaterialUtils.GetCustomMaterial("Elmo"),
                //MaterialUtils.GetExistingMaterial("Pipe Danger"),
                MaterialUtils.GetExistingMaterial("Pumpkin") ,
                MaterialUtils.GetExistingMaterial("Clothing Black") ,
                MaterialUtils.GetExistingMaterial("Egg - White") });
        }
    }
}
