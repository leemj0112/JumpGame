using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;

    [SerializeField] private int maxBlockNum = 4;
    [SerializeField] private float spawn = 1.0f;

    private float delta = 0f;
    private float genPosX = 12f;

    private float offsetY = 0.3f;
    private float spaceY = 6.9f;

    private float offsetX = 0.5f;
    private float spaceX = 0.4f;

    void Start()
    {

    }

    void Update()
    {
        delta += Time.deltaTime;

        if (delta > spawn)
        {
            delta = 0;
            int n = Random.Range(1, maxBlockNum + 1); //1부터 5보다 작은 배열의 구조 - 알아보기

            for (int i = 0; i < n; i++)
            {
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(genPosX, offsetY + i * spaceY);
                //1~4개가 랜덤하게 들어올 때 바닥에서 위로 쌓이는 개념, i가 개수만큼 쌓이게(spaceY) 하는 것 
            }

            spawn = offsetX + spaceX * n;
        }
    }
}
