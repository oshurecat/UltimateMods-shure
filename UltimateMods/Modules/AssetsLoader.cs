using System.IO;
using System.Reflection;
using UnityEngine;
using Reactor.Utilities.Extensions;

namespace UltimateMods.Modules
{
    public static class Assets
    {
        private static readonly Assembly AudioAssets = Assembly.GetExecutingAssembly();
        private static readonly Assembly SpriteAssets = Assembly.GetExecutingAssembly();
        private static readonly Assembly ButtonAssets = Assembly.GetExecutingAssembly();

        public static AudioClip JesterWinSound;
        public static AudioClip EveryoneLoseSound;

        public static Texture2D Arrow;
        public static Texture2D NormalBanner;
        public static Texture2D HorseBanner;
        public static Texture2D DeadBodySprite;
        public static Texture2D TabSet;
        public static Texture2D TabCrew;
        public static Texture2D TabImp;
        public static Texture2D TabNeu;
        public static Texture2D TabMod;
        public static Texture2D TabOth;

        public static Texture2D CreditsButton;
        public static Texture2D HorseModeOnButton;
        public static Texture2D HorseModeOffButton;
        public static Texture2D EngineerRepairButton;
        public static Texture2D UnderTakerMoveButton;
        public static Texture2D ZoomInButton;
        public static Texture2D ZoomOutButton;

        public static void LoadAssets()
        {
            var AudioAssetsResource = AudioAssets.GetManifestResourceStream("UltimateMods.Resources.AssetsBundlesUM.Assets.ultimateaudio");
            var AudioAssetsBundle = AssetBundle.LoadFromMemory(AudioAssetsResource.ReadFully());

            JesterWinSound = AudioAssetsBundle.LoadAsset<AudioClip>("JesterWin.wav").DontUnload();
            EveryoneLoseSound = AudioAssetsBundle.LoadAsset<AudioClip>("EveryoneLose.wav").DontUnload();

            var SpriteAssetsResource = SpriteAssets.GetManifestResourceStream("UltimateMods.Resources.AssetsBundlesUM.Assets.ultimatesprite");
            var SpriteAssetsBundle = AssetBundle.LoadFromMemory(SpriteAssetsResource.ReadFully());

            Arrow = SpriteAssetsBundle.LoadAsset<Texture2D>("Arrow.png").DontUnload();
            NormalBanner = SpriteAssetsBundle.LoadAsset<Texture2D>("NormalBanner.png").DontUnload();
            HorseBanner = SpriteAssetsBundle.LoadAsset<Texture2D>("HorseBanner.png").DontUnload();
            DeadBodySprite = SpriteAssetsBundle.LoadAsset<Texture2D>("DeadBody.png").DontUnload();
            TabSet = SpriteAssetsBundle.LoadAsset<Texture2D>("MainSettings.png").DontUnload();
            TabCrew = SpriteAssetsBundle.LoadAsset<Texture2D>("CrewmateSettings.png").DontUnload();
            TabImp = SpriteAssetsBundle.LoadAsset<Texture2D>("ImpostorSettings.png").DontUnload();
            TabNeu = SpriteAssetsBundle.LoadAsset<Texture2D>("NeutralSettings.png").DontUnload();
            TabMod = SpriteAssetsBundle.LoadAsset<Texture2D>("ModifierSettings.png").DontUnload();
            TabOth = SpriteAssetsBundle.LoadAsset<Texture2D>("OtherSettings.png").DontUnload();

            var ButtonAssetsResource = ButtonAssets.GetManifestResourceStream("UltimateMods.Resources.AssetsBundlesUM.Assets.ultimatebutton");
            var ButtonAssetsBundle = AssetBundle.LoadFromMemory(ButtonAssetsResource.ReadFully());

            CreditsButton = ButtonAssetsBundle.LoadAsset<Texture2D>("CreditsButton.png").DontUnload();
            HorseModeOnButton = ButtonAssetsBundle.LoadAsset<Texture2D>("HorseModeButtonOn.png").DontUnload();
            HorseModeOffButton = ButtonAssetsBundle.LoadAsset<Texture2D>("HorseModeButtonOff.png").DontUnload();
            EngineerRepairButton = ButtonAssetsBundle.LoadAsset<Texture2D>("EngineerRepairButton.png").DontUnload();
            UnderTakerMoveButton = ButtonAssetsBundle.LoadAsset<Texture2D>("UnderTakerMoveButton.png").DontUnload();
            ZoomInButton = ButtonAssetsBundle.LoadAsset<Texture2D>("ZoomIn.png").DontUnload();
            ZoomOutButton = ButtonAssetsBundle.LoadAsset<Texture2D>("ZoomOut.png").DontUnload();

            AudioAssetsBundle.Unload(false);
            SpriteAssetsBundle.Unload(false);
            ButtonAssetsBundle.Unload(false);
        }
    }
}