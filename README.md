# VR Escape Room — Meta Quest 3

## Overview

This project is a Unity-based VR escape room designed for deployment on the Meta Quest 3 headset. Players explore a mystery-themed house environment, solve room-based puzzles, unlock doors, and progress through the escape room in a linear sequence.

The application includes a main menu scene with options to view credits, explore a showcase of the lock-and-key mechanisms used in the project, or begin the full escape room experience.

## Features

- VR escape room built in Unity
- Designed for Meta Quest 3 deployment
- Main menu with:
  - Play Escape Room
  - Credits
  - Showcase of Lock and Key systems, Puzzle mechanisms, and Timer
- Room-based puzzle progression
- Locked doors and interactive puzzle objects
- Countdown timer
- Hint system
- Voice-based hint activation
- Audio for interactions

## Requirements

- Unity 2022 or later
- Meta Quest 3 headset
- Meta Quest Developer Hub or SideQuest
- Android Build Support installed in Unity
  - Android SDK
  - Android NDK
  - OpenJDK
- Meta XR SDK / Oculus XR Plugin

## Opening the Project

1. Open Unity Hub.
2. Select **Open Project**.
3. Choose the project folder.
4. Allow Unity to import all assets and packages.
5. Make sure the correct Unity version is installed.

## Build Settings

1. Go to **File > Build Settings**.
2. Select **Android** as the target platform.
3. Click **Switch Platform**.
4. Make sure the following scenes are included in the build:
   - Menu
   - House
   - showcase

## XR Project Settings

1. Go to **Edit > Project Settings**.
2. Open **XR Plug-in Management**.
3. Enable **Oculus** under the Android tab.
4. Check that the project is configured for VR interaction and Meta Quest deployment.

## Player Settings

1. Go to **Edit > Project Settings > Player**.
2. Under Android settings:
   - Set the package name.
   - Set the minimum API level required by Meta Quest.
   - Enable ARM64.
   - Make sure Internet or Microphone permissions are enabled if using voice recognition.
3. Confirm that the build target is Android.

## Building the Application

1. Connect the Meta Quest 3 headset to the computer using a USB-C cable.
2. Enable Developer Mode on the headset.
3. In Unity, go to **File > Build Settings**.
4. Select **Build and Run**.
5. Choose a location to save the APK.
6. Unity will build the project and install it onto the headset.

## Running on Meta Quest 3

1. Put on the Meta Quest 3 headset.
2. Open the app from the headset’s application library.
3. The app will start at the Main Menu.
4. Choose one of the available options:
   - **Play**: Starts the full escape room.
   - **Credits**: Displays project credits.
   - **Showcase**: Demonstrates some of the puzzle mechanisms used in the escape room.

## Gameplay Instructions

- Use the VR controllers to interact with objects and move around.
- Explore each room carefully for clues.
- Solve puzzles to unlock drawers, cabinets, doors, and hidden items.
- Progress through the rooms in order.
- Use the hint system if stuck.
- Voice hints may be activated by holding down the index trigger on the controller and saying phrases such as "hint", "help", or "I'm stuck".
- Press the joystick button to crouch.
