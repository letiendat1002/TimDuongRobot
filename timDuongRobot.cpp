#include <iostream>
#include <ctime>
#include <vector>
#define MAX 20
#define NONE 0
#define DOWN 1
#define LEFT 2
#define RIGHT 3
#define UP 4
class TimDuongRobot
{
private:
    static int countRecursive;
    int row, col, startRow, startCol, currentValue, maxValue;
    int matrix[MAX][MAX], flag[MAX][MAX];
    std::vector<int> possiblePath, bestPath;

public:
    void init(void)
    {
        srand(time(NULL));
        row = rand() % 8 + 3;
        col = rand() % 8 + 3;

        for (int i = 0; i < row; i++)
            for (int j = 0; j < col; j++)
            {
                int randomBlock = rand() % 2;
                if (randomBlock == 1)
                    matrix[i][j] = rand() % 101;
                else
                    matrix[i][j] = 0;
            }

        while (true)
        {
            startRow = rand() % row;
            startCol = rand() % col;
            if (matrix[startRow][startCol] != 0)
                break;
        }
        std::cout << "Vi tri khoi dau cua robot (row, col): ("
                  << startRow << ", " << startCol << ")\n";

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                flag[i][j] = 0;
            }
        }
        currentValue = 0;
        maxValue = 0;
    }

    void output(void)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                std::cout << matrix[i][j] << " ";
            }
            std::cout << "\n";
        }
        std::cout << "\n";
        for (auto items : bestPath)
        {
            std::cout << items << " ";
        }
        std::cout << "\nMax value: " << maxValue;
    }

    int isMoveable(int startRow, int startCol)
    {

        // Down
        if (startRow + 1 < row && flag[startRow + 1][startCol] == 0 && matrix[startRow + 1][startCol] != 0)
        {
            return DOWN;
        }
        // Left
        if (startCol - 1 >= 0 && flag[startRow][startCol - 1] == 0 && matrix[startRow][startCol - 1] != 0)
        {
            return LEFT;
        }
        // Right
        if (startCol + 1 < col && flag[startRow][startCol + 1] == 0 && matrix[startRow][startCol + 1] != 0)
        {
            return RIGHT;
        }
        // Up
        if (startRow - 1 >= 0 && flag[startRow - 1][startCol] == 0 && matrix[startRow - 1][startCol] != 0)
        {
            return UP;
        }
        return NONE;
    }

    void Try(int startRow, int startCol)
    {
        if (flag[startRow][startCol] == 1)
        {
            return;
        }
        if (matrix[startRow][startCol] == 0)
        {
            flag[startRow][startCol] = 1;
            return;
        }
        else // Can go from here
        {
            if (isMoveable(startRow, startCol) != NONE)
            {
                currentValue += matrix[startRow][startCol];
                flag[startRow][startCol] = 1;
                possiblePath.push_back(matrix[startRow][startCol]);
                // Down
                if (isMoveable(startRow, startCol) == DOWN)
                {
                    countRecursive++;
                    Try(startRow + 1, startCol);
                }
                // Left
                if (isMoveable(startRow, startCol) == LEFT)
                {
                    countRecursive++;
                    Try(startRow, startCol - 1);
                }
                // Right
                if (isMoveable(startRow, startCol) == RIGHT)
                {
                    countRecursive++;
                    Try(startRow, startCol + 1);
                }
                // Up
                if (isMoveable(startRow, startCol) == UP)
                {
                    countRecursive++;
                    Try(startRow - 1, startCol);
                }
                if (countRecursive != 0)
                {
                    countRecursive--;
                    currentValue -= matrix[startRow][startCol];
                    possiblePath.pop_back();
                    return;
                }
            }
            else
            {
                currentValue += matrix[startRow][startCol];
                flag[startRow][startCol] = 1;
                possiblePath.push_back(matrix[startRow][startCol]);

                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                    bestPath.clear();
                    bestPath = possiblePath;
                }
                if (countRecursive != 0)
                {
                    countRecursive--;
                    currentValue -= matrix[startRow][startCol];
                    possiblePath.pop_back();
                    return;
                }
            }
        }
    }

    void execute(void)
    {
        init();
        Try(startRow, startCol);
        output();
    }
};

int TimDuongRobot::countRecursive = 0;

int main()
{
    TimDuongRobot robot;
    robot.execute();
    return 0;
}
