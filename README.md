# CreatePlatformerDirections

Doodle Jump

No autojump, jump must be a player controlled movement
 Camera must move up with the player while(if) the player is above a certain height
 A death Object Moves with the camera and it removes health from player if contacted
      -- Maybe "lava" and it removes health
 Coins for score - generated pseudo-randomly 
 Level must go up forever(or maybe just a long time)
 Some stationary platformers, some moving, player must be able to pass through if moving up
 Sound when jumping or sound when landing or both.


__________________________________________________________________
Process
1. Create new 2D core project
2. Create grass platform and lava in paint , save in assets folder
   - drag them into the scene, move and resize
3. Add 2D sprite Circle to the Scene and change color, set tag = Player, add Circle Collider, check IS TRIGGER
                                                     , add Rigid Body 2D, Gravity Scale = 1, Constraints->FreezeRotation Z
4. Write BallMovement.cs script, and from inspector, apply the ball to Rb pulic variable
5. Write a PlatformOnOff script, make sure to apply the ball to the public variable in the inspector
6. Duplicate and alter the Platform into different rows.
7. Write CameraMove script, make sure to apply the ball to the public variable in the inspector
8. Copy CameraMove to LavaMove script and adjust it slightly, apply ball and main camera to it
9. Make MovingPlatform script and apply it to one type of row
10. Make InGame Object and put all objects under it. 
11. Make InGame Script that instantiates rows. Make sure each platform piece in the original row has y position 0
12. Drag all types or row objects into InGame script in the inspector
13. CollectCoin script. In game must have public ScorePoint function.
14. Apply InGame object to this script, and the make some coins for first 4 rows. 
   - In Ingame, Instantiate a coin every time with row
   - Make sure the instantiated coin is an extra off screen coin that cannot be destroyed
15. Ball must be set to IsTrigger. This makes it fall through all platforms. Add another Circle COllider componentTo Fix this
16. Add LoseHealth to InGame, and make lava a collider, and ontriggerenter, set public ball velotity = 12 and call lose health

Canvas
1. Add UI->button. Go to game view not scene view and move button Not Canvas to corner. Edit text to say pause
   Add public functions Pause and Resume into InGame
   Duplicate and call rename text to Resume. 
2. On click option, add InGame and InGame function Pause, 
   Add 2 more On Clicks to toggle GameObjects Canvas 1 and Canvas 2 Set active to true or false
3. Add another canvas ScoreHealth, and put 2 LegacyText game objects under it. I cant figure out TMP text objects
4. move New Text to the correct location,
5. Write Score and Heath Scripts (assign InGame and Score and Health Game objects to public variables)

6. Make a You Win Canvas. 
7. Make a You Lose Canvas.

8. Simply add ifs to score and health functions in InGame to pause game and SetActive(true) the canvases you just made

Add sounds
1. Create GameObject with component AudioSource for each sound. Drag the sound file into AudioClip attribute from inspector
2. For each script that must call a sound, "public AudioSource soundName", and in code call soundName.Play()
   - Remember to drag in the Audio Source GameObject to the scripts public variable from the inspector
