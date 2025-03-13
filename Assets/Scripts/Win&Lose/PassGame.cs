using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class PassGame : MonoBehaviour
    {
        private float rotationDuration = 5f;
        private float rotationSpeed = 90f;
        public AudioSource pass;

        public void Start()
        {
            StartCoroutine(RotateThenScale());
            pass.Play();
        }

        private IEnumerator RotateThenScale()
        {
            float elapsedTime = 0f;

            // Вращение объекта
            while (elapsedTime < rotationDuration)
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Остановка вращения и масштабирование
            ScaleToFullScreen();
        }

        private void ScaleToFullScreen()
        {
            // Сброс вращения
            transform.rotation = Quaternion.identity;

            // Получение данных о спрайте
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer == null || spriteRenderer.sprite == null)
            {
                Debug.LogError("Требуется компонент SpriteRenderer с назначенным спрайтом");
                return;
            }

            // Расчет размеров спрайта
            float spriteWidth = spriteRenderer.sprite.rect.width / spriteRenderer.sprite.pixelsPerUnit;
            float spriteHeight = spriteRenderer.sprite.rect.height / spriteRenderer.sprite.pixelsPerUnit;

            // Расчет соотношений сторон
            float screenAspect = (float)Screen.width / Screen.height;
            float spriteAspect = spriteWidth / spriteHeight;

            float scale = 1f;

            // Определение масштаба в зависимости от ориентации экрана
            if (screenAspect > spriteAspect)
            {
                // Экран шире спрайта - масштабируем по вертикали
                float screenHeight = Camera.main.orthographicSize * 2f;
                scale = screenHeight / spriteHeight;
            }
            else
            {
                // Экран уже спрайта - масштабируем по горизонтали
                float screenWidth = Camera.main.orthographicSize * 2f * screenAspect;
                scale = screenWidth / spriteWidth;
            }

            // Применение масштаба
            transform.localScale = Vector3.one * scale;
        }
    }
}