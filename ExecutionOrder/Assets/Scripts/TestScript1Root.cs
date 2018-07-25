using System.Collections;
using UnityEngine;

namespace BoardTadpoleFish
{
    // Ref. https://gist.github.com/BoardTadpoleFish/007edaa817ea08400e5af43e25749ab8#file-testscript1root-cs
    // Result: Unity3dExample-ExecutionOrder-Result1: https://pastebin.com/VCYjKT4Z
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

            Debug.LogWarning("# EnableObject1");
            object1.SetActive(true);
            Debug.LogWarning("# After EnableObject1");

            yield return ProcessWait();

            Debug.LogWarning("# DisableObject1-2");
            object1.SetActive(false);
            Debug.LogWarning("# After DisableObject1-2");

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
