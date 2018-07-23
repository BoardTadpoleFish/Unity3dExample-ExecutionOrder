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
            yield return ProcessEndOfFrame();

            Debug.LogWarning("EnableObject2");
            object2.SetActive(true);

            yield return ProcessEndOfFrame();

            Debug.LogWarning("DisableObject1");
            object1.SetActive(false);

            yield return ProcessEndOfFrame();

            Debug.LogWarning("DestroyObject1");
            Object.Destroy(object1);
            object1 = null;

            yield return ProcessEndOfFrame();

            Debug.LogWarning("DestroyObject2");
            Object.Destroy(object2);
            object2 = null;

            yield return ProcessEndOfFrame();
        }

        private IEnumerator ProcessEndOfFrame()
        {
            Debug.LogWarning("<===");
            yield return new WaitForEndOfFrame();
            Debug.LogWarning("===>");
        }
    }
}
