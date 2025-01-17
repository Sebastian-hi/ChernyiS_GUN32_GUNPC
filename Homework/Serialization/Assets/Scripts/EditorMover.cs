using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
	[RequireComponent(typeof(PositionSaver))]

	public class EditorMover : MonoBehaviour
	{
        //MY должен сохранять в PositionMover свою позицию через каждые _delay секунд
		//в течении времени _duration.

		
        private PositionSaver _save;
		private float _currentDelay;

		//todo comment: Что произойдёт, если _delay > _duration?
		// answer comment:  если задержка будет больше продолжительности, мы не сможем записывать действие.
		// мы как бы перепрыгнем весь маршрут

		[Range(0.2f, 1f)]
		private float _delay = 0.5f;

		[Min(0.2f)]
		private float _duration = 5f;


        private void Start()
		{
            //todo comment: Почему этот поиск производится здесь, а не в начале метода Update?
            // answer comment:  Потому что не нужно каждый кадр получать доступ к нашей позиции,
			// достаточно это сделать единожды в начале.

            _save = GetComponent<PositionSaver>();
			_save.Records.Clear();

			if (_duration !> _delay)
			{
				_duration = _delay * 5;

            }
		}

		private void Update()
		{
			_duration -= Time.deltaTime;

			if (_duration <= 0f)
			{
				enabled = false;
				Debug.Log($"<b>{name}</b> finished", this);
				return;
			}

            //todo comment: Почему не написать (_delay -= Time.deltaTime;) по аналогии с полем _duration?
            // answer comment: Чтобы в самом начале работы кода (в плей моде) сделать точку (отметить начало)
            // и далее в цикле update идёт наша delay (_currentDelay = _delay;)

            _currentDelay -= Time.deltaTime;

			if (_currentDelay <= 0f)
			{
				_currentDelay = _delay;

				_save.Records.Add(new PositionSaver.Data
				{
					Position = transform.position,
                    //todo comment: Для чего сохраняется значение игрового времени?
                    // answer comment: Сохраняем данные в нашу структуру Data,
					// чтобы использовать значение Time в ReplayMover в методы Update:
					//
                    Time = Time.time,
				});
			}
		}
	}
}