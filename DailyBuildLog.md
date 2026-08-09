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

---
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
- Start time: [your actual start time]
- Stop time: [your actual stop time]
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
- Commit ID: Pending
Copy the session section for each work period.
