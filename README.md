# Project 1 — Orbiting Sword Survival

An individual CPSC 386 project: a small 2D top-down survival game built around the Weeks 1–6 topics.

## Current status

Unity starter project; gameplay has not been implemented yet.

- Current editor: **6000.6.2f1**, confirmed by the project owner for this project.
- Template includes Universal Render Pipeline, Input System, Tilemap, and Canvas UI packages.
- Entry scene for the starter: `Assets/Scenes/SampleScene.unity`.

## Planned first version

- One arena, one enemy type, and one wave of enemies spawning over time.
- Physics-based player movement and a sword that automatically orbits the player.
- Enemies reused through object pooling based on Assignment 3's pattern.
- Defeating enemies adds coins directly to inventory; coins persist using PlayerPrefs.
- Defeat all enemies to win; lose all health to be defeated.
- Main Menu and Gameplay scenes, pause/resume, Quit to Menu, and a simple hub light.

Multiple waves, shops, random item drops, and a score system are deferred.

## Open the project

1. Clone the repository.
2. In Unity Hub, add the cloned project folder.
3. Open with the editor version recorded in `ProjectSettings/ProjectVersion.txt`.
4. Allow Unity to restore packages and generate its local Library folder.
5. Open `Assets/Scenes/SampleScene.unity`.

## Version control

Commit `Assets/` (including `.meta` files), `Packages/`, and `ProjectSettings/`.
Generated caches, local editor settings, and builds are excluded by `.gitignore`.
The project uses Force Text serialization and Visible Meta Files.
Configure Git LFS before adding large binary assets; the starter currently does not require LFS.

## Development milestones

1. Project foundation and GitHub backup.
2. Player movement and Tilemap arena.
3. Sword combat, enemy health, and automatic coin rewards.
4. Pooled spawning and the single-wave win/defeat loop.
5. Menus, persistence, lighting, and testing a playable build.

## AI assistance and assets

Codex assisted with scope planning and initial repository setup (README and Git configuration files). Update this record as development continues for the course's AI-use disclosure.
The initial assets are from the Unity project template. Record the source, license, usage, and any required instructor consent for additional third-party assets.
