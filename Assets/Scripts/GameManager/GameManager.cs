public class GameManager()
{
    public void Start(level)
    {
        scenemanagement.LoadScene(level);
    }

    public void GameOver()
    {
        Application.Quit();
    }

    public void Restart()
    {
        scenemanagement.LoadScene(0);
    }

}