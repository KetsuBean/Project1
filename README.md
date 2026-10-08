# Project 1 — Orbiting Sword Survival

## Script summary

| Script | Purpose |
| --- | --- |
| PlayerMovement | Reads the Move input action and moves the player through Rigidbody2D. |
| PlayerHealth | Tracks health, updates the health label, and triggers game over on death. |
| CameraFollow | Follows the living player and stays in place after death. |
| SwordOrbit | Rotates the sword pivot around the player. |
| SwordDamage | Detects enemy triggers and applies sword damage. |
| EnemyMovement | Moves enemies toward the player. |
| EnemyHealth | Resets health when reused, takes damage, awards a kill, and deactivates defeated enemies. |
| EnemyDamage | Applies contact damage with a cooldown between hits. |
| SimplePool | Creates ten enemy instances and supplies inactive instances for reuse. |
| EnemySpawner | Continuously spawns pooled enemies at random spawn points and assigns their scene references. Stops spawning after player death. |
| RunScore | Counts kills, updates score labels, and saves the highest kill count with PlayerPrefs. |
| SceneController | Loads Gameplay or MainMenu and restores normal time. |
| PauseManager | Toggles the pause panel with Escape and pauses or resumes time. |
| GameOverManager | Shows the game-over panel, stops gameplay, and handles Retry and Main Menu. |

Unused earlier scripts remain in the project: PlayerInventory handled coins; PauseMenu and PauseMenuButtons handled an additive pause scene. These are not used in the submitted game. Welcome2DScript belongs to the Unity template's welcome content.

## Scenes and key GameObjects

- **MainMenu:** The Canvas contains the Start button. Its click calls SceneController on MenuController to load Gameplay. The EventSystem handles UI input.
- **Gameplay:** Player contains movement and health components, a SwordPivot/Sword for automatic attacks, and PlayerLight. Main Camera follows Player. Environment holds the collidable Walls Tilemap, Ground, AmbientLight, and spawn points. GameplaySystems manages spawning, scores, pause, and game over; its EnemyPool supplies reusable Enemy prefab instances. Sword hits reduce enemy health and defeated enemies increase the score. Enemy contact reduces player health. The Canvas displays health, score, and high score, plus pause and game-over panels. Death stops gameplay; Retry reloads the scene, and Main Menu returns to the start screen.
- **Unused scenes:** SampleScene, the URP2DSceneTemplate, and the earlier PauseMenuUI scene are not included in the build. Pausing now uses a panel within Gameplay.

## Assignment requirements

1. **Scene management:** MainMenu's Start button loads Gameplay; Quit to Menu and the game-over Main Menu button return to MainMenu.
2. **Input System and physics:** PlayerControls defines movement actions; Player Input supplies input to Rigidbody2D movement with a Collider2D.
3. **Tilemap:** The arena boundary uses a Tilemap with Tilemap Collider 2D to block movement.
4. **Prefabs and pooling:** SimplePool reuses ten Enemy prefab instances instead of repeatedly instantiating and destroying enemies.
5. **Tags/layers and triggers:** SwordDamage uses OnTriggerEnter2D and CompareTag("Enemy") for combat; gameplay objects currently use the Default physics layer.
6. **Pause menu:** A Canvas panel provides Resume and Quit to Menu; Escape toggles pause using Time.timeScale.
7. **Persistence:** PlayerPrefs saves and reloads the highest kill count using `KillHighScore`, while each new run resets the current score.
8. **Lighting/materials:** PlayerLight follows the player and illuminates lit sprites, with AmbientLight providing dim background lighting.

## Assets, packages, and assistance

- **Unity resources:** Built-in sprites and simple shapes provide the placeholder art.
- **AI disclosure:** OpenAI Codex was used for documentation, debugging, and assistance drafting and adapting some scripts not covered in class, like continuous enemy spawning.
