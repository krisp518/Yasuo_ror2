using System;
//using RoR2;
using UnityEngine;
using R2API;
using BepInEx;

namespace Yasuo;
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.IDontHaveOne.Yasuo", "Yasuo", "1.0.0")]
    public class Yasuo : BaseUnityPlugin
    {

    public static GameObject yasuoPrefab;
    public GameObject yasuoDisplay; 

        public void Awake()
        {
            // Assets.PopulateAssets(); 

        }

        private static GameObject CreateModel(GameObject main)
        {
            Destroy(main.transform.Find("ModelBase").gameObject);
            Destroy(main.transform.Find("CameraPivot").gameObject);
            Destroy(main.transform.Find("AimOrigin").gameObject);

            GameObject model = Assets.MainAssetBundle.LoadAsset<GameObject>("Yasuo");

            return model; 
        }
    }

    public static class Assets
    {
        public static AssetBundle MainAssetBundle = null;
        //public static AssetBundleResourcesProvider Provider;

        public static GameObject Yasuo; 
    }

    /*public static void PopulateAssets()
    {
        if(MainAssetBundle == null)
        {
            using (Stream assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Yasuo.myassetbundle)){
                MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                Provider = new AssetBundleResourcesProvider("@Yasuo", MainAssetBundle); 
                R2API.ResourcesAPI.AddProvider(Provider); 
            }
        }
    }

    Yasuo = MainAssetBundle.LoadAsset<GameObject>("filler"); 
    */

