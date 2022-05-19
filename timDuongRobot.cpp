#include <iostream>
#include <fstream>
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
    void inputFile(void)
    {
        std::fstream readfile("input.txt", std::ios::in);
        readfile >> row;
        readfile >> col;
        for (int i = 0; i < row; i++)
            for (int j = 0; j < col; j++)
            {
                readfile >> matrix[i][j];
            }
        readfile.close();
    }

    void init(void)
    {
        inputFile();
        while (true)
        {
            system("cls");
            std::cout << "Nhap vi tri khoi dau cua robot (row, col): ";
            std::cin >> startRow >> startCol;
            if (startRow <= row - 1 || startCol <= col - 1)
            {
                break;
            }
        }
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

    void outputFile(void)
    {
        std::fstream writefile("output.txt", std::ios::out);
        if (!writefile.is_open())
        {
            std::cout << "\nERROR: Could not write file!\n";
            return;
        }
        for (auto items : bestPath)
        {
            writefile << items << " ";
        }
        writefile << "\nMax value: " << maxValue;
        writefile.close();
        std::cout << "INFO: Write file finished\nMax path value is " << maxValue << std::endl;
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
        Try(startRow, startCol);
    }
};

int TimDuongRobot::countRecursive = 0;

int main()
{
    TimDuongRobot robot;
    robot.init();
    robot.execute();
    robot.outputFile();
    return 0;
}