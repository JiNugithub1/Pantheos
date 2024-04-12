using System.Collections;
using UnityEngine;

public class Greece : MonoBehaviour
{
    bool isMoving = false; // 오브젝트가 움직이고 있는지 여부를 나타내는 변수
    int left = 0;
    int right = 0;
    int up = 0;
    int down = 0;
    int leftup = 0;
    int rightup = 0;
    int leftdown = 0;
    int rightdown = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            int diceResult = Random.Range(1, 7);
            Debug.Log(diceResult + "이(가) 나왔다.");
            StartCoroutine(MoveDice(diceResult)); // 주사위 결과에 따라 이동 코루틴 시작
        }
    }

    IEnumerator MoveDice(int diceResult)
    {
        isMoving = true; // 움직임 시작
        

        // 주사위 결과에 따라 이동
        for (int i = 0; i < diceResult; i++)
        {
            // 가운데 갈림길
            if (transform.position == new Vector3(0, 6, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 왼쪽 위 갈림길
            else if (transform.position == new Vector3(-24, 30, transform.position.z)) 
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 오른쪽 위 갈림길
            else if (transform.position == new Vector3(24, 30, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 왼쪽 아래 갈림길
            else if (transform.position == new Vector3(-24, -18, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 오른쪽 아래 갈림길
            else if (transform.position == new Vector3(24, -18, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }

            // 마름모 12시에서 시작
            else if (transform.position == new Vector3(0, 54, transform.position.z) && i == 0)
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 1;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 3시에서 시작
            else if (transform.position == new Vector3(48, 6, transform.position.z) && i == 0)
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 6시에서 시작
            else if (transform.position == new Vector3(0, -42, transform.position.z) && i == 0)
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 9시에서 시작
            else if (transform.position == new Vector3(-48, 6, transform.position.z) && i == 0)
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }

            // 마름모 12시 지나감
            else if (transform.position == new Vector3(0, 54, transform.position.z) && i != 0)
            {
                if (leftup == 1)
                {
                    leftup = 0;
                    leftdown = 1;
                    transform.Translate(new Vector2(-4f, -4f));
                }
                if (rightup == 1)
                {
                    rightup = 0;
                    rightdown = 1;
                    transform.Translate(new Vector2(4f, -4f));
                }
                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 3시 지나감
            else if (transform.position == new Vector3(48, 6, transform.position.z) && i != 0)
            {
                if (rightdown == 1)
                {
                    rightdown = 0;
                    leftdown = 1;
                    transform.Translate(new Vector2(-4f, -4f));
                }
                if (rightup == 1)
                {
                    rightup = 0;
                    leftup = 1;
                    transform.Translate(new Vector2(-4f, 4f));
                }
                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 6시 지나감
            else if (transform.position == new Vector3(0, -42, transform.position.z) && i != 0)
            {
                if (leftdown == 1)
                {
                    leftdown = 0;
                    leftup = 1;
                    transform.Translate(new Vector2(-4f, 4f));
                }
                if (rightdown == 1)
                {
                    rightdown = 0;
                    rightup = 1;
                    transform.Translate(new Vector2(4f, 4f));
                }
                yield return null; // 다음 프레임까지 대기
            }
            // 마름모 9시 지나감
            else if (transform.position == new Vector3(-48, 6, transform.position.z) && i != 0)
            {
                if (leftup == 1)
                {
                    leftup = 0;
                    rightup = 1;
                    transform.Translate(new Vector2(4f, 4f));
                }
                if (leftdown == 1)
                {
                    leftdown = 0;
                    rightdown = 1;
                    transform.Translate(new Vector2(4f, -4f));
                }
                yield return null; // 다음 프레임까지 대기
            }

            // 설산 입구
            else if (transform.position == new Vector3(-28, 34, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    transform.Translate(new Vector2(-8f, 0f));
                    left = 1;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    transform.Translate(new Vector2(4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 산악 입구
            else if (transform.position == new Vector3(28, 34, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad6))
                {
                    transform.Translate(new Vector2(8f, 0f));
                    left = 0;
                    right = 1;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    transform.Translate(new Vector2(-4f, -4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 1;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 사막 입구
            else if (transform.position == new Vector3(28, -22, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad6))
                {
                    transform.Translate(new Vector2(8f, 0f));
                    left = 0;
                    right = 1;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    transform.Translate(new Vector2(-4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 1;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }
            // 정글 입구
            else if (transform.position == new Vector3(-28, -22, transform.position.z))
            {
                // 각각의 방향 키 입력에 따라 이동
                if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    transform.Translate(new Vector2(-8f, 0f));
                    left = 1;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 0;
                    leftdown = 0;
                    rightdown = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    transform.Translate(new Vector2(4f, 4f));
                    left = 0;
                    right = 0;
                    up = 0;
                    down = 0;
                    leftup = 0;
                    rightup = 1;
                    leftdown = 0;
                    rightdown = 0;
                }
                else // 입력이 없으면 이동하지 않음
                    i--; // 주사위 결과를 하나 감소시켜서 다시 이동할 수 있도록 함

                yield return null; // 다음 프레임까지 대기
            }

            // 직사각형 위로 이동
            else if (transform.position == new Vector3(-60, 34, transform.position.z) || transform.position == new Vector3(60, 34, transform.position.z) || transform.position == new Vector3(28, -46, transform.position.z) || transform.position == new Vector3(-28, -46, transform.position.z))
            {
                transform.Translate(new Vector2(0f, 8f));
                left = 0;
                right = 0;
                up = 1;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // 다음 프레임까지 대기
            }
            // 직사각형 오른쪽으로 이동
            else if (transform.position == new Vector3(-60, 58, transform.position.z) || transform.position == new Vector3(-28, -46, transform.position.z))
            {
                transform.Translate(new Vector2(8f, 0f));
                left = 0;
                right = 1;
                up = 0;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // 다음 프레임까지 대기
            }
            // 직사각형 왼쪽으로 이동
            else if (transform.position == new Vector3(60, 58, transform.position.z) || transform.position == new Vector3(60, -46, transform.position.z))
            {
                transform.Translate(new Vector2(-8f, 0f));
                left = 1;
                right = 0;
                up = 0;
                down = 0;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // 다음 프레임까지 대기
            }
            // 직사각형 아래로 이동
            else if (transform.position == new Vector3(-28, 58, transform.position.z) || transform.position == new Vector3(28, 58, transform.position.z) || transform.position == new Vector3(60, -22, transform.position.z) || transform.position == new Vector3(-60, -22, transform.position.z))
            {
                transform.Translate(new Vector2(0f, -8f));
                left = 0;
                right = 0;
                up = 0;
                down = 1;
                leftup = 0;
                rightup = 0;
                leftdown = 0;
                rightdown = 0;

                yield return null; // 다음 프레임까지 대기
            }

            // 왼쪽 위 이동
            else if (leftup == 1)
            {
                transform.Translate(new Vector2(-4f, 4f));
                yield return null; // 다음 프레임까지 대기
            }
            // 오른쪽 위 이동
            else if (rightup == 1)
            {
                transform.Translate(new Vector2(4f, 4f));
                yield return null; // 다음 프레임까지 대기
            }
            // 왼쪽 아래 이동
            else if (leftdown == 1)
            {
                transform.Translate(new Vector2(-4f, -4f));
                yield return null; // 다음 프레임까지 대기
            }
            // 오른쪽 아래 이동
            else if (rightdown == 1)
            {
                transform.Translate(new Vector2(4f, -4f));
                yield return null; // 다음 프레임까지 대기
            }
            // 왼쪽 이동
            else if (left == 1)
            {
                transform.Translate(new Vector2(-8f, 0f));
                yield return null; // 다음 프레임까지 대기
            }
            // 오른쪽 이동
            else if (right == 1)
            {
                transform.Translate(new Vector2(8f, 0f));
                yield return null; // 다음 프레임까지 대기
            }
            // 위쪽 이동
            else if (up == 1)
            {
                transform.Translate(new Vector2(0f, 8f));
                yield return null; // 다음 프레임까지 대기
            }
            // 아래쪽 이동
            else if (down == 1)
            {
                transform.Translate(new Vector2(0f, -8f));
                yield return null; // 다음 프레임까지 대기
            }
        }

        isMoving = false; // 움직임 종료
    }
}