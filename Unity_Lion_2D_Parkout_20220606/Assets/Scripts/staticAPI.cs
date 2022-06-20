
using UnityEngine;
using System;
using System.Threading;

namespace NRSUNG
{
    /// <summary>
    /// �R�AAPI (Static API)
    /// </summary>
    public class staticAPI : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

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

            Physics.sleepThreshold = 10;
            print("���z3D�ίv�{�ɭ� :" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("�ɶ��j�p : "+ Time.timeScale);

            print("9.999�h���p��(�|�ˤ��J) : " + Mathf.Round(9.999f));
            print("9.999�h���p��(�����i��) : " + Mathf.Ceil(9.999f));
            print("9.999�h���p��(�L����h��) : " + Mathf.Floor(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=yellow>�Z�� : " + distance + "</color>");

            Application.OpenURL("https://unity.com/");

        }
        private void Update()
        {
            /*
            #region �ǲ�
            int rangeint = Random.Range(1, 3);
            print("�H���d�� : " + rangeint);
            #endregion
            */

            //print("�O�_���U���@�� : " + Input.anyKey);
            //print("�C���g�L�ɶ� :" + Time.timeSinceLevelLoad);

            print("<color=red>�O�_���U�ť��� : " + Input.GetKeyDown(KeyCode.Space) + "</color>");

        }
    }

}
