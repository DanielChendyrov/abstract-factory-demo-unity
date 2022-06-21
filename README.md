# Abstract Factory design pattern demo

This is a small demo for our Abstract Factory presentation.

## Introduction

We are from class SE1501-NET of FPT University, subject name: PRU221m (a.k.a Advanced Unity Programming).
Our group consist of 2 members:  
Đinh Tuấn Anh. Student code: HE150285. GitHub profile: [DanielChendyrov](https://github.com/DanielChendyrov)  
Phùng Quang Thông. Student code: HE150340. GitHub profile: [ThongPQHE150340](https://github.com/ThongVipPro)  
Teacher: SONNT  

## Project description
This is a Unity project to demonstrate how to implement the Abstract Factory Pattern in Unity.  
The Game Scene consists of a player and emnermy. There are 2 types of enemy created from abstract factory design pattern(boss and creep).  
When the game starts we will have 1 player who can move up and down and when pressing "space" can shoot bullets to destroy enemies.  
The player can create enemies by pressing the "q" or "e" button from the keyboard.  
In one hand, when player select "e": abstract factory will create game object and this build random slow creep and fast creep.  
In anthor hand, player select "q" create game object, the task of this game object is the same as when the player selects "e" but this create boss.  
* Player can create many gameobj to create enermy in screen.  
  The monsters will move in a straight line along the positive x-axis and the player need to
  destroy them as quickly as possible when they are spawned.

## Project configurations

This is a standard Unity2D project that was created and coded on Unity editor version 2021.3.2f1 LTS and
Visual Studio IDE version 2022. To use the project and make your own changes, simply clone it to your computer
using any git management tool of your choice.
