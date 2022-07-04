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
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        #endregion

        #region �ƥ�
        // ø�s�ϥ�
        // �b�s�边��ø�s���U�Ϊ��u��.�Ϊ��ιϤ�:�C�������|�X�{
        private void OnDrawGizmos()
        {
            // 1.�M�w�C��
            Gizmos.color = colorCheckGround;
            // 2.ø�s�ϥ�
            // transform.position : ��e���󪺮y��
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        // Input API ��ĳ�b Update �I�s
        private void Update()
        {
            JumpKey();
            CheckGround();
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
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }

        private void JumpForce()
        {
            // �p�G �I�����D(�ť���) �åB(&&) �b�a�O�W
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGround()
        {
            // 2D �I���� = 2D ���z.�л\�����ϰ�(�����I.�ؤo.����);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize,0, layerCheckGround);
            //print("�I�쪺����:" + hit.name);
            isGround = hit;
        }
        #endregion
    }
}

