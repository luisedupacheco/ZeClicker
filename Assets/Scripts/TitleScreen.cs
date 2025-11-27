using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{

    public void OnMouseDown()
    {
        SceneManager.LoadScene("GameScene");
        // but if i want, i can do it like this too:
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // what is buildIndex?
        // Build Index is the index of the scene in the Build Settings.
        // that means if you have multiple scenes in your game, you can load them by their index.
        // how does unity know the build index of a scene?
        // Unity assigns a build index to each scene based on the order they are listed in the Build Settings.
        // so, in plain english, the first scene in the Build Settings has a build index of 0, the second scene has a build index of 1, and so on.
        // you can check their position in the Build Settings by going to File -> Build Settings in the Unity Editor.
    
        // so now we got the player to click anywhere on the title screen to start the game.

        // but what if we want to add a button instead of clicking anywhere?
        // we can do that by using Unity's UI system, but that's a topic for another time.
        // just kidding, we can do it right here too.
        // right, github copilot?
        // sure thing!
        // we can create a UI button and attach a script to it that loads the game scene when clicked.
        // but for now, this will do.
        // no, this is not enough.
        // when we create a UI button, then we need to do the following:
        // 1. Create a Canvas in the scene.
        // 2. Create a Button as a child of the Canvas.
        // 3. Attach a script to the Button that loads the game scene when clicked.
        // 4. In the script, use the OnClick() event of the Button to call a method that loads the game scene.

        // do we need more canvases?
        // no, one canvas is enough for the entire UI.

    }


}
