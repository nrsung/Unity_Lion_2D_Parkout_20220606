using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace NRSUNG
{
    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �C�����������D��r���e
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            // �z���׻��W
            groupFinal.alpha += 0.1f;

            if(groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");
            }
        }

        // ���s�P�{�����q�覡
        // 1.�w�q���}��k
        // 2.Button On Click �]�w���}�������}��k
        public void Quit()
        {
            print("���}�C��");
            // �u�b�o�������� �q���P����˸m�W���@��
            Application.Quit();
        }

        public void Replay()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}


