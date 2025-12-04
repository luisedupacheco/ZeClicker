using UnityEngine;
using UnityEngine.SceneManagement;
public class BotoesMenu : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void SairDoJogo()
    {
        Application.Quit();
    }
    public void VoltarProMenu()
    {
        SceneManager.LoadScene("Menu");
    }





}
