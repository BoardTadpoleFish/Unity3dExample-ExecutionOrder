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

            Debug.LogWarning("# EnableObject2");
            object2.SetActive(true);
            Debug.LogWarning("# After EnableObject2");

            yield return ProcessWait();

            Debug.LogWarning("# DisableObject1-1");
            object1.SetActive(false);
            Debug.LogWarning("# After DisableObject1-1");

            yield return ProcessWait();

            Debug.LogWarning("# DestroyObject1");
            Object.Destroy(object1);
            Debug.LogWarning("# After DestroyObject1");
            object1 = null;

            yield return ProcessWait();

            Debug.LogWarning("# DestroyObject2");
            Object.Destroy(object2);
            Debug.LogWarning("# After DestroyObject2");
            object2 = null;

            yield return ProcessWait();
        }

        private IEnumerator ProcessWait()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}
