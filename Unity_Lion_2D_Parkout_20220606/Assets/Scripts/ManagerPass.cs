using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// �޲z�L��
    /// </summary>
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;
        

        #region �䤤�@�Ӫ��󦳤Ŀ� Is Trigger
        // ��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;
                systemJump.enabled = false;
                managerFinal.enabled = true;
                managerFinal.stringTitle = "���ߧA�L��~";
            }
        }
        // ��Ӫ���I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        // ��Ӫ���I�����|�ɰ���@��
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region ��Ӫ��󳣨S���Ŀ� Is Trigger
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

