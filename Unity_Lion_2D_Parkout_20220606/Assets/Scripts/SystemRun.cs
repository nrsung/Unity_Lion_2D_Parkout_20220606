using UnityEngine;

namespace NRSUNG
{
    // C# �q�Ź��ܦ����骫��
    // 1. �����W���C������ Game Object �Ǧ�u�����
    // 2. �N���}�����b�Ӫ����ܦ�����

    /// 
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��� : �O�s�t�λݭn�����

        // ��� Field : �O�s���
        // �y�k : 
        // �׹��� ��������� ���ۭq�W�� (���w �w�]);

        // �׹���
        // ���} : ��ܦb���O�W , ���\��L���O�s�� public
        // �p�H : ����ܦb���O�W , �����\��L���O�s�� private (�ʸ�)

        // [] Attritube �ݩ� . �B�~�\��
        // Serialize Field �ǦC�����:�N�p�H������
        // Header ���D:�i�H�ϥΤ���
        // Tooltip ����:�i�H�ϥΤ���
        // Range �d��:�ȭ���ƭ�������� int, float, byte, long

        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\�� : ��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ� : �{���J�f
        // �}�l�ƥ� : ����C���ɰ���@��
        // ��l�Ƴ]�w . �Ҧp :
        private void Start()
        {
            print("���o . �U�w :D");
        }
        #endregion

    }

}

