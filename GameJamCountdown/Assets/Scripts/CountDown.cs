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
    void Start()
    {
        scene = Scene.SCENE_MENU;
        inGame = false;
    }


    void Update()
    {
        if (scene == Scene.SCENE_GAME) { 
        inGame = true;
        }
    }
}
