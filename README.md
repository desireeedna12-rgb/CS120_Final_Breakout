
# CS120 Final Project - Island Breakout

## Project Overview

Island Breakout is a customized Breakout-style game created for the CS120 Final Project using Visual Basic .NET and WPF.

The project follows Breakout Tutorial Parts 1 through 6 and transforms the original tutorial into a tropical island-themed game. The project includes a custom tropical background, custom tropical paddle, custom tropical ball, paddle movement, ball movement, collision detection, wall collision, breakable bricks, score tracking, lives, and game-over behavior.

---

## Important File Access Note

Some project documents may display a **Raw** or **View raw** option when opened through GitHub instead of showing a full preview.

If a document does not preview directly in GitHub:

1. Click the file name.
2. Select **Raw** or **View raw**.
3. The file can then be opened or downloaded to view the complete document.

Files that may require this include PDF, Word, or other document formats stored in the repository.

All required project files remain accessible through the repository even if GitHub does not display an in-browser preview.

---

## How to Run the Game

1. Open the `Breakout/` folder.
2. Open the Breakout Visual Studio project/solution.
3. Build and run the project in Visual Studio.
4. Use the keyboard controls to move the paddle left and right.
5. Keep the ball in play by bouncing it off the paddle.
6. Break the bricks with the ball.
7. Each destroyed brick increases the player's score.
8. Missing the ball causes the player to lose a life.
9. The game ends when all lives are lost.

---

# Deliverable Map

This README provides an immediate map to the required CS120 Final Project deliverables.

## 1. Working Breakout Game

**Location:** `Breakout/`

The `Breakout/` folder contains the Visual Basic .NET/WPF project and source code for Island Breakout.

The completed game includes:

- Working game loop
- Paddle movement
- Ball movement
- Paddle collision
- Directional ball bounce
- Wall collision
- Breakable bricks
- Brick collision
- Score tracking
- Lives system
- Ball reset after a missed ball
- Game-over behavior
- Tropical visual customization

---

## 2. Game Assets

**Location:** `Assets/Images/`

This folder contains the custom visual assets used to transform the tutorial project into Island Breakout.

Assets include the tropical artwork used for the:

- Island background
- Tropical paddle
- Tropical ball

The custom artwork is used while preserving the gameplay systems developed through the Breakout tutorials.

---

## 3. Breakout Tutorial Parts 1-6

**Game implementation:** `Breakout/`

**Tutorial evidence:** `Evidence/`

**Development record:** `DailyBuildLog.md`

Tutorial Parts 1 through 6 were completed in order and tested throughout development.

Evidence includes:

- `Evidence/Part1-Island-Background-Working.png`
- `Evidence/Part2_GameLoop_Working.png`
- `Evidence/Part3_CustomTropicalPaddle_Working.png`
- `Evidence/Part3_PaddleMovement_Working.png`
- `Evidence/Part4_Ball_Working.png`
- `Evidence/Part4_CustomTropicalBall_Working.png`
- `Evidence/Part5_CollisionHitTest_Working.png`
- `Evidence/Part6_WallCollision_Working.png`

These checkpoints document the development of Island Breakout through Tutorial Parts 1-6.

---

## 4. Personal Version / Gameplay Expansion

Island Breakout expands the tutorial project with a custom tropical theme and additional gameplay systems.

The personal version includes:

- Tropical island background
- Custom tropical paddle artwork
- Custom tropical ball artwork
- Breakable brick system
- Brick collision detection
- Score system
- Lives system
- Ball reset after losing a life
- Game-over behavior

**Source code:** `Breakout/`

**Working evidence:**

`Evidence/Session9_BricksScoreLives_Working.png`

---

## 5. Game Development Document

**Location:** Game Development Document in the repository root.

The Game Development Document contains the planning and design information for Island Breakout, including the game concept, background story, variables, communication, game information, and game rules.

**File access:** If GitHub displays **Raw** or **View raw** instead of a document preview, select that option to open or download the complete document.

---

## 6. Game Logic Flowchart

**Location:**

`Evidence/IslandBreakout_GameLogicFlowchart.png`

The Game Logic Flowchart documents the main gameplay cycle, including:

1. Read player input.
2. Move game objects.
3. Detect collisions.
4. Handle paddle, wall, and brick collisions.
5. Update score and lives.
6. Draw the updated game state.
7. Determine whether gameplay continues.
8. End the game when the player runs out of lives.

The flowchart is stored as a PNG image and can be viewed directly through the `Evidence/` folder.

---

## 7. Daily Build Log

**Location:** `DailyBuildLog.md`

The Daily Build Log documents the development process for Island Breakout.

Each development session records:

- Tutorial part or feature being developed
- Goal for the session
- Work completed
- System tested
- Result
- Problem found
- Fix attempted
- Next checkpoint
- Evidence screenshot
- Git commit message
- Git commit ID

The build log also documents the development of the custom Island Breakout artwork and the bricks, score, and lives expansion.

Because `DailyBuildLog.md` is a Markdown file, it can normally be viewed directly through GitHub.

---

## 8. Evidence and Screenshots

**Location:** `Evidence/`

The Evidence folder contains working checkpoints and screenshots showing the development and testing of Island Breakout.

Evidence includes:

- `IslandBreakout_GameLogicFlowchart.png`
- `Part1-Island-Background-Working.png`
- `Part2_GameLoop_Working.png`
- `Part3_CustomTropicalPaddle_Working.png`
- `Part3_PaddleMovement_Working.png`
- `Part4_Ball_Working.png`
- `Part4_CustomTropicalBall_Working.png`
- `Part5_CollisionHitTest_Working.png`
- `Part6_WallCollision_Working.png`
- `Session9_BricksScoreLives_Working.png`

The PNG evidence files can be viewed directly through GitHub.

---

## 9. Meaningful Git Commit History

The Git repository contains commits documenting meaningful stages of development instead of submitting the entire project as a single final commit.

The commit history includes work related to:

- Tutorial progression
- Island background customization
- Paddle customization
- Ball customization
- Paddle movement
- Ball movement
- Collision hit testing
- Wall collision
- Bricks
- Score
- Lives
- Game Development Document
- Daily Build Log updates
- Project documentation

This commit history provides additional evidence of the project's development over time.

---

## 10. Discord Progress Evidence

**Location:** Mission Receipt Discord Proof file in the repository root.

Discord progress evidence documents project progress and required communication/checkpoints for the CS120 Final Project.

Additional development screenshots are stored in:

`Evidence/`

**File access:** If GitHub displays **Raw** or **View raw** instead of a document preview, select that option to open or download the complete evidence file.

---

## 11. Final Mission Receipt

**Location:** `FINAL_MISSION_RECEIPT.pdf`

The Final Mission Receipt contains the contracted requirements and point values for the CS120 Final Project Breakout pathway.

**File access:** If the PDF does not preview directly in GitHub, select **Raw** or **View raw** to open or download the complete file.

---

# Project Structure

```text
CS120_Final_Breakout/
|
|-- Assets/
|   `-- Images/
|       `-- Custom Island Breakout image assets
|
|-- Breakout/
|   `-- Visual Basic .NET / WPF game project and source code
|
|-- Evidence/
|   |-- IslandBreakout_GameLogicFlowchart.png
|   |-- Part1-Island-Background-Working.png
|   |-- Part2_GameLoop_Working.png
|   |-- Part3_CustomTropicalPaddle_Working.png
|   |-- Part3_PaddleMovement_Working.png
|   |-- Part4_Ball_Working.png
|   |-- Part4_CustomTropicalBall_Working.png
|   |-- Part5_CollisionHitTest_Working.png
|   |-- Part6_WallCollision_Working.png
|   `-- Session9_BricksScoreLives_Working.png
|
|-- DailyBuildLog.md
|-- FINAL_MISSION_RECEIPT.pdf
|-- Game Development Document
|-- Mission Receipt Discord Proof
`-- README.md
```

---

# Technologies Used

- Visual Basic .NET
- WPF
- XAML
- Visual Studio
- Git
- GitHub

---

# Island Breakout Theme

Island Breakout transforms the standard Breakout tutorial into a tropical-themed game while preserving the required programming concepts and gameplay systems.

The tropical background, paddle, and ball create a personalized visual design, while the added bricks, score, lives, and game-over systems expand the project into a more complete Breakout experience.

---

# Final Project Status

- Working Breakout game: **Complete**
- Breakout Tutorial Parts 1-6: **Complete**
- Tropical customization: **Complete**
- Brick system: **Complete**
- Score system: **Complete**
- Lives system: **Complete**
- Game Development Document: **Complete**
- Game Logic Flowchart: **Complete**
- Daily Build Log: **Complete**
- Evidence screenshots: **Complete**
- Git repository: **Active and accessible**
