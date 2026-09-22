# 🎮 IGI-3 — Third Person Shooter Game

**IGI-3** is a 3D **Third Person Shooter (TPS)** game developed using **Unity and C#**. The game focuses on player movement, shooting, enemy AI, health management, UI, animations, and complete mission-based gameplay.

The player controls a soldier inside a guarded environment and must eliminate all enemies to successfully complete the mission.

---

## 👤 Developer

**Ummehani Khatri**

**Project:** IGI-3 — Third Person Shooter Game
**Engine:** Unity
**Language:** C#

---
## 🎮 Gameplay Video

Watch the complete gameplay demonstration of **IGI-3 — Third Person Shooter Game**:

**▶️ [Watch Gameplay Video on Google Drive](https://drive.google.com/file/d/1W4UoNFDo20XIA9t9L-sS-ZxXxmoEZBLY/view?usp=sharing)**

The video demonstrates:

* Player movement and third-person camera
* Enemy patrol and detection
* Shooting and reload mechanics
* Enemy AI combat
* Health system
* Enemy counter
* Win and Game Over conditions
* Complete gameplay flow

## 📌 Project Overview

IGI-3 is a single-level third-person shooter game designed to demonstrate practical game-development concepts.

The project integrates:

* 🎮 Third-person player controller
* 🔫 Shooting and reload mechanics
* 🤖 Enemy AI
* 🧭 NavMesh navigation
* 👀 Enemy detection system
* ❤️ Health and damage system
* 🎨 Gameplay UI
* 🎬 Enemy animations
* 🏠 Main menu
* 💀 Game Over screen
* 🏆 Win screen

The project follows a complete development process including requirement analysis, system design, implementation, testing, and evaluation.

---

## 🎯 Objectives

The main objectives of IGI-3 are:

* Develop a third-person player controller
* Implement enemy patrol and attack behaviour
* Create a shooting and reload system
* Implement player and enemy health systems
* Design an interactive gameplay UI
* Implement complete game flow
* Apply object-oriented programming using C#
* Understand Unity's GameObject and component architecture
* Work with physics, collision detection, animation, and navigation

---

## 🛠️ Technologies Used

| Technology              | Purpose                                |
| ----------------------- | -------------------------------------- |
| **Unity 3D**            | Game development engine                |
| **C#**                  | Game logic and scripting               |
| **NavMesh**             | Enemy navigation and pathfinding       |
| **CharacterController** | Player movement                        |
| **Unity Physics**       | Bullet and collision mechanics         |
| **Animator**            | Character/enemy animations             |
| **Unity UI**            | Health, enemy counter and game screens |
| **Visual Studio**       | C# development                         |
| **Windows PC**          | Target platform                        |

---

# 🎮 Gameplay Features

## 👤 Player System

The player can:

* Move forward and backward
* Move left and right
* Rotate using the mouse
* Navigate through the 3D environment
* Shoot enemies
* Reload the weapon

Player movement is implemented using Unity's `CharacterController`.

The third-person camera follows the player from behind and rotates according to mouse movement.

---

## 🔫 Shooting System

The shooting system uses bullet prefabs.

### Player Shooting Flow

```text
Player presses Fire
        ↓
Bullet prefab instantiated
        ↓
Bullet moves forward
        ↓
Bullet collides with enemy
        ↓
Enemy health decreases
```

The weapon also includes:

* Limited magazine capacity
* Reload key (`R`)
* Reload delay
* Shooting disabled while reloading

---

# 🤖 Enemy AI

Enemy behaviour is implemented using a **Finite State Machine (FSM)**.

### Enemy States

```text
PATROL
   ↓
DETECTION
   ↓
ATTACK
   ↓
DEATH
```

### Patrol

Enemies move between predefined waypoints using Unity's navigation system.

### Detection

Enemies detect the player using distance checking.

**Detection radius: 5 meters**

```text
Distance < Vision Radius
        ↓
Player Detected
```

### Attack

When the player enters the detection range:

* Enemy stops patrolling
* Enemy rotates toward the player
* Enemy shoots at the player

### Death

When enemy health reaches zero:

* Death animation plays
* Enemy is removed from the scene
* Enemy counter is updated

---

# 🧭 NavMesh Navigation

Unity's **NavMesh** is used for enemy movement.

The implementation includes:

1. Ground marked for navigation
2. NavMesh baked for the environment
3. `NavMeshAgent` added to enemies
4. Waypoints assigned for patrol movement

This allows enemies to navigate around obstacles automatically.

---

# ❤️ Health System

Both the player and enemies have health systems.

### Player

* Initial health: **100**
* Enemy bullets reduce player health
* Health is displayed using a UI slider
* Health reaching `0` triggers Game Over

### Enemy

* Player bullets reduce enemy health
* Death animation plays when health reaches `0`
* Enemy is destroyed after death

---

# 🎨 User Interface

The game provides real-time gameplay information through its UI.

### UI Components

* Crosshair
* Health slider
* Enemy counter
* Main menu
* Game Over screen
* Win screen

### Enemy Counter

The enemy counter displays the number of remaining enemies.

```text
Enemy Count
     ↓
Enemy defeated
     ↓
Counter decreases
     ↓
All enemies defeated
     ↓
Win Screen
```

---

# 🧭 Game Flow

The complete game flow is:

```text
Main Menu
    ↓
Start Game
    ↓
Gameplay
    ↓
Enemy Patrol
    ↓
Player Detection
    ↓
Combat
   ↙ ↘
Win     Game Over
```

### 🏆 Win Condition

The player wins when:

```text
Enemy Count = 0
```

### 💀 Lose Condition

The game ends when:

```text
Player Health = 0
```

---

# 🏗️ Game Architecture

The project follows a modular architecture consisting of four major modules:

```text
                 IGI-3
                   |
        ┌──────────┴──────────┐
        │                     │
   Player Module        Enemy AI Module
        │                     │
        └──────────┬──────────┘
                   │
             Combat System
                   │
                   ↓
          UI & Game Flow
```

The modules communicate through Unity GameObjects and C# scripts.

---

# 📂 Main Systems

| Module    | Description                             |
| --------- | --------------------------------------- |
| Player    | Movement, camera and player interaction |
| Shooting  | Bullet creation and firing              |
| Reload    | Magazine and reload mechanics           |
| Enemy AI  | Patrol, detection and attack            |
| NavMesh   | Enemy navigation                        |
| Combat    | Player/enemy bullet interactions        |
| Health    | Player and enemy health                 |
| UI        | Health, crosshair and enemy counter     |
| Game Flow | Menu, gameplay, win and Game Over       |

---

# 🧪 Testing

Different testing approaches were used during development:

### Unit Testing

Testing individual scripts and components.

### Integration Testing

Testing interaction between different game modules.

### Gameplay Testing

Testing the game through actual gameplay.

### Debug Testing

Identifying and fixing implementation errors.

### Tested Features

* Player movement
* Camera movement
* Shooting
* Reloading
* Enemy navigation
* Enemy patrol
* Player detection
* Enemy shooting
* Health system
* UI updates
* Win condition
* Game Over condition

---

# 📊 Results

The major implemented features were successfully tested:

| Feature             | Result        |
| ------------------- | ------------- |
| Player Movement     | ✅ Implemented |
| Third-Person Camera | ✅ Implemented |
| Shooting System     | ✅ Working     |
| Reload System       | ✅ Working     |
| Enemy AI            | ✅ Implemented |
| Enemy Patrol        | ✅ Working     |
| Player Detection    | ✅ Working     |
| Enemy Shooting      | ✅ Working     |
| Enemy Animations    | ✅ Working     |
| Health System       | ✅ Working     |
| Enemy Counter       | ✅ Working     |
| Main Menu           | ✅ Implemented |
| Game Over Screen    | ✅ Implemented |
| Win Screen          | ✅ Implemented |

---

# 📸 Screenshots

Add your gameplay screenshots here.

```text
screenshots/
├── main-menu.png
├── gameplay.png
├── enemy-patrol.png
├── shooting.png
├── health-system.png
├── game-over.png
└── win-screen.png
```

Example:

```markdown
![Main Menu](screenshots/main-menu.png)

![Gameplay](screenshots/gameplay.png)
```

---

# 💻 Development Environment

**Game Engine:** Unity 3D
**Programming Language:** C#
**IDE:** Visual Studio
**Platform:** Windows PC
**Graphics Pipeline:** Unity Built-in Render Pipeline

---

# ⚠️ Current Limitations

The current version focuses on fundamental game-development concepts and therefore has some limitations:

* Single-level gameplay
* Basic enemy AI behaviour
* No sound effects or background music
* No multiplayer mode
* Limited weapon variety

---

# 🚀 Future Improvements

Possible future improvements include:

### 🎮 Gameplay

* Multiple levels and missions
* Different weapons
* Power-ups
* Inventory system
* Weapon upgrade system

### 🤖 AI

* Advanced enemy pathfinding
* Smarter enemy decision-making
* Boss enemies

### 🎨 Graphics & Audio

* Sound effects
* Background music
* Improved lighting
* Better environment design
* Particle effects
* Explosions

### 🌐 Advanced Features

* Multiplayer mode
* Mobile version
* Save/Load system

---

# 📚 Learning Outcomes

This project provided practical experience in:

### Unity Development

* Scene creation
* GameObject and component system
* Physics
* Collision detection
* Navigation and pathfinding

### C# Programming

* Object-oriented programming
* Script communication
* Modular programming
* Debugging and error handling

### Game Development

* Gameplay mechanics
* Enemy AI
* Animation
* UI design
* Game-state management

---

# 🏁 Conclusion

IGI-3 demonstrates the development of a complete **3D Third Person Shooter game using Unity and C#**.

The project integrates player control, artificial intelligence, shooting mechanics, animation, physics, health management, UI, and game-flow management into a single playable game.

It provides a foundation for further development into a larger multi-level shooter with advanced AI, additional weapons, audio, multiplayer functionality, and improved graphics.

---

## 📖 References

* Unity Official Documentation
* Unity Learn Tutorials
* C# Programming Guide
* Game Development Resources

---

## 👨‍💻 Author

**Ummehani Khatri**

> IGI-3 — Third Person Shooter Game
> Developed using Unity & C#
