using UnityEngine;

namespace NRSUNG
{
    public class NonStaticAPI_EX : MonoBehaviour
    {
        SphereCollider myCollider;
        private void Start()
        {
            print("��v���`�� : " + Camera.main.depth);
            myCollider = GetComponent<SphereCollider>();
            print("�y��I�����b�| : " + myCollider.radius);
        }
    }
}

