## **TimDuongRobot (RobotFindPath)**

This repository provides RobotFindPath - big project code sample - for Students of the University of Transport HCMC.


### **Overview**

This project app is written in C# Windows Forms.

The algorithm used by this project is [Brute-force search](https://en.wikipedia.org/wiki/Brute-force_search).

Time complexity is O($2^n$)

### **Gameplay**

The player will play against a robot. The player clicks directly to the cells on the player's panel. Zero-value cells consider a roadblock (cannot be clicked). Each cell can only click once. Try your best to collect the maximum point on the way. The player's turn end if there is no road left to go or the clock countdown to zero, then the robot will start its turn. The result of the game will popup on the screen after the robot finish its turn.

Note: *Because of the Brute-force search algorithm, the player cannot win the robot (the best result you can get is draw).*

### **Picture**

<img src="./pictures/gameplay-1.png" width="100%"/>

### **Recommendations for further project development**

* Apply more algorithms (e.g. [Greedy](https://en.wikipedia.org/wiki/Greedy_algorithm)).
* Design better UX/UI.

### **Contributing**
Feel free to contribute valuable changes directly to the corresponding projects. Many students will be appreciated!