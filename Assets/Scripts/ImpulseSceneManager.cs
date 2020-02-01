using UnityEngine.SceneManagement;

public static class ImpulseSceneManager
{
    static int _scenePreRoomIndex = 0;
    static int _scene3DIndex = 1;
    static int _scene2DIndex = 2;
    static int _sceneGameOverIndex = 3;
    static int _sceneCongratsIndex = 4;

    public static void LoadPreRoom() => SceneManager.LoadScene(_scenePreRoomIndex);
    public static void Load3DRoom() => SceneManager.LoadScene(_scene3DIndex);
    public static void Load2DRoom() => SceneManager.LoadScene(_scene2DIndex);
    public static void LoadGameOver() => SceneManager.LoadScene(_sceneGameOverIndex, LoadSceneMode.Additive);
    public static void LoadCongrats() => SceneManager.LoadScene(_sceneCongratsIndex, LoadSceneMode.Additive);

    public static bool IsGameOverLoaded() => SceneManager.GetSceneByBuildIndex(_sceneGameOverIndex).isLoaded;
}
