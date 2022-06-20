using UnityEngine;


namespace NRSUNG
{
    /// <summary>
    /// �D�R�A API
    /// �P�R�A���t�O�b��ݭn�@�ӹ��骫��
    /// ���骫�� : �@�Ӧs�b������W���C������ Game Object
    /// </summary>
    public class NonStatic : MonoBehaviour
    {
        // 1.�w�q���,������������O
        // 2.Unity �ݩʭ��O�����T�w����줣�O�ŭ�(None)
        // 3.�ϥΫD�R�AAPI
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
            // �D�R�A�ݩ�
            // 1.���o
            // �y�k
            // ���W��.�D�R�A�ݩ�
            print("�Ԫ��t���Ұʪ��A :" + turtle.activeInHierarchy);
            print("�Ԫ��t���w�]�ϼh :" + turtle.layer);
            print("�_�I���y�� : " + startPoint.position);

            // 2.�]�w
            // �y�k
            // ���W��.�D�R�A�ݩ� ���w �� ;
            // turtle.activeInHierarchy = false; (���~:��Ū�ݩ� �x��S�g)
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            // 3.�ϥ� �D�R�A��k
            // �y�k : ���W��.�D�R�A��k(�������޼�);
            turtle.SetActive(false);
        }

        private void Update()
        {
            startPoint.Translate(0.1f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
        }
    }

}
