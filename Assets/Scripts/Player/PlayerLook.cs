using UnityEngine;

namespace Player
{
    public class PlayerLook : MonoBehaviour
    {
        private Transform _player;
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
            _player = GetComponent<Transform>();
        }

        void Update()
        {
            if (!_camera) return;
            Vector3 mouseWorldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f;
            Debug.DrawLine(_player.position, mouseWorldPos, Color.red);
        
            Vector3 lookDir = (mouseWorldPos - _player.position).normalized;
        
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        
            _player.rotation = Quaternion.Euler(0f, 0f, angle);
        
        }
    }
}
