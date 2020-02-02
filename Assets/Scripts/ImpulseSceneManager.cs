using UnityEngine.SceneManagement;

public static class ImpulseSceneManager
{
    static int _scenePreRoomIndex = 0;
    static int _sceneClaustrophobiaIndex = 1;
    static int _scene2DIndex = 2;
    static int _sceneGameOverIndex = 3;
    static int _sceneCongratsIndex = 4;
    static int _sceneNyctophobiaIndex = 5;

    public static void LoadPreRoom() => SceneManager.LoadScene(_scenePreRoomIndex);
    public static void LoadClaustrophobiaRoom() => SceneManager.LoadScene(_sceneClaustrophobiaIndex);
    public static void Load2DRoom() => SceneManager.LoadScene(_scene2DIndex);
    public static void LoadGameOver() => SceneManager.LoadScene(_sceneGameOverIndex, LoadSceneMode.Additive);
    public static void LoadCongrats() => SceneManager.LoadScene(_sceneCongratsIndex, LoadSceneMode.Additive);
    public static void LoadNyctophobiaRoom() => SceneManager.LoadScene(_sceneNyctophobiaIndex);

    public static bool IsGameOverLoaded() => SceneManager.GetSceneByBuildIndex(_sceneGameOverIndex).isLoaded;
}
