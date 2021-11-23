using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOuputService OutputService;

    //[SerializeField]
    //public UnityInputService InputService;

    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;

    private Game _game;
    private Room _previousLocation;
    private UnityInputService inputService;

    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        _game = JsonConvert.DeserializeObject<Game>(gameJsonAsset.text);
        _game.Player.LocationChanged += PLayerLocationChanged;
      
        _game.GameStopped += _game_GameStopped;
        _game.Run(inputService, OutputService);

        _game.Commands["NORTH"].Action(_game);
    }

    private void _game_GameStopped(object sender, System.EventArgs e)
    {
        if (_game.IsRunning == false)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }

    private void Update()
    {
        if (_game.Player.Location != _previousLocation)
        {
            CurrentLocationText.text = _game.Player.Location.ToString();
            _previousLocation = _game.Player.Location;
        }
    }

    private void PLayerLocationChanged(object sender, Room newLocation)
    {
        CurrentLocationText.text = newLocation.ToString();
    }
}
