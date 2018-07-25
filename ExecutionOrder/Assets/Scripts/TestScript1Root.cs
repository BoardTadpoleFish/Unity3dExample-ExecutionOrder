using System.Collections;
using UnityEngine;

namespace BoardTadpoleFish
{
    public class TestScript1Root : MonoBehaviour
    {
        [SerializeField] private GameObject object1;
        [SerializeField] private GameObject object2;

        private void Awake()
        {
            StartCoroutine(Process());
        }

        private IEnumerator Process()
        {
            yield return ProcessWait();

            Debug.LogWarning("EnableObject2");
            object2.SetActive(true);

            yield return ProcessWait();

            Debug.LogWarning("DisableObject1");
            object1.SetActive(false);

            yield return ProcessWait();

            Debug.LogWarning("DestroyObject1");
            Object.Destroy(object1);
            object1 = null;

            yield return ProcessWait();

            Debug.LogWarning("DestroyObject2");
            Object.Destroy(object2);
            object2 = null;

            yield return ProcessWait();
        }

        private IEnumerator ProcessWait()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}
