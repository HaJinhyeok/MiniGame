using UnityEngine;
using System;

public struct PlayerInfo
{
    public float Atk;
    public float CurrentHp;
    public float MaxHp;
    public float Speed;
    public float MagneticDistance;
    public int AxeNum;
    public int SwordNum;
    public string PlayerName;
}

public struct ShotInfo
{
    public float Interval;
    public int ShotNum;
    public float Speed;
}

public struct WeaponInfo
{
    public float SwordRotationSpeed;
    public int AxeHitCount;
    public int AxeAtk;
}

public class GameManager : Singleton<GameManager>
{
    protected override void Initialize()
    {
        InitiatePlayerInfo();
        RankMain.Instance.PostTop3Data();
    }

    bool _isPaused = false;

    public bool IsPaused
    {
        get { return _isPaused; }
        set { _isPaused = value; }
    }

    // LevelUp UI 확인용
    bool _isDone = true;

    public bool IsDone
    {
        get { return _isDone; }
        set { _isDone = value; }
    }

    public Protocols.Packets.user[] users;

    #region JoyStick
    public event Action<Vector2> OnMoveDirChanged;

    Vector2 _moveDir;
    Vector2 _lastDir;

    public Vector2 MoveDir
    {
        get { return _lastDir; }
        set
        {
            _moveDir = value;
            if (value != Vector2.zero)
                _lastDir = value;
            OnMoveDirChanged?.Invoke(value);
        }
    }
    #endregion

    #region PlayerInfo
    public event Action OnTakeDamage;
    public PlayerInfo PlayerInfo = new PlayerInfo();

    public float PlayerHp
    {
        get { return PlayerInfo.CurrentHp; }
        set
        {
            PlayerInfo.CurrentHp = value;
            OnTakeDamage?.Invoke();
        }
    }

    public GameObject Target { get; set; }
    #endregion

    #region ShotInfo
    public ShotInfo ShotInfo = new ShotInfo();
    #endregion

    #region WeaponInfo
    public WeaponInfo WeaponInfo = new WeaponInfo();
    #endregion


    #region Score
    public event Action OnScoreChanged;
    int _score;

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
        }
    }

    public void GetScore(int score = 1)
    {
        _score += score;
        OnScoreChanged?.Invoke();
        LevelManager.Instance.NextWave();
    }
    #endregion

    #region Money
    public event Action OnMoneyChanged;
    int _money;

    public int Money
    {
        get { return _money; }
        set
        {
            _money = value;
            OnMoneyChanged?.Invoke();
        }
    }

    public void GetMoney(int money = 5)
    {
        _money += money;
        OnMoneyChanged?.Invoke();
    }
    #endregion

    #region Exp
    public event Action OnExpIncreased;
    int _exp;

    public int Exp
    {
        get { return _exp; }
        set { _exp = value; }
    }

    public void GetExp(int exp=1)
    {
        _exp += exp;
        OnExpIncreased?.Invoke();
        LevelManager.Instance.NextLevel();
    }
    #endregion

    public void InitiatePlayerInfo()
    {
        PlayerInfo.Atk = Define.InitAtk;
        PlayerInfo.CurrentHp = Define.InitMaxHp;
        PlayerInfo.MaxHp = Define.InitMaxHp;
        PlayerInfo.Speed = Define.InitSpeed;
        PlayerInfo.MagneticDistance = Define.InitMagneticDistance;
        PlayerInfo.AxeNum = Define.InitAxeNum;
        PlayerInfo.SwordNum = Define.InitSwordNum;

        ShotInfo.Interval = 1f;
        ShotInfo.ShotNum = 4;
        ShotInfo.Speed = 500f;

        WeaponInfo.SwordRotationSpeed = 90f; // 최대 360도/1sec
        WeaponInfo.AxeHitCount = 3;
        WeaponInfo.AxeAtk = 1;

        _score = 0;
        _money = 0;
        _exp = 0;

        // PlayerInfo.PlayerName = "Jinhyeok";
    }
}
