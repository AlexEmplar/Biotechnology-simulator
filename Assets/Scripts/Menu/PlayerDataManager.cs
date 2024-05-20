using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    private Player player;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        player = FindObjectOfType<Player>();
        print("yeeti");

        if (player != null)
        {
            print("dub");
            player.LoadPlayer();
        }
    }
}
