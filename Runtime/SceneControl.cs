using UnityEngine;
using UnityEngine.SceneManagement;


namespace Fido.Tools
{
    /// <summary>
    /// 場景控制 載入場景及離開遊戲
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">要載入的場景名稱</param>
        public void LoadScene(string sceneName)
        {
            //場景控制器.載入場景(名稱)
            SceneManager.LoadScene(1);
        }
        /// <summary>
        /// 離開應用程式
        /// </summary>
        public void QuitScene()
        {
            //應用程式.離開
            Application.Quit();
        }
    }
}

