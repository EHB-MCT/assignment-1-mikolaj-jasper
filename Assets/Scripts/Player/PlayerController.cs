public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float health = 100.0f;
    public const MAX_HEALTH = 100.0f;


    public void Start()
    {
        health = MAX_HEALTH;
    }

    public void Update()
    {
      if (health < 0)
      {
        Die()
      }
    }

    private void Die()
    {
        Time.timeScale = 0f; // Stop the game
        Debug.Log("You died!");
    }
    
}