#include <iostream>
#include <ctime>
#include <vector>
#define MAX 20
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

    bool isMoveable(int i, int j)
    {

        // Down
        if (flag[i + 1][j] == 0 && matrix[i + 1][j] != 0 && i + 1 < row)
        {
            return true;
        }
        // Left
        if (flag[i][j - 1] == 0 && matrix[i][j - 1] != 0 && j - 1 >= 0)
        {
            return true;
        }
        // Right
        if (flag[i][j + 1] == 0 && matrix[i][j + 1] != 0 && j + 1 < col)
        {
            return true;
        }
        // Up
        if (flag[i - 1][j] == 0 && matrix[i - 1][j] != 0 && i - 1 >= 0)
        {
            return true;
        }
        return false;
    }

    void Try(int startRow, int startCol)
    {
        for (int i = startRow; i < row; i++)
        {
            for (int j = startCol; j < col; j++)
            {
                if (flag[i][j] == 1)
                {
                    // currentValue = 0;
                    continue;
                }
                if (matrix[i][j] == 0)
                {
                    flag[i][j] = 1;
                    continue;
                }
                else // Move-able
                {
                    if (isMoveable(i, j))
                    {
                        currentValue += matrix[i][j];
                        flag[i][j] = 1;
                        possiblePath.push_back(matrix[i][j]);
                        // Down
                        if (flag[i + 1][j] == 0 && matrix[i + 1][j] != 0 && i + 1 < row)
                        {

                            countRecursive++;
                            Try(i + 1, j);
                        }
                        // Left
                        if (flag[i][j - 1] == 0 && matrix[i][j - 1] != 0 && j - 1 >= 0)
                        {
                            countRecursive++;
                            Try(i, j - 1);
                        }
                        // Right
                        if (flag[i][j + 1] == 0 && matrix[i][j + 1] != 0 && j + 1 < col)
                        {
                            countRecursive++;
                            Try(i, j + 1);
                        }
                        // Up
                        if (flag[i - 1][j] == 0 && matrix[i - 1][j] != 0 && i - 1 >= 0)
                        {
                            countRecursive++;
                            Try(i - 1, j);
                        }
                        if (countRecursive != 0)
                        {
                            countRecursive--;
                            currentValue -= matrix[i][j];
                            possiblePath.pop_back();
                            return;
                        }
                    }
                    else
                    {
                        currentValue += matrix[i][j];
                        flag[i][j] = 1;
                        possiblePath.push_back(matrix[i][j]);

                        if (currentValue > maxValue)
                        {
                            maxValue = currentValue;
                            bestPath.clear();
                            bestPath = possiblePath;
                        }
                        if (countRecursive != 0)
                        {
                            countRecursive--;
                            currentValue -= matrix[i][j];
                            possiblePath.pop_back();
                            return;
                        }
                        continue;
                    }
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
