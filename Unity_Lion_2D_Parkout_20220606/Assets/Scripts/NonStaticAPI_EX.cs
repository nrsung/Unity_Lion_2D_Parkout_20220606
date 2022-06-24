using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// C# �D�R�A�ݩʻP��k�m�� 2022.06.20
    /// </summary>
    public class NonStaticAPI_EX : MonoBehaviour
    {
        // 1.�w�q���,������������O
        // 2.Unity �ݩʭ��O�����T�w����줣�O�ŭ�(None)
        // 3.�ϥΫD�R�AAPI
        [SerializeField] private GameObject cube;
        [SerializeField] private GameObject sphere;
        [SerializeField] private GameObject capsule;

        [SerializeField] private SphereCollider sphere_collider;
        [SerializeField] private Camera cam;
        [SerializeField] private Rigidbody rig;
        //private Rigidbody rig;

        private void Awake()
        {
            //ani = GetComponent<Animator>();
            //rig = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            print("��v���`�� : " + Camera.main.depth);
            //myCollider = GetComponent<SphereCollider>();
            //print("�y��I�����b�| : " + myCollider.radius);
            print("�y��I�����b�| : " + sphere_collider.radius);
            cam.backgroundColor = Color.green;
            capsule.transform.localScale = new Vector3(3, 2, 1);
        }

        private void Update()
        {
            cube.transform.LookAt(sphere.transform.position);
            sphere.transform.Rotate(0, 3, 0);
            rig.AddForce(new Vector3(0, 350, 0));
        }

        private void FixedUpdate()
        {
            //rig.AddForce(new Vector3(0, 30000, 0));
            //rig.AddForce(new Vector2(0, 350));,0
            //rig.AddForce(new Vector3(0, 3, 0));
            
        }
    }
}

