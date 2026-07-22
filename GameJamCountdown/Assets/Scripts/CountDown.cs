using UnityEngine;

public class CountDown : MonoBehaviour
{
    public enum Scene
    {
        SCENE_MENU,
        SCENE_GAME,
    }
    public Scene scene;
    private bool inGame;
    public bool activated;
    public float countdownStart = 30; //seconds
    public Player player;
    public Transform Spawn;
    void Start()
    {
        //scene = Scene.SCENE_MENU;
        //inGame = false;
    }


    void Update()
    {
        if (scene == Scene.SCENE_GAME)
        {
            inGame = true;
        }
    }

    public void ResetPlayerToSpawn()
    {
        if (player != null && Spawn != null)
        {
            player.transform.position = Spawn.position;
            player.transform.rotation = Spawn.rotation;
        }
    }
}