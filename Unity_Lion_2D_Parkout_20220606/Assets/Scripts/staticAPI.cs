
using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// 靜態API (Static API)
    /// </summary>
    public class staticAPI : MonoBehaviour
    {
        private void Start()
        {
            /*
            #region 學習
            //取得靜態屬性 get
            //語法
            //類別.靜態屬性名稱
            print("隨機值 : " + Random.value);
            print("PI : " + Mathf.PI);
            print("無限大 : " + Mathf.Infinity);

            //設定靜態屬性 set (Read only不能使用)
            //語法
            //類別.靜態屬性名稱 指定 值
            Cursor.visible = true;
            Physics2D.gravity = new Vector2(0, -0f);
            Time.timeScale = 0.2f;

            //使用靜態方法
            //語法
            //類別.靜態方法名稱(對應引數)
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍 : " + range);
            #endregion
            */

            print("Camera數量 : " + Camera.allCamerasCount);
            print("Application平台 : " + Application.platform);

        }
        private void Update()
        {
            /*
            #region 學習
            int rangeint = Random.Range(1, 3);
            print("隨機範圍 : " + rangeint);
            #endregion
            */
            if (Input.anyKey)
            {
                Debug.Log("A key or mouse click has been detected");
            }
            
        }
    }

}
