using System.Collections;
using UnityEngine;

namespace BoardTadpoleFish
{
    public class TestScript2Root : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private GameObject object1;
        private GameObject object2;

        private void Awake()
        {
            StartCoroutine(Process());
        }

        private IEnumerator Process()
        {
            yield return ProcessWait();

            Debug.LogWarning("InstantiateObject1");
            prefab.name = "GameObject 1";
            object1 = Object.Instantiate(prefab, transform);

            yield return ProcessWait();

            Debug.LogWarning("InstantiateObject2");
            prefab.name = "GameObject 2";
            prefab.SetActive(false);
            object2 = Object.Instantiate(prefab, transform);
            prefab.SetActive(true);

            yield return ProcessWait();

            Debug.LogWarning("EnableObject2");
            object2.SetActive(true);

            yield return ProcessWait();
        }

        private IEnumerator ProcessWait()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}
