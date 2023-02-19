using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action ResetLevel;

    public static void ResetLevelEvent()
    {
        ResetLevel?.Invoke();
    }

    public static event Action RespawnTiles;

    public static void RespawnTilesEvent()
    {
        RespawnTiles?.Invoke();
    }

    public static event Action ObjectReplaced;

    public static void ObjectReplacedEvent()
    {
        ObjectReplaced?.Invoke();
    }

    public static event Action ObjectRemoved;
    public static void ObjectRemovedEvent()
    {
        ObjectRemoved?.Invoke();
    }

    public static event Action StorageFilled;

    public static void StorageFilledEvent()
    {
        StorageFilled?.Invoke();
    }

    public static event Action KaChing;

    public static void KaChingEvent()
    {
        KaChing?.Invoke();
    }

    public static event Action TurnOnMusic;

    public static void TurnOnMusicEvent()
    {
        TurnOnMusic?.Invoke();
    }

    public static event Action CompletedTask;

    public static void CompletedTaskEvent()
    {
        CompletedTask?.Invoke();
    }

    public static event Action CompletedTasks;

    public static void CompletedTasksEvent()
    {
        CompletedTasks?.Invoke();
    }

    public static event Action CompletedTileSetup;

    public static void CompletedTileSetupEvent()
    {
        CompletedTileSetup?.Invoke();
    }

    public static event Action MovedPlayer;

    public static void MovedPlayerEvent()
    {
        MovedPlayer?.Invoke();
    }

    public static event Action CompletedLevel;

    public static void CompletedLevelEvent()
    {
        CompletedLevel?.Invoke();
    }

    public static event Action NextLevel;

    public static void NextLevelEvent()
    {
        NextLevel?.Invoke();
    }

    public static event Action MoveUp;
    public static void MoveUpEvent()
    {
        MoveUp?.Invoke();
    }
    public static event Action MoveDown;
    public static void MoveDownEvent()
    {
        MoveDown?.Invoke();
    }
    public static event Action MoveLeft;
    public static void MoveLeftEvent()
    {
        MoveLeft?.Invoke();
    }
    public static event Action MoveRight;
    public static void MoveRightEvent()
    {
        MoveRight?.Invoke();
    }
    public static event Action PointUp;
    public static void PointUpEvent()
    {
        PointUp?.Invoke();
    }
    public static event Action PointDown;
    public static void PointDownEvent()
    {
        PointDown?.Invoke();
    }
    public static event Action PointLeft;
    public static void PointLeftEvent()
    {
        PointLeft?.Invoke();
    }
    public static event Action PointRight;
    public static void PointRightEvent()
    {
        PointRight?.Invoke();
    }

    public static event Action PlayerControlsDisabled;

    public static void PlayerControlsDisabledEvent()
    {
        PlayerControlsDisabled?.Invoke();
    }

    public static event Action PlayerControlsEnabled;

    public static void PlayerControlsEnabledEvent()
    {
        PlayerControlsEnabled?.Invoke();
    }

    public static event Action BackButtonPressed;

    public static void BackButtonPressedEvent()
    {
        BackButtonPressed?.Invoke();
    }

    public static event Action ForwardButtonPressed;

    public static void ForwardButtonPressedEvent()
    {
        ForwardButtonPressed?.Invoke();
    }

    public static event Action RestartButtonPressed;

    public static void RestartButtonPressedEvent()
    {
        RestartButtonPressed?.Invoke();
    }

    public static event Action MenuButtonPressed;

    public static void MenuButtonPressedEvent()
    {
        MenuButtonPressed?.Invoke();
    }


}
