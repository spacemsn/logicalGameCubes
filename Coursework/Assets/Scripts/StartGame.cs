using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // второй вариант ( рабочий )
    public GameObject Player;
    public GameObject cubeOne;
    public GameObject cubeTwo;
    public GameObject cubeThree;

    Player _movePlayer;
    
    
    SpawnCube _cubeOne;
    Player _moveCubeOne;
    ColorCube _colorOne;
    
    SpawnCube _cubeTwo;
    Player _moveCubeTwo;
    ColorCube _colorTwo;

    SpawnCube _cubeThree;
    Player _moveCubeThree;
    ColorCube _colorThree;

    Scene _sceneControll;

    void createClass() // Создание эл-тов Класса
    {
        _movePlayer = Player.GetComponent<Player>();

        
        _cubeOne = cubeOne.GetComponent<SpawnCube>();
        _moveCubeOne = cubeOne.GetComponent<Player>();
        _colorOne = cubeOne.GetComponent<ColorCube>();
        
        _cubeTwo = cubeTwo.GetComponent<SpawnCube>();
        _moveCubeTwo = cubeTwo.GetComponent<Player>();
        _colorTwo = cubeTwo.GetComponent<ColorCube>();

        _cubeThree = cubeThree.GetComponent<SpawnCube>();
        _moveCubeThree = cubeThree.GetComponent<Player>();
        _colorThree = cubeThree.GetComponent<ColorCube>();

        // _sceneControll.GetComponent<Scene>();
    }

    void Move() // Передвижение объектов
    {
        _movePlayer.Update();
        _moveCubeOne.Update();
        _moveCubeTwo.Update();
        _moveCubeThree.Update();
    }

    void Spawn() // Создание кубов
    {
        _cubeOne.Update();
        _cubeTwo.Update();
        _cubeThree.Update();
    }

    void Color() // Смена цвета у кубов 
    {
        _colorOne.colorCube();
        _colorTwo.colorCube();
        _colorThree.colorCube();
    }

    /*void Reload() // Перезапускает сцену, чтобы начачать уровень заного 
    {
        _sceneControll.ReloadScene();
    }

    void Next() // Перекидывает на следующий уровень
    {
        _sceneControll.NextScene();
    }*/

    // Start is called before the first frame update
    void Start()
    {
        createClass();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Spawn();
        Color();
        //Reload();
        //Next();
    }
}
