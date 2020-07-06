using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Roundbeargames
{
    public class LineScript : MonoBehaviour
    {
        LineRenderer lineRenderer;
        [SerializeField] public GameObject StartObj;
        [SerializeField] public GameObject CharacterHip;

        private void Start()
        {
            lineRenderer = this.gameObject.GetComponent<LineRenderer>();
        }

        private void Update()
        {
            lineRenderer.SetPosition(0, StartObj.transform.position);
            lineRenderer.SetPosition(1, CharacterHip.transform.position);
        }
    }
}