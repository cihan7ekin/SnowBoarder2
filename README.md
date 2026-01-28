# 🏂 Snow Boarder: Physics-Based 2D Arcade

![Physics](https://img.shields.io/badge/Physics-Rigidbody%202D-blue)
![Status](https://img.shields.io/badge/Status-Completed-green)

> **Note:** This project was developed specifically to explore the new features of **Unity 6** and master **Physics-based character controllers**.

## 📖 Project Overview
Snow Boarder is a side-scrolling arcade game driven entirely by 2D physics. Unlike kinematic character controllers, the player's movement relies on **momentum, friction, and torque**. The goal was to create a fluid gameplay experience where the player must balance the boarder dynamically while traversing procedural-feeling terrain.

![Gameplay Demo](LINK_TO_YOUR_GIF_HERE)

## ⚙️ Key Technical Features

### 1. Physics-Based Movement (Torque & Momentum)
Implemented a control scheme based on **Angular Velocity** rather than direct position manipulation.
* **Torque Control:** The player rotates using `Rigidbody2D.AddTorque()`, requiring the player to manage momentum to land safely.
* **Momentum Preservation:** Tuned linear drag and gravity scales to ensure the snowboarder carries speed through loops and jumps realistically.

```csharp
// Physics-based rotation logic
void RotatePlayer()
{
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        rb2d.AddTorque(torqueAmount); // Rotating against physics
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        rb2d.AddTorque(-torqueAmount);
    }
}

### 2. Unity 6 & Surface Effectors
Built using the **Unity 6 Preview** to test the engine's latest stability and 2D toolset updates.

* **Surface Effector 2D:** Utilized this component on terrain colliders to create "boost zones" that modify the friction and speed of the player upon contact, simulating the acceleration of sliding on ice/snow.
* **Crash Detection:** Implemented sensitive collision detection logic (*Head vs. Ground*) to trigger fail states.

### 3. Visual Polish (Particle Systems)
* **Feedback Loops:** Integrated Unity's **Particle System** for snow trails. The emission rate creates a visual cue for the player, indicating when they are grounded vs. airborne.

## 🛠️ Tech Stack
* **Engine:** Unity 6 (Latest Version)
* **Physics:** Rigidbody2D, Circle/Capsule Colliders, Surface Effector 2D
* **Language:** C#
* **VFX:** Unity Particle System