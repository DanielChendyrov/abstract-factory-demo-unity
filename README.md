# Abstract Factory design pattern demo

This is a small demo for our Abstract Factory presentation.

## Introduction

We are from class SE1501-NET of FPT University, subject name: PRU221m (a.k.a Advanced Unity Programming).
Our group consist of 2 members:  

* Đinh Tuấn Anh. Student code: HE150285. GitHub profile: [DanielChendyrov](https://github.com/DanielChendyrov)  
* Phùng Quang Thông. Student code: HE150340. GitHub profile: [ThongVipPro](https://github.com/ThongVipPro)  
  
Teacher: Ngô Tùng Sơn - [Email](sonnt5@fpt.edu.vn)

## Gameplay description

* This is a Unity project to demonstrate how to implement the Abstract Factory Pattern in Unity.
* There are 2 types of enemy created from abstract factory design pattern (Boss and Creep).
* When the game starts player can move up and down using arrow buttons or WASD control scheme and pressing "space" can shoot bullets to destroy enemies.
* The player can create portals to spawn enemies by pressing the "q" or "e" button from the keyboard.
  * When player select "e": create a portal for Creep enemies.
  * When player select "q": create a portal for Boss enemies.
* Note:
  * Player can create as many portals as they can.
  * Creep enemies are capsule shaped while Boss enemies are square shaped. Portals are circles with yellow and red color for Creep and Boss respectively.
  * Fast enemies are colored purple while slow ones are colored blue.
  * Bosses take more damage and are generally slower than Creeps.

## Code Implementation

The game has 2 families of enemies: [Boss] and [Creep], whose classes inherit from the abstract class [Enemy]. [Enemy] class initiates enemies' attributes and return their [EnemyType]. From each family there are 2 variants: fast and slow, both inherit from their respective family class.  

Each enemy family are created by their own factory assigned to the portal they are spawned from, namely: [CreepFactory] and [BossFactory]. Both of them inherit from the abstract class [EnemyFactory]. [EnemyFactory] class has 2 abstract methods: [CreateFastEnemy()] and [CreateSlowEnemy()] which are overidden in their child classes. Each factory counts time by calling class [Timer] and executes a random method from the 2 mentioned above after a certain interval.

## Project configurations

This is a standard Unity2D project that was created and coded on Unity editor version 2021.3.2f1 LTS and
Visual Studio IDE version 2022. To use the project and make your own changes, simply clone it to your computer
using any git management tool of your choice.
