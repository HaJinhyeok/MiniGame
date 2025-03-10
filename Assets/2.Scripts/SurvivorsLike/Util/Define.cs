public class Define
{
    public const string Top3UIName = "UI_Top3";

    #region Tag
    public const string PlayerTag = "Player";
    public const string EnemyTag = "Enemy";
    public const string ShotTag = "Shot";
    public const string ExplosionTag = "Explosion";

    public const string PanelTag = "Panel";
    public const string LevelUpPanelTag = "LevelUpPanel";
    public const string FilledImageTag = "FilledImage";
    #endregion

    #region Path
    public const string PlayerPath = "Prefabs/Player";

    public const string EnemyDogPath = "Prefabs/Enemy_Dog";
    public const string EnemyHoodPath = "Prefabs/Enemy_Hood";
    public const string EnemySlimePath = "Prefabs/Enemy_Slime";

    public const string ShotPath = "Prefabs/Shot";
    public const string ExplosionPath = "Prefabs/Explosion";
    public const string PickaxePath = "Prefabs/Pickaxe";
    public const string PickaxeDroppedPath = "Prefabs/Pickaxe_Dropped";
    public const string SwordPath = "Prefabs/Sword";
    public const string SwordDroppedPath = "Prefabs/Sword_Dropped";
    public const string LetterPath = "Prefabs/Letter";

    public const string CoinPath = "Prefabs/Coin";
    public const string BreadPath = "Prefabs/bread";
    public const string ExpPath = "Prefabs/Exp1";
    #endregion

    #region Scene
    public const string SurvMainScene = "1.Scenes/Main_SurvLike";
    public const string SurvGameScene = "1.Scenes/Game_SurvLike";
    public const string SurvResultScene = "1.Scenes/Result_SurvLike";
    #endregion

    #region Constants
    public const float SpawnRange = 4;
    public const int LevelInterval = 30;
    public const int WaveInterval = 300;
    public const float MapHalfSize = 400;

    public const float InitAtk = 3;
    public const float InitMaxHp = 100;
    public const float InitSpeed = 6;
    public const float InitMagneticDistance = 5;
    public const int InitAxeNum = 0;
    public const int InitSwordNum = 0;

    public const int InitSpawnLimit = 5;

    public readonly static int[] InitLevelInfo = { 1, 0, 10 };
    public readonly static int[] InitWaveInfo = { 1, 0, 300 };
    #endregion

    #region Warning
    public const string Warning_Not_Enough_Gold = "골드가 부족합니다";
    public const string Warning_Full_Sword = "현재 검의 개수가 이미 최대입니다";
    public const string Warning_Full_Pickaxe = "현재 곡괭이의 개수가 이미 최대입니다";
    #endregion

    #region FreePerks
    public const string SpeedUp = "SpeedUp";
    public const string HpUp = "HpUp";
    public const string AtkUp = "AtkUp";
    public const string MagneticDistanceUp = "MagneticDistanceUp";
    public const string ShotIntervalDown = "ShotIntervalDown";
    public const string ShotNumUp = "ShotNumUp";
    public const string ShotSpeedUp = "ShotSpeedUp";
    public const string SwordSpeedUp = "SwordSpeedUp";
    public const string AxeAtkUp = "AxeAtkUp";
    public const string AxeHitCountUp = "AxeHitCountUp";
    #endregion

    #region NonFreePerks
    public const string AddSword = "AddSword";
    public const string AddAxe = "AddAxe";
    public const string AddExplosion = "AddExplosion";
    #endregion

    public readonly static string[] PerkNameList =
        { SpeedUp, HpUp, AtkUp, MagneticDistanceUp,
        ShotIntervalDown, ShotNumUp, ShotSpeedUp,
        SwordSpeedUp, AxeAtkUp, AxeHitCountUp,
        AddSword, AddAxe, AddExplosion };
}
