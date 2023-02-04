using UnityEngine;

namespace Prefabs.Component
{
    using S = SerializeField;
    
    public class LineRendererController : MonoBehaviour
    {
        private LineRenderer m_lineRenderer;
        private Transform[] m_points;

        public void SetupLines(Transform[] points)
        {
            m_points = points;
        }

        public void OnEnable()
        {
            if (m_points == null)
            {
                return;
            }
            
            m_lineRenderer = GetComponent<LineRenderer>();
            m_lineRenderer.positionCount = m_points.Length;

            for (var i = 0; i < m_points.Length; i++)
            {
                m_lineRenderer.SetPosition(i, m_points[i].position);
            }
        }
    }
}