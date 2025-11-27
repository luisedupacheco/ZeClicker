// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class ButtonConfig : MonoBehaviour
// {
//     void OnMouseDown()
//     {
//         SceneManager.LoadScene("GameScene");

// for it to find where this GameScene is, we need to add it to the build settings.
// go to File -> Build Settings -> Scenes In Build -> Add Open Scenes (make sure the GameScene is open when you do this).

// this script should be attached to a UI button in the title screen scene.

// if it doesnt work, make sure the button has a collider component (like BoxCollider2D) to detect mouse clicks.

// im putting the name of the scene but it doesnt work, what should i do?
// make sure the scene name is spelled correctly and matches exactly with the name in the build settings
// does it need extension like .unity?
// no, just the scene name without any extension
// why doesnt it work?
// make sure the script is attached to the button and the button has a collider component
// make sure the button is set to interactable in the inspector
// make sure there are no other UI elements blocking the button

// still not working, what else could be the problem?
// check the console for any error messages
// if there are no errors, try adding a debug log to see if the OnMouseDown() method is being called

// error: Debug is an ambiguous reference between 'UnityEngine.Debug' and 'System.Diagnostics.Debug'
// add 'using UnityEngine;' at the top of the script to resolve the ambiguity
// i added it but still not working
// make sure there are no other scripts in the project that might be causing conflicts
// still not working, what else could be the problem?
// try using a different method to detect button clicks, like using the UnityEngine.UI.Button component


//         // do we need another scene just for configurations? or can we do it in the same scene (like a single page application)?
//         // we can do it in the same scene by using UI panels to switch between different views.
//         // so we can have a panel for the title screen, and another panel for the configurations.
//         // when the player clicks the "Configurations" button, we can hide the title screen panel and show the configurations panel.
//         // and when the player clicks the "Back" button in the configurations panel, we can hide the configurations panel and show the title screen panel.
//         // this way, we don't need to load a new scene, and we can keep everything in the same scene.

//         // it goes like this:
//         // 1. Create a Canvas in the scene.
//         // 2. Create two Panels as children of the Canvas: one for the Title Screen and one for Configurations.
//         // 3. Add Buttons to switch between the panels.
//         // 4. Use scripts to show/hide the panels based on button clicks.

//     }
// }



using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite; // Assign the new sprite in the Inspector

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        // Change the sprite when the mouse button is pressed down on the collider
        if (newSprite != null && spriteRenderer != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }

    // but what if we want to not make this check every time we click?
    // we can use a boolean flag to track if the sprite has already been changed.
    private bool isSpriteChanged = false;
    void OnMouseDownOptimized()
    {
        // Change the sprite only if it hasn't been changed yet
        if (!isSpriteChanged && newSprite != null && spriteRenderer != null)
        {
            spriteRenderer.sprite = newSprite;
            isSpriteChanged = true; // Set the flag to true after changing the sprite
        }
    }

    // this makes sure that the sprite is only changed once, and subsequent clicks won't trigger the change again.

    // now, if we want to have multiple sprites to choose from, like an upgraded item from the shop, we can use an array of sprites and cycle through them on each click.
    public Sprite[] spriteOptions;
    private int currentSpriteIndex = 0;
    void OnMouseDownCycle()
    {
        // Cycle through the sprite options on each click
        if (spriteOptions.Length > 0 && spriteRenderer != null)
        {
            spriteRenderer.sprite = spriteOptions[currentSpriteIndex];
            currentSpriteIndex = (currentSpriteIndex + 1) % spriteOptions.Length; // Move to the next sprite, wrap around if at the end
        }
    }
    // now, to use this, just call OnMouseDownCycle() in the OnMouseDown() method instead of the previous implementations.

    // this class would be better if attached to a UI button instead of a sprite with a collider, but this is just for demonstration purposes.
    // but if we want to use it with a UI button, we would need to use the UnityEngine.UI namespace and set up the button's OnClick() event to call the appropriate method.
    // it goes like this:
    // 1. Create a Canvas in the scene.
    // 2. Create a Button as a child of the Canvas.
    // 3. Attach this script to the Button.
    // 4. In the Button's OnClick() event, add a reference to this script and select the method to call (e.g., OnMouseDownCycle).
    // now, to make the ui element connect to the element in the scene, like changing the sprite of an object in the scene when clicking a button in the ui, we can add a public reference to the target object in this script.
    public GameObject targetObject; // Assign the target object in the Inspector
    public void ChangeTargetSprite()
    {
        if (targetObject != null)
        {
            SpriteRenderer targetSpriteRenderer = targetObject.GetComponent<SpriteRenderer>();
            if (targetSpriteRenderer != null && spriteOptions.Length > 0)
            {
                targetSpriteRenderer.sprite = spriteOptions[currentSpriteIndex];
                currentSpriteIndex = (currentSpriteIndex + 1) % spriteOptions.Length; // Move to the next sprite, wrap around if at the end
                // or if we want to directly set a specific sprite instead of cycling, we can do that too:
                // targetSpriteRenderer.sprite = newSprite;
            }
        }
    }
}