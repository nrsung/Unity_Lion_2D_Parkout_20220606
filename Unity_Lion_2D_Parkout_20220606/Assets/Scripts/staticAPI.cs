
using UnityEngine;
using System;
using System.Threading;

namespace NRSUNG
{
    /// <summary>
    /// 靜態API (Static API)
    /// </summary>
    public class staticAPI : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

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

            Physics.sleepThreshold = 10;
            print("物理3D睡眠臨界值 :" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("時間大小 : "+ Time.timeScale);

            print("9.999去除小數(四捨五入) : " + Mathf.Round(9.999f));
            print("9.999去除小數(直接進位) : " + Mathf.Ceil(9.999f));
            print("9.999去除小數(無條件去除) : " + Mathf.Floor(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>距離 : " + distance + "</color>");

            Application.OpenURL("https://unity.com/");

        }
        private void Update()
        {
            /*
            #region 學習
            int rangeint = Random.Range(1, 3);
            print("隨機範圍 : " + rangeint);
            #endregion
            */

            //print("是否按下任一鍵 : " + Input.anyKey);
            //print("遊戲經過時間 :" + Time.timeSinceLevelLoad);

            print("<color=red>是否按下空白鍵 : " + Input.GetKeyDown(KeyCode.Space) + "</color>");

        }
    }

}
