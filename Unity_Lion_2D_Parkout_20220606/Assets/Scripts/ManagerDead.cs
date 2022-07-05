using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    ///  �޲z���`
    /// </summary>
    public class ManagerDead : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;
        [SerializeField, Header("CM��v�������")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                managerFinal.stringTitle = "�D�ԥ��� ~";
                managerFinal.enabled = true;
                goCM.SetActive(false);
            }
        }
    }
}


