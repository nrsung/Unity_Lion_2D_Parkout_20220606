using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 1050;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        // Input API ��ĳ�b Update �I�s
        private void Update()
        {
            JumpKey();
        }

        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region �\��
        private void JumpKey()
        {
            // �p�G ���a ���U �ť��� �N���W ���D
            // if
            // switch
            // if �P�_���y�k : if (���L��) {���L�� �� TRUE ����{�� }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D~");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }
}

