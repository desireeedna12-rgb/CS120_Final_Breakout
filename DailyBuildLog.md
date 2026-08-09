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
- Commit ID: Pending

Copy the session section for each work period.
