using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// 管理過關
    /// </summary>
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemJump;
        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerFinal;
        

        #region 其中一個物件有勾選 Is Trigger
        // 兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;
                systemJump.enabled = false;
                managerFinal.enabled = true;
                managerFinal.stringTitle = "恭喜你過關~";
            }
        }
        // 兩個物件碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        // 兩個物件碰撞重疊時執行一次
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region 兩個物件都沒有勾選 Is Trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }
        private void OnCollisionExit(Collision collision)
        {
            
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion

    }


}

