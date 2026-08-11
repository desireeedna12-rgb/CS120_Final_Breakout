# CS120 Final Pipeline: Daily Build Log

Update this file during every work session. Commit the update with the project changes from that session.

## Session [1]

- Date: August 7.2026
- Start time: 9pm
- Stop time: 11pm
- Selected pathway: Breakout
- Goal for this session: Begin Tutorial Part 1, set up the Breakout WPF project, and prepare the Island Breakout background.

### Work Completed

- Began Breakout Tutorial Part 1.
- Created/opened the Breakout WPF project in Visual Studio.
- Set up MainWindow and the MainCanvas.
- Followed the tutorial to create the background.
- Copied and pasted the background element used in the tutorial.
- Changed the background Brush type to Image.
- Selected the custom Island Breakout background image.
- Continued developing the custom tropical Island Breakout theme.

### Working Checkpoint

The Breakout WPF project opens in Visual Studio and MainWindow displays correctly. The MainCanvas has been created, and the background was changed from a standard Brush to an Image Brush so the custom Island Breakout background can be displayed.

### Problem and Evidence

- Error or problem: XAML Designer displayed an Invalid Markup error while setting up the Canvas.
- File and line, scene, object, or setting involved: MainWindow.xaml / MainCanvas.
- Error message or visible behavior: "Invalid Markup - Check the Error List for more information."
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 1 and AI assistant.

### Fix or Next Test

- Change made: Corrected the MainCanvas setup and changed the background Brush to an Image Brush.
- Result: The project is ready to display the custom Island Breakout background.
- Next test: Run the project and confirm that IslandBackground.png displays correctly and fills the game area.

### Evidence Saved

- Screenshot filename: Part1_IslandBackground_Working.png
- Document updated:  DailyBuildLog.md
- Commit message: Complete Tutorial Part 1 and add Island Breakout background
- Commit ID: 0408df8

## Session [2]

- Date: August 8, 2026
- Start time: 7:07 pm
- Stop time: 7:26pm
- Selected pathway: Breakout
- Goal for this session: Complete Tutorial Part 2 and create the main game loop for Island Breakout.

### Work Completed

- Completed Tutorial Part 2 - The Game Loop.
- Added the DispatcherTimer for the game loop.
- Set the game loop interval.
- Connected the timer Tick event to the UpdateLoop procedure.
- Started the game loop when the game initializes.
- Created the UpdateLoop procedure.
- Ran and tested Island Breakout successfully.

### Working Checkpoint

Island Breakout opens and runs successfully with the custom tropical background. The DispatcherTimer starts when the game loads and continuously calls the UpdateLoop procedure without preventing the game window from running.

### Problem and Evidence

- Error or problem: InitializeComponent() was initially not recognized.
- File and line, scene, object, or setting involved: MainWindow.xaml and MainWindow.xaml.vb.
- Error message or visible behavior: BC30451: 'InitializeComponent' is not declared. It may be inaccessible due to its protection level.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 2 and AI assistant.

### Fix or Next Test

- Change made: Corrected the class connection between MainWindow.xaml and its VB code-behind so InitializeComponent() was recognized.
- Result: The error disappeared, the project runs successfully, and the game loop works.
- Next test: Begin Tutorial Part 3 and implement the player's paddle.

### Evidence Saved

- Screenshot filename: Part2_GameLoop_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Complete Tutorial Part 2 and implement game loop
- Commit ID: d8dbecf

## Session [3]

- Date: August 8, 2026
- Start time: 7:30pm
- Stop time: 8:23pm
- Selected pathway: Breakout
- Goal for this session: Complete Tutorial Part 3 and implement paddle creation and movement.

### Work Completed

- Completed Tutorial Part 3 - The Paddle.
- Created the paddle as a Rectangle.
- Set the paddle size, stroke, fill, and starting position.
- Added a TranslateTransform for paddle movement.
- Added paddle speed and position variables.
- Added keyboard controls for A and D.
- Added KeyDown and KeyUp handling.
- Connected MovePaddle() to the game loop.
- Tested the paddle movement successfully.

### Working Checkpoint

Island Breakout runs successfully with the tropical background. The paddle appears near the bottom of the game window, moves left with A, moves right with D, and stops when the key is released.

### Problem and Evidence

- Error or problem: Paddle keyboard input did not work at first.
- File and line, scene, object, or setting involved: MainWindow.xaml and MainWindow.xaml.vb.
- Error message or visible behavior: The paddle displayed correctly but did not respond to A or D.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 3 and AI assistant.

### Fix or Next Test

- Change made: Connected the KeyDown and KeyUp events, added MovePaddle() to the UpdateLoop, and verified the movement Boolean variables.
- Result: The paddle now moves left and right and stops when the key is released.
- Next test: Begin Tutorial Part 4 and create the ball.

### Evidence Saved

- Screenshot filename: Part3_PaddleMovement_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Complete Tutorial Part 3 and implement paddle movement
- Commit ID: 33cf376

## Session [4]

- Date: August 8, 2026
- Start time: 8:30 pm
- Stop time: 8:50 pm
- Selected pathway: Breakout
- Goal for this session: Replace the temporary tutorial paddle appearance with the custom Island Breakout tropical paddle artwork.

### Work Completed

- Kept the existing paddle movement and collision rectangle from Tutorial Part 3.
- Added the custom tropical paddle image to the project.
- Changed the paddle appearance from a solid color fill to an image-based fill.
- Preserved the existing paddle size, movement, position, and game-loop logic.
- Tested the customized paddle during gameplay.

### Working Checkpoint

Island Breakout runs successfully with the tropical background and custom paddle artwork. The tropical paddle moves left with A, moves right with D, and stops when the key is released while keeping the same movement logic from Tutorial Part 3.

### Problem and Evidence

- Error or problem: The original tutorial paddle used a solid Rectangle fill instead of the planned tropical artwork.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / DrawPaddle().
- Error message or visible behavior: The paddle worked correctly but did not match the Island Breakout visual design.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 3, Island Breakout sprite sheet, and AI assistant.

### Fix or Next Test

- Change made: Replaced the temporary paddle fill with the custom tropical paddle image while keeping the same Rectangle object and movement logic.
- Result: The paddle now matches the Island Breakout theme and still moves correctly.
- Next test: Begin Tutorial Part 4 and create the game ball.

### Evidence Saved

- Screenshot filename: Part3_CustomTropicalPaddle_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Customize paddle with Island Breakout artwork
- Commit ID: 2e08e20

## Session 5

- Date: August 8, 2026
- Start time: 10:20 pm 
- Stop time: 10:30 pm
- Selected pathway: Breakout
- Goal for this session: Complete Tutorial Part 4 and implement the game ball.

### Work Completed

- Completed Tutorial Part 4 - The Ball.
- Created the BALL object.
- Added the ball size, fill, stroke, and position settings.
- Added BALL_TRANSLATE for positioning and movement.
- Created the DrawBall() procedure.
- Added the ball to MainCanvas.
- Added DrawBall() to the game startup.
- Tested the ball in Island Breakout.

### Working Checkpoint

Island Breakout opens successfully with the tropical background and custom tropical paddle. The ball displays correctly in the game window, and the paddle movement from Part 3 continues to work.

### Problem and Evidence

- Error or problem: No major problem encountered during Part 4.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / DrawBall().
- Error message or visible behavior: No error; the ball displayed successfully.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 4 and AI assistant.

### Fix or Next Test

- Change made: Added the ball object, DrawBall() procedure, positioning, and transform settings from the tutorial.
- Result: The ball displays successfully in Island Breakout.
- Next test: Customize the tutorial ball with Island Breakout artwork.

### Evidence Saved

- Screenshot filename: Part4_Ball_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Complete Tutorial Part 4 and implement game ball
- Commit ID: 4f7ca47

## Session [6]

- Date: August 8, 2026
- Start time: 10:36 pm
- Stop time: 10:45 pm
- Selected pathway: Breakout
- Goal for this session: Replace the temporary tutorial ball appearance with the custom Island Breakout tropical ball artwork.

### Work Completed

- Kept the existing ball object and setup from Tutorial Part 4.
- Added the custom tropical ball image to the project.
- Changed the ball appearance from a solid color fill to an image-based fill.
- Preserved the existing ball size, position, and game logic from Tutorial Part 4.
- Tested the customized ball during gameplay.

### Working Checkpoint

Island Breakout runs successfully with the tropical background, custom paddle artwork, and custom tropical ball. The Island Ball appears correctly in the game window while keeping the same ball setup from Tutorial Part 4.

### Problem and Evidence

- Error or problem: The original tutorial ball used a solid color fill instead of the planned tropical artwork.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / DrawBall().
- Error message or visible behavior: The ball worked correctly but did not match the Island Breakout visual design.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 4, custom Island Breakout artwork, and AI assistant.

### Fix or Next Test

- Change made: Replaced the temporary ball fill with the custom tropical ball image while keeping the same ball object and existing Tutorial Part 4 logic.
- Result: The ball now matches the Island Breakout theme and displays correctly in the game window.
- Next test: Begin Tutorial Part 5 and test collision detection between the ball, paddle, and game objects.

### Evidence Saved

- Screenshot filename: Part4_CustomTropicalBall_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Customize ball with Island Breakout artwork
- Commit ID: 29d86f0
## Session [7]

- Date: August 8, 2026
- Start time: 11:07 pm
- Stop time: 11:39 pm
- Selected pathway: Breakout
- Goal for this session: Complete Tutorial Part 5 and implement collision hit testing for the ball and paddle.

### Work Completed

- Completed Tutorial Part 5 - Collision Hit Test.
- Added collision checking for the ball.
- Used the ball position to perform a hit test on MainCanvas.
- Added the hit test callback function.
- Added paddle collision detection using the existing Rectangle object.
- Reversed the ball's vertical direction when it hits the paddle.
- Added directional bounce logic based on where the ball hits the paddle.
- Tested the collision behavior during gameplay.

### Working Checkpoint

Island Breakout runs successfully with the tropical background, custom tropical paddle, and custom tropical ball. The ball can detect the paddle and reacts to the collision by changing direction while keeping the existing custom artwork and movement systems working.

### Problem and Evidence

- Error or problem: No major error encountered while completing the collision hit test.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / Check_Collision() and MyHitTestResult().
- Error message or visible behavior: No error; the paddle collision test worked during gameplay.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 5 and AI assistant.

### Fix or Next Test

- Change made: Added the ball hit test, collision callback, paddle detection, and directional bounce logic from Tutorial Part 5.
- Result: The ball now detects and reacts to paddle collisions successfully.
- Next test: Begin Tutorial Part 6 and implement wall collision.

### Evidence Saved

- Screenshot filename: Part5_CollisionHitTest_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Complete Tutorial Part 5 and implement collision hit test
- Commit ID:  8a3993b

## Session [8]

- Date: August 8, 2026
- Start time: 11:07 pm
- Stop time: 11:35 pm
- Selected pathway: Breakout
- Goal for this session: Complete Tutorial Part 6 and implement wall collision for the ball.

### Work Completed

- Completed Tutorial Part 6 - Wall Collision.
- Added collision detection for the game boundaries.
- Added logic to detect when the ball reaches the left and right walls.
- Reversed the ball's horizontal direction when it hits a side wall.
- Added logic to detect when the ball reaches the top wall.
- Reversed the ball's vertical direction when it hits the top wall.
- Kept the existing paddle collision and directional bounce logic from Part 5.
- Tested the ball movement to make sure it correctly bounces off the walls.
- Confirmed that the custom tropical ball, paddle, and background continued working correctly.

### Working Checkpoint

Island Breakout runs successfully with wall collision implemented. The custom tropical ball now bounces off the left, right, and top boundaries of the game while continuing to interact correctly with the tropical paddle. The existing custom artwork, ball movement, and paddle collision systems remain functional.

### Problem and Evidence

- Error or problem: No major error encountered while implementing wall collision.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / ball movement and wall collision logic.
- Error message or visible behavior: No error; the ball successfully changed direction when reaching the game boundaries.
- Resource, classmate, instructor, AI assistant, or documentation used: Breakout Tutorial Part 6 and AI assistant.

### Fix or Next Test

- Change made: Added boundary checks and direction changes for the ball when it reaches the left, right, and top walls.
- Result: The ball now successfully bounces off the game boundaries while maintaining the existing paddle collision behavior.
- Next test: Continue to the next Breakout tutorial section and add the next required gameplay feature.

### Evidence Saved

- Screenshot filename: Part6_WallCollision_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Complete Tutorial Part 6 and implement wall collision
- Commit ID:b498fe9
## Session [9]

- Date: August 10, 2026
- Start time: [ENTER START TIME]
- Stop time: [LEAVE BLANK UNTIL FINISHED]
- Selected pathway: Breakout
- Goal for this session: Expand Island Breakout by adding brick gameplay, score tracking, and lives.

### Work Completed

- Added a brick system to Island Breakout.
- Created multiple brick objects and displayed them near the top of the game.
- Added brick collision detection using the existing hit-test system.
- Fixed the right-wall collision condition so the ball moved correctly across the game area.
- Updated the hit-test callback so only one brick is removed per collision.
- Tested the game and confirmed that individual bricks disappear when hit by the ball.
- Began implementing a score system for brick collisions.

### Working Checkpoint

Island Breakout runs successfully with the existing tropical background, custom paddle, custom ball, wall collision, and paddle collision. Bricks now appear in the game and can be removed individually when the ball hits them.

### Problem and Evidence

- Error or problem: After the brick system was first added, the ball became stuck near the corner and the collision system initially removed multiple bricks during one hit test.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / Check_Collision(), MyHitTestResult(), and wall collision logic.
- Error message or visible behavior: No compiler error. The visible behavior was incorrect ball movement and multiple bricks disappearing during collision testing.
- Resource, classmate, instructor, AI assistant, or documentation used: Existing Breakout tutorial code and AI assistant.

### Fix or Next Test

- Change made: Corrected the right-wall collision comparison from <= WALL_RIGHT to >= WALL_RIGHT and added HitTestResultBehavior.Stop after a brick collision.
- Result: The ball moves normally again and bricks are removed one at a time when hit.
- Next test: Complete and test the score system, then add lives and game-over behavior.

### Evidence Saved

- Screenshot filename: Session9_BricksScoreLives_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Add bricks score and lives to Island Breakout
- Commit ID: a296b53
## Session [10]

- Date: August 10, 2026
- Start time: 8:20pm
- Stop time: 8:53 pm
- Selected pathway: Breakout
- Goal for this session: Customize the Island Breakout bricks and game interface to better match the tropical theme.

### Work Completed

- Expanded the brick layout from three rows to six rows.
- Added different colors for each brick row using tropical-inspired colors.
- Used pink, orange, yellow, green, blue, and purple brick rows.
- Added a multi-hit brick system using the brick Tag property.
- Added brick opacity changes so bricks fade after repeated hits.
- Configured bricks to fade three times before being completely removed.
- Kept score tracking so points are added when a brick is fully destroyed.
- Customized the Score display with a tropical-style bordered panel.
- Customized the Lives display with a matching tropical-style panel.
- Replaced the numeric lives display with heart symbols.
- Tested the updated tropical brick system and game interface during gameplay.
- Confirmed that the game still runs with the tropical paddle, ball, background, bricks, score, and lives systems.

### Working Checkpoint

Island Breakout runs successfully with an expanded tropical visual design. The game now contains six rows of differently colored bricks, and each brick fades after repeated hits before disappearing completely. The Score and Lives displays were also customized to better match the tropical theme, with lives represented using heart symbols.

### Problem and Evidence

- Error or problem: The game became somewhat glitchy while testing collision changes and the larger brick system.
- File and line, scene, object, or setting involved: MainWindow.xaml.vb / DrawBricks(), HitBrick(), Check_Collision(), and collision handling.
- Error message or visible behavior: No major compiler error was present. Some gameplay movement appeared slightly laggy or glitchy during testing, but the game continued to run and the main systems remained functional.
- Resource, classmate, instructor, AI assistant, or documentation used: Existing Island Breakout code, Game Development Document, and AI assistant.

### Fix or Next Test

- Change made: Added colored brick rows, multi-hit fading behavior, tropical Score and Lives panels, and heart-based lives display. Collision handling was also tested and adjusted while keeping the game functional.
- Result: The tropical customization works during gameplay, including the six colored brick rows, brick fading, score tracking, and lives display.
- Next test: Complete the remaining final project documentation and submission requirements without making unnecessary gameplay changes.

### Evidence Saved

- Screenshot filename: Session10_TropicalBricks_UI_Working.png
- Document updated: DailyBuildLog.md
- Commit message: Customize bricks and tropical game UI
- Commit ID: ead17fa

Copy the session section for each work period.
