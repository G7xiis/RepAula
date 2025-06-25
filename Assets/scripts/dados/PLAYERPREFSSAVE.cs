using UnityEngine;

public class PLAYERPREFSSAVE : MonoBehaviour
{
    public Transform player;

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("playerX", player.position.x);
        PlayerPrefs.SetFloat("playerY", player.position.y);
        PlayerPrefs.SetFloat("playerZ", player.position.z);
        PlayerPrefs.Save();
        Debug.Log("posiçao salva!");
    }

    public void loadposition()
    {
        float x = PlayerPrefs.GetFloat("playerX", 0);
        float y = PlayerPrefs.GetFloat("playerY", 0);
        float z = PlayerPrefs.GetFloat("playerZ", 0);

        player.position = new Vector3(x, y, z);
        Debug.Log("posiçao carregada!");
    }


}
