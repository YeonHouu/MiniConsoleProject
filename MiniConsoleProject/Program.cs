namespace Lesson
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }

        //게임 초기 설정 함수
        static void Start(out Position playerPos, out char[,] map)
        {
            Console.CursorVisible = false;

            playerPos.x = 2;
            playerPos.y = 8;

            map = new char[10, 20]
            {

                { '▒', '▒', '▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒' },
                { '▒', '□', ' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', ' ', '■', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '■',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', ' ', ' ', ' ',' ', ' ','■', ' ',' ', '□',' ', ' ',' ', ' ',' ', ' ','■', ' ',' ', '▒' },
                { '▒', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', ' ', ' ', '□',' ', ' ',' ', '□',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '■',' ', ' ',' ', '□',' ', ' ',' ', '▒' },
                { '▒', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', ' ',' ', '▒' },
                { '▒', '▒', '▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒','▒', '▒' }

            };

        }

        static void End()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 박스 5개를 제자리에 다 넣었어요 ! ! ! 게임 끝 !");
            Console.ResetColor();
        }

        //출력(그리기) 함수
        static void Render(Position playerPos, char[,] map)
        {
            Console.SetCursorPosition(0, 0);
            PrintMap(map);
            PrintPlayer(playerPos);
        }

        //입력 함수
        static ConsoleKey Input()
        {
            //입력이 있을 때까지 게임 루프 대기
            return Console.ReadKey(true).Key;
        }

        //처리 함수
        static void Update(ConsoleKey key, ref Position playerPos, char[,] map, ref bool gameOver)
        {
            Move(key, ref playerPos, map);

            bool isGoal = IsGoal(map);
            if(isGoal)
            {
                gameOver = true;
            }
        }

        //플레이어 위치 출력 함수
        static void PrintPlayer(Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("P");
            Console.ResetColor();
        }

        //맵 출력
        static void PrintMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        //플레이어 움직임 제어 함수
        static void Move(ConsoleKey key, ref Position playerPos, char[,] map)
        {
            Position targetPos;
            Position overPos;

            switch (key)
            {
                case ConsoleKey.A:
                    targetPos.x = playerPos.x - 1;
                    targetPos.y = playerPos.y;
                    overPos.x = playerPos.x - 2;
                    overPos.y = playerPos.y;
                    break;

                case ConsoleKey.D:
                    targetPos.x = playerPos.x + 1;
                    targetPos.y = playerPos.y;
                    overPos.x = playerPos.x + 2;
                    overPos.y = playerPos.y;
                    break;

                case ConsoleKey.S:
                    targetPos.x = playerPos.x;
                    targetPos.y = playerPos.y + 1;
                    overPos.x = playerPos.x;
                    overPos.y = playerPos.y + 2;
                    break;
                case ConsoleKey.W:
                    targetPos.x = playerPos.x;
                    targetPos.y = playerPos.y - 1;
                    overPos.x = playerPos.x;
                    overPos.y = playerPos.y - 2;
                    break;
                default:
                    return;
            }

            // 움직이는 방향에 박스
            if (map[targetPos.y, targetPos.x] == '■')
            {
                //overPos에 골
                if (map[overPos.y, overPos.x] == '□')
                {
                    map[overPos.y, overPos.x] = '▣';
                    map[targetPos.y, targetPos.x] = ' ';
                    playerPos.x = targetPos.x;
                    playerPos.y = targetPos.y;
                }
               
                //overPos에 빈공간
                else if (map[overPos.y, overPos.x] == ' ')
                {
                    map[overPos.y, overPos.x] = '■';
                    map[targetPos.y, targetPos.x] = ' ';
                    playerPos.x = targetPos.x;
                    playerPos.y = targetPos.y;
                }
            }

            // 움직이는 방향에 골
            else if (map[targetPos.y, targetPos.x] == '□')
            {
                //플레이어 위치 변경
                playerPos.x = targetPos.x;
                playerPos.y = targetPos.y;
            }

            // 움직이는 방향에 골박스
            else if (map[targetPos.y, targetPos.x] == '▣')
            {
                //overPos에 골
                if (map[overPos.y, overPos.x] == '□')
                {
                    map[overPos.y, overPos.x] = '▣';
                    map[targetPos.y, targetPos.x] = '□';
                    playerPos.x = targetPos.x;
                    playerPos.y = targetPos.y;
                }
              
                //overPos에 빈공간
                else if (map[overPos.y, overPos.x] == ' ')
                {
                    map[overPos.y, overPos.x] = '■';
                    map[targetPos.y, targetPos.x] = '□';
                    playerPos.x = targetPos.x;
                    playerPos.y = targetPos.y;
                }
            }

            // 움직이는 방향에 빈공간
            else if (map[targetPos.y, targetPos.x] == ' ')
            {
                //플레이어 위치 변경
                playerPos.x = targetPos.x;
                playerPos.y = targetPos.y;
            }
        }

        //성공 조건 판단 함수
        static bool IsGoal(char[,] map)
        {
            int goalCount = 0;
            foreach(char arr in map)
            {
                if (arr == '□')
                {
                    goalCount++;
                    break;
                }
            }

            if(goalCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //메인 함수
        static void Main(string[] args)
        {
            Position playerPos;

            bool gameOver = false;
            char[,] map;

            playerPos.x = 0;
            playerPos.y = 0;

            Start(out playerPos, out map);

            while (gameOver == false)
            {
                Render(playerPos, map);
                ConsoleKey key = Input();
                Update(key, ref playerPos, map, ref gameOver);
            }
            End();
        }
    }
}


