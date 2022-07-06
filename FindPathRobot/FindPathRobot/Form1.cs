using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FindPathRobot
{
    public partial class Form1 : Form
    {
        private const int TOTAL_SECONDS = 61;
        private const int NONE = 0;
        private const int DOWN = 1;
        private const int LEFT = 2;
        private const int RIGHT = 3;
        private const int UP = 4;

        private Random random;
        private int total_seconds;
        private int row, col;
        private int startRow, startCol;
        private bool isStarterCellClicked;
        private Cell latestClickedCell;
        private int robotScores, countRecursive, robotBestScore;

        private Cell[,] cellsPlayer, cellsRobot;
        private List<Cell> possiblePath = new List<Cell>();
        private List<Cell> bestPath = new List<Cell>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStopTime.Enabled = false;
            radioBtnPlayer.Checked = true;
            groupBoxMode.Enabled = false;
            btnNewGame.Enabled = true;
            panelPlayer.Enabled = false;
            panelRobot.Enabled = false;
            random = new Random();
            isStarterCellClicked = false;
            latestClickedCell = null;
            robotScores = countRecursive = robotBestScore = 0;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            createNewGame();
        }

        private void createNewGame()
        {
            stopTimer();
            btnStart.Enabled = true;
            radioBtnPlayer.Checked = true;
            panelPlayer.Enabled = false;
            total_seconds = TOTAL_SECONDS;
            isStarterCellClicked = false;
            latestClickedCell = null;
            robotScores = countRecursive = robotBestScore = 0;
            possiblePath.Clear();
            bestPath.Clear();
            playerScore.Text = 0 + "";
            robotScore.Text = 0 + "";
            createCells();
            displayCellsOnPanel();
        }

        private void stopTimer()
        {
            btnStopTime.Enabled = false;
            timer1.Enabled = false;
            labelTime.Text = "0s";
        }

        private void createCells()
        {
            row = random.Next(3, 10);
            col = random.Next(3, 10);
            cellsPlayer = new Cell[row, col];
            cellsRobot = new Cell[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    cellsPlayer[i, j] = new Cell();
                    cellsRobot[i, j] = new Cell();
                    configCells(ref cellsPlayer[i, j], i, j);
                    configCells(ref cellsRobot[i, j], i, j);

                    int randomBlock, randomValue;
                    randomBlock = random.Next(0, 2);
                    randomValue = random.Next(1, 100);
                    addValueToCells(ref cellsPlayer[i, j], ref randomBlock, ref randomValue);
                    addValueToCells(ref cellsRobot[i, j], ref randomBlock, ref randomValue);
                }
            }
        }

        private void configCells(ref Cell cell, int i, int j)
        {
            cell.Font = new Font(SystemFonts.DefaultFont.FontFamily, 14);
            cell.Size = new Size(44, 44);
            cell.ForeColor = SystemColors.ControlDarkDark;
            cell.Location = new Point(j * 44, i * 44); // Point(x,y) x truc hoanh = col, y truc tung = row
            cell.FlatStyle = FlatStyle.Flat;
            cell.FlatAppearance.BorderColor = Color.Black;
            cell.CellRow = i;
            cell.CellCol = j;
        }

        private void addValueToCells(ref Cell cell, ref int randomBlock, ref int randomValue)
        {
            if (randomBlock == 1)
            {
                cell.Value = randomValue;
                cell.IsLocked = false;
                cell.BackColor = SystemColors.Control;
                cell.Text = randomValue.ToString();
                // Assign click event for each not locked cells
                cell.Click += cell_mouseClick;
            }
            else
            {
                cell.Value = 0;
                cell.Text = 0 + "";
                cell.IsLocked = true;
                cell.BackColor = Color.LightGray;
            }
        }

        private void displayCellsOnPanel()
        {
            panelPlayer.Controls.Clear();
            panelRobot.Controls.Clear();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    panelPlayer.Controls.Add(cellsPlayer[i, j]);
                    panelRobot.Controls.Add(cellsRobot[i, j]);
                }
            }
        }

        private void cell_mouseClick(object sender, EventArgs e)
        {
            var cell = sender as Cell;
            if (cell.IsLocked)
                return;

            if (!isStarterCellClicked)
            {
                setStarterCell(ref cell);
                setLatestClickedCell(ref cell);
            }
            if (isNextCellOfLatestClickedCell(ref cell))
            {
                setLatestClickedCell(ref cell);
                addScores(ref cell);
                setClickedCell(ref cell);
                int cellRow = cell.CellRow;
                int cellCol = cell.CellCol;

                bool checkGoDown = isMoveable(ref cellsPlayer, cellRow + 1, cellCol);
                bool checkGoLeft = isMoveable(ref cellsPlayer, cellRow, cellCol - 1);
                bool checkGoRight = isMoveable(ref cellsPlayer, cellRow, cellCol + 1);
                bool checkGoUp = isMoveable(ref cellsPlayer, cellRow - 1, cellCol);

                if (!checkGoDown && !checkGoLeft && !checkGoRight && !checkGoUp)
                {
                    robotPlayTurn();
                    showResult();
                }
            }
        }

        private bool isNextCellOfLatestClickedCell(ref Cell cell)
        {
            if (cell.CellCol == latestClickedCell.CellCol &&
                cell.CellRow == latestClickedCell.CellRow)
            {
                return true;
            }
            if ((cell.CellRow == latestClickedCell.CellRow - 1 && cell.CellCol == latestClickedCell.CellCol) ||
                (cell.CellRow == latestClickedCell.CellRow + 1 && cell.CellCol == latestClickedCell.CellCol) ||
                (cell.CellCol == latestClickedCell.CellCol - 1 && cell.CellRow == latestClickedCell.CellRow) ||
                (cell.CellCol == latestClickedCell.CellCol + 1) && cell.CellRow == latestClickedCell.CellRow)
            {
                return true;
            }
            return false;
        }

        private void setStarterCell(ref Cell cell)
        {
            startRow = cell.CellRow;
            startCol = cell.CellCol;
            isStarterCellClicked = true;
        }

        private void setLatestClickedCell(ref Cell cell)
        {
            latestClickedCell = cell;
        }

        private void addScores(ref Cell cell)
        {
            if (!cell.IsLocked)
            {
                int currentScores = int.Parse(playerScore.Text.ToString()) + cell.Value;
                playerScore.Text = currentScores + "";
            }
        }

        private void setClickedCell(ref Cell cell) 
        {
            cell.IsLocked = true; 
            cell.BackColor = Color.BlueViolet; 
            cell.ForeColor = Color.White;
            if (cell.CellRow == startRow && cell.CellCol == startCol) // O(3)
            {
                cell.FlatAppearance.BorderColor = Color.DarkOrange;
                cell.FlatAppearance.BorderSize = 3;
            }
        }

        private bool isMoveable(ref Cell[,] cells, int i, int j)
        {
            if (i >= 0 && i < row && j >= 0 && j < col && !cells[i, j].IsLocked)
            {
                return true;
            }
            return false;
        }

        private void robotPlayTurn()
        {
            stopTimer();
            panelPlayer.Enabled = false;
            radioBtnRobot.Checked = true;
            if (!isStarterCellClicked)
                return;
            robotFindPath(startRow, startCol);
        }

        private void showResult()
        {
            if (!isStarterCellClicked)
            {
                MessageBox.Show(
                    "You didn't check starter cell\nPlease try new game!",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            int playerBestScores = int.Parse(playerScore.Text.ToString());
            if (playerBestScores < robotBestScore)
                MessageBox.Show("You Lost!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (playerBestScores == robotBestScore)
                MessageBox.Show("Draw!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("You Won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelPlayer.Enabled = true;
            btnStart.Enabled = false;
            btnStopTime.Enabled = true;
            timer1.Enabled = true;
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            robotPlayTurn();
            showResult();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (total_seconds > 0)
            {
                total_seconds--;
                labelTime.Text = total_seconds.ToString() + "s";
            }
            else
            {
                robotPlayTurn();
                showResult();
            }
        }

        private void robotFindPath(int startRow, int startCol)
        {
            robotScores += cellsRobot[startRow, startCol].Value;
            cellsRobot[startRow, startCol].IsLocked = true;
            possiblePath.Add(cellsRobot[startRow, startCol]);
            bool checkGoDown = isMoveable(ref cellsRobot, startRow + 1, startCol); 
            bool checkGoLeft = isMoveable(ref cellsRobot, startRow, startCol - 1);
            bool checkGoRight = isMoveable(ref cellsRobot, startRow, startCol + 1);
            bool checkGoUp = isMoveable(ref cellsRobot, startRow - 1, startCol);

            if (checkGoDown || checkGoLeft || checkGoRight || checkGoUp)
            {
                // Down
                if (checkGoDown)
                {
                    countRecursive++;
                    robotFindPath(startRow + 1, startCol);
                }
                // Left
                if (checkGoLeft)
                {
                    countRecursive++;
                    robotFindPath(startRow, startCol - 1);
                }
                // Right
                if (checkGoRight)
                {
                    countRecursive++;
                    robotFindPath(startRow, startCol + 1);
                }
                // Up
                if (checkGoUp)
                {
                    countRecursive++;
                    robotFindPath(startRow - 1, startCol);
                }
                if (countRecursive != 0)
                {
                    countRecursive--;
                    robotScores -= cellsRobot[startRow, startCol].Value;
                    if (possiblePath.Count > 0)
                        possiblePath.RemoveAt(possiblePath.Count - 1);
                    cellsRobot[startRow, startCol].IsLocked = false;
                    return;
                }
                else
                {
                    updateRobotMoveOntoPanel();
                    return;
                }
            }
            else
            {
                if (robotScores > robotBestScore)
                {
                    robotBestScore = robotScores;
                    bestPath.Clear();
                    foreach (var item in possiblePath)
                    {
                        bestPath.Add(cellsRobot[item.CellRow, item.CellCol]);
                    }
                }
                if (countRecursive != 0)
                {
                    countRecursive--;
                    robotScores -= cellsRobot[startRow, startCol].Value;
                    if (possiblePath.Count > 0)
                        possiblePath.RemoveAt(possiblePath.Count - 1);
                    cellsRobot[startRow, startCol].IsLocked = false;
                    return;
                }
                else
                {
                    updateRobotMoveOntoPanel();
                    return;
                }
            }
        }

        private void updateRobotMoveOntoPanel()
        {
            robotScore.Text = robotBestScore + "";
            foreach (var item in bestPath)
            {
                var cell = item as Cell;
                setClickedCell(ref cell);
            }
        }
    }
}