using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // ������ ������� ( ������� )
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

    void createClass() // �������� ��-��� ������
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

    void Move() // ������������ ��������
    {
        _movePlayer.Update();
        _moveCubeOne.Update();
        _moveCubeTwo.Update();
        _moveCubeThree.Update();
    }

    void Spawn() // �������� �����
    {
        _cubeOne.Update();
        _cubeTwo.Update();
        _cubeThree.Update();
    }

    void Color() // ����� ����� � ����� 
    {
        _colorOne.colorCube();
        _colorTwo.colorCube();
        _colorThree.colorCube();
    }

    /*void Reload() // ������������� �����, ����� �������� ������� ������ 
    {
        _sceneControll.ReloadScene();
    }

    void Next() // ������������ �� ��������� �������
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
