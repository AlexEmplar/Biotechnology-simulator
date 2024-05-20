using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using static AmbientLocationEnum;

[RequireComponent(typeof(AudioSource))]
/// <summary> Класс, отвечающий за проигрывание треков во время геймплея.</summary>
public class AudioManager : MonoBehaviour
{
    public const string MASTER_VOLUME = "MasterVolume";
    public const string MUSIC_VOLUME = "MusicVolume";
    public const string SFX_VOLUME = "SFXVolume";

    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioMixer audioMixer;

    public LocationType CurrentLocation { get; set; }

    [Header("Location tracks")]
    public List<AudioClip> FactoryTracks;
    public List<AudioClip> BankTracks;
    public List<AudioClip> WhitehallTracks;
    public List<AudioClip> AlchemyGuildTracks;
    public List<AudioClip> JoineryGuildTracks;
    public List<AudioClip> SmitheryGuildTracks;
    public List<AudioClip> MenuTracks;

    /// <summary> Словарь локаций ко всем трекам локации.</summary>
    public Dictionary<LocationType, List<AudioClip>> LocationTracks;
    /// <summary> Словарь локаций к индексу трека.</summary>
    public Dictionary<LocationType, int> LocationToTrackIndex;
    /// <summary> Словарь локаций к временной метке.</summary>
    private Dictionary<LocationType, float> LocationToTrackTime;

    /// <summary> Спиоск треков текущей локации.</summary>
    private List<AudioClip> trackList;
    /// <summary> Индекс текущего трека.</summary>
    private int currentTrackIndex;

    /// <summary> Длительность смешивания треков.</summary>
    public float fadeDuration; // Длительность фейда

    /// <summary> Первый источник аудио.</summary>
    private AudioSource audioPlayer;
    /// <summary> Второй источник аудио.</summary>
    private AudioSource audioPlayerFade; // Новый AudioSource для фейда

    /// <summary> Инициализация и создание компонентов.</summary>
    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
        audioPlayerFade = gameObject.AddComponent<AudioSource>(); // Добавляем новый AudioSource для фейда
        audioPlayerFade.outputAudioMixerGroup = audioPlayer.outputAudioMixerGroup;

        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    /// <summary> Запуск конфигурации скрипта аудио-менеджера.</summary>
    private void Start()
    {
        Initialize();
        CurrentLocation = LocationType.Menu;
        trackList = LocationTracks[CurrentLocation];
    }

    /// <summary> Инициализация аудио-менеджера.</summary>
    private void Initialize()
    {
        LocationTracks = new() {
            {LocationType.Factory,       FactoryTracks},
            {LocationType.Bank,          BankTracks},
            {LocationType.Whitehall,     WhitehallTracks},
            {LocationType.AlchemyGuild,  AlchemyGuildTracks},
            {LocationType.JoineryGuild,  JoineryGuildTracks},
            {LocationType.SmitheryGuild, SmitheryGuildTracks},
            {LocationType.Menu,          MenuTracks}
        };
        LocationToTrackIndex = new() {
            {LocationType.Factory,       0},
            {LocationType.Bank,          0},
            {LocationType.Whitehall,     0},
            {LocationType.AlchemyGuild,  0},
            {LocationType.JoineryGuild,  0},
            {LocationType.SmitheryGuild, 0},
            {LocationType.Menu,          0}
        };
        LocationToTrackTime = new() {
            {LocationType.Factory,       0},
            {LocationType.Bank,          0},
            {LocationType.Whitehall,     0},
            {LocationType.AlchemyGuild,  0},
            {LocationType.JoineryGuild,  0},
            {LocationType.SmitheryGuild, 0},
            {LocationType.Menu,          0}
        };

        currentTrackIndex = 0;
        audioPlayer.pitch = 1;
    }

    /// <summary> Событие изменения общей громкости.</summary>
    public void OnMasterVolumeChanged(System.Single masterLevel)
    {
        audioMixer.SetFloat(MASTER_VOLUME, Mathf.Log10(masterLevel) * 20);
    }

    /// <summary> Событие изменения громкости музыки.</summary>
    public void OnMusicVolumeChanged(System.Single musicLevel)
    {
        audioMixer.SetFloat(MUSIC_VOLUME, Mathf.Log10(musicLevel) * 20);
    }

    /// <summary> Событие изменения громкости SFX.</summary>
    public void OnSFXVolumeChanged(System.Single sfxLevel)
    {
        audioMixer.SetFloat(SFX_VOLUME, Mathf.Log10(sfxLevel) * 20);
    }
}

/// <summary> Перечисления возможных локаций.</summary>
public static class AmbientLocationEnum
{
    public enum LocationType
    {
        Factory, Bank, Whitehall, AlchemyGuild, JoineryGuild, SmitheryGuild, Menu
    }
}