using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace StreamerPack.Cosmetics.Outfits
{
    public class MissMonicaOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "missmonicaoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("MissMonicaOutfit");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Cylinder.001").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Miss Monica's Apron").GetComponent<SkinnedMeshRenderer>());

			MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Cylinder.001", new Material[] {
				MaterialUtils.GetExistingMaterial("Sea"),
				MaterialUtils.GetExistingMaterial("Sack - White"),
				MaterialUtils.GetExistingMaterial("Raw Fillet Skin 2"),
				MaterialUtils.GetExistingMaterial("Sea")
			});

			MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Miss Monica's Apron", new Material[] { MaterialUtils.GetExistingMaterial("Metal") });
		}
    }
}
