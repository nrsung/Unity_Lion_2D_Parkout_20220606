
using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// �R�AAPI (Static API)
    /// </summary>
    public class staticAPI : MonoBehaviour
    {
        private void Start()
        {
            /*
            #region �ǲ�
            //���o�R�A�ݩ� get
            //�y�k
            //���O.�R�A�ݩʦW��
            print("�H���� : " + Random.value);
            print("PI : " + Mathf.PI);
            print("�L���j : " + Mathf.Infinity);

            //�]�w�R�A�ݩ� set (Read only����ϥ�)
            //�y�k
            //���O.�R�A�ݩʦW�� ���w ��
            Cursor.visible = true;
            Physics2D.gravity = new Vector2(0, -0f);
            Time.timeScale = 0.2f;

            //�ϥ��R�A��k
            //�y�k
            //���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d�� : " + range);
            #endregion
            */

            print("Camera�ƶq : " + Camera.allCamerasCount);
            print("Application���x : " + Application.platform);

        }
        private void Update()
        {
            /*
            #region �ǲ�
            int rangeint = Random.Range(1, 3);
            print("�H���d�� : " + rangeint);
            #endregion
            */
            if (Input.anyKey)
            {
                Debug.Log("A key or mouse click has been detected");
            }
            
        }
    }

}
