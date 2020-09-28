using UnityEngine;


public class TransformExample : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _my3DVector;
    [SerializeField] private Quaternion _startPosition;

    private Vector3 _moveDirection;

    private void Start()
    {
        _startPosition = transform.rotation;
        _moveDirection = Vector3.forward;
    }


    private void Update()
    {
        // Телепортация объекта по оси y
        //transform.position += new Vector3(0, _speed * Time.deltaTime, 0);
        //transform.position += _moveDirection * Time.deltaTime;

        // Движение объекта вперед со скоростью 1 единица в секунду
        //transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        // Движение объекта вперед в глобальной системе координат
        // xyz = right, up, forward
        //transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.Self);

        // Движение объекта вдоль оси Z
        // transform.Translate(0, 0, _speed * Time.deltaTime);

        // Движение объекта вперед относительно камеры
        //  transform.Translate(Vector3.forward * Time.deltaTime * Speed, Camera.main.transform);

        // Движение к цели с указанной скоростью
        //transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);


        /////////////////////// повороты



        // нулевое вращение (вращение равное нулю)
        //transform.rotation = Quaternion.identity;
        //print(transform.rotation.eulerAngles);

        // поворот в сторону направления (вектора)
        //Vector3 relativePos = _target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(relativePos);

        // Поворот в сторону объекта (трансформа)
        //transform.LookAt(_target);

        // Преобразование вектора3 в кватернионы для поворота
        //transform.rotation = Quaternion.Euler(_my3DVector);

        // Возвращение угла в градусах между двумя объектами
        //float angle = Quaternion.Angle(transform.rotation, _target.rotation);
        //print("Угол в градусах " + angle); // вывод на консоль

        // Сфеерическая интерполяция между двумя вращениями с указанной скоростью (повтор вращения)
        // transform.rotation = Quaternion.Slerp(transform.rotation, Target.rotation, RotSpeed * Time.deltaTime);

        // Создание поворота между двумя векторами.
        // Высчитывание направленияVector3 relativePos = Target.position - transform.position;
        // transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.right);

        // Вращение объекта со скоростью 1 градус в секунду вокруг вектора, направленного вверх для объекта, в локальной системе координат
        // transform.Rotate(Vector3.up * RotSpeed * Time.deltaTime);

        // Вращение объекта вокруг вектора, направленного вверх от объекта, в глобальной системе координат
        //transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime, Space.Self);

        // Скорость поворота можно задать отдельным параметром
        // transform.Rotate(Vector3.up, RotSpeed * Time.deltaTime);                                 

        // Координаты вектора заданы по отдельности
        // transform.Rotate(Time.deltaTime * Speed, 0, 0);   

        // Получение углов Эйлера в виде Vector3 от Quaternion
        // Бессмысленно сравнивать rotation.eulerAngles с реальными углами
        // var eulerAngles = transform.rotation.eulerAngles;
        // print(eulerAngles);

        // Вращение в 2d пространстве
        // var vector = new Vector3(0, 0, 50);
        // transform.rotation *= Quaternion.Euler(vector * Time.deltaTime);


        //RotateTowards:
        //Первый параметр – текущее направление вектора, 
        //второй – необходимое направление, 
        //третий – скорость поворота, 
        //четвертый – максимальная длина вектора.
        /*
        // Направление вектора
        Vector3 relativePos = Target.position - transform.position;
        // Вращает указанный вектор в сторону цели 
        Vector3 newDir = Vector3.RotateTowards(transform.forward, relativePos, RotSpeed * Time.deltaTime, 10F);  
        // Создание поворота
        transform.rotation = Quaternion.LookRotation(newDir);
        // отрисовка луча
        Debug.DrawRay(transform.position, newDir, Color.red);
        */
        // Вращение обекта вокруг указанной точки и вокруг указанной оси
        // первый параметр точка, второй ось
        //  transform.RotateAround(Target.position, Vector3.right, RotSpeed * Time.deltaTime);
    }
}
