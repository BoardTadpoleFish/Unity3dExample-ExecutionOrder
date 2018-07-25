using UnityEngine;

namespace BoardTadpoleFish
{
    public class TestScript1 : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log(string.Format("  {0} - Awake", name));
        }

        private void Start()
        {
            Debug.Log(string.Format("  {0} - Start", name));
        }

        private void OnEnable()
        {
            Debug.Log(string.Format("  {0} - OnEnable", name));
        }

        private void OnDisable()
        {
            Debug.Log(string.Format("  {0} - OnDisable", name));
        }

        private void OnDestroy()
        {
            Debug.Log(string.Format("  {0} - OnDestroy", name));
        }
    }
}
