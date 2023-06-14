[Reference1](https://github.com/M2neko/Due_Tonight) , [Reference2](https://github.com/dr-jam/GameplayProgramming/blob/master/GameProject.md)

# Game Basic Information #

## Summary ##

"Super Fox" is an exciting 2D platformer game, inspired by classic titles like Super Mario. Set in a vibrant detailed world, players control a fox character, guiding it through various challenging landscapes filled with obstacles.

As the fox, players are tasked with going through these levels by running and jumping over obstacles, dodging or defeating enemies, and leaping over voids. The fox has the ability to defeat opponents by jumping over them. However, failure to execute this correctly results in the fox's demise, causing the level to restart from the beginning. Players need to time their movements precisely to ensure survival and progress.

## Gameplay Explanation ##

Core game mechanics: The basic action includes running, jumping.

Goals: Player needs to run and collect cherries and dodge opponents to get to the next level untill the game ends.

## Controls:
  ### Keyboard:
    '⬅️' '➡️' 'A' 'D' for movement.
    '⬆️' 'W' for jump.




**If you did work that should be factored in to your grade that does not fit easily into the proscribed roles, add it here! Please include links to resources and descriptions of game-related material that does not fit into roles here.**

# Main Roles #
  Input                 : Jaspreet Singh <br>
  Movement/Physics      : Agam Bhullar <br>
  Animation and Visuals : Olivia Qian <br>
  User Interface        : Alan Chuang <br>
  Game Logic            : Ameya Naik <br>
## Producer
The primary responsibilities included managing project timelines, coordinating team tasks, and ensuring smooth communication among team members.A discord server was setup to have communication between the team and all members were reached out to be ontime and on schedule. Also a github repository was setup with a seperate branch for everyone, however producers worked together in the main branch.

[Contributors: Jaspreet Singh and Agam Bhullar]

**Describe the steps you took in your role as producer. Typical items include group scheduling mechanism, links to meeting notes, descriptions of team logistics problems with their resolution, project organization tools (e.g., timelines, depedency/task tracking, Gantt charts, etc.), and repository management methodology.**

## User Interface
The User Interface (UI) in Super Fox is designed to be minimalistic and intuitive, allowing players to focus on the gameplay rather than the background and other fuff. The UI for the purposes of this game only consists of the in-game UI. The UI consists of a consumables counter to keep a track of the fruits consumed in the level and a caution to collect all before advancing to next level.
All these elements are designed with simplicity and ease of use in mind, ensuring players can navigate the game easily and focus on the gameplay. The UI design was designed with the overall theme of the game in mind, which is to minimize the learning curve required in the game, so players can jump straight into the gameplay, without having to learn complicated controls or menu navigation.
[Contributors:Agam Bhullar, Jaspreet Singh, and Alan Chuang]

## Movement/Physics

The Super Fox game, in essence, is a physics-based platformer game, and as such, we had to ensure the movement and physics within the game felt realistic and satisfying. For the running movement, we used a simple velocity function that updates the Fox's x position based on player input and a fixed speed variable(moveSpeed). This method provided a smooth and responsive movement. 
For jumping, we used the built-in physics engine of the game development platform. We assigned a rigidbody component to the Fox character, which enabled us to apply a force to the character when the player presses the up key. This force propels the Fox upwards, and then gravity pulls it back down, creating a natural-looking jump arc. The jump was adjusted based on a fixed variable jumforce which was tweaked to make the move feel natural.
We also used waypoints to give directions to the floating platform and trap items, which allows traps/enemies to move in a certain direction. We used our jump tactic to kill enemies. By using the jump tactic, the player can jump on the enemies head and eliminate them.  

[Contributors: Agam Bhullar]

## Animation and Visuals

**List your assets including their sources, and licenses.**

[The super fox](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349#description) - From Unity Asset Store;

[Enemy Bear](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349#description) - From Unity Asset Store;

[Other enemies](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349#description) - From Unity Asset Store;

[pixel tile 1](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349#description) - From Unity Asset Store;

[pixel tile 2](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360z) - From Unity Asset Store;

[Background 1](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349#description) - From Unity Asset Store;

[Background 2](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360z) - From Unity Asset Store;

### Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.

After the first discussion, we decided on the story behind the game. We set the story in the forest. The story outlines that the protagonist living in the forest goes out to collect food, encounters and overcomes many difficulties, and finally returns home.
With a clear story background, we agreed to make a 2D platformer adventure game. So when designing the main character, we wanted it to be brave and smart. Still, at the same time, we wanted to make sure we created a spirited and lovable image that would support the narrative while appealing as much as possible to our target audience, college students. Among the various animals that inhabit the forest, we finally settled on the fox as our main character. Then, we used Procreate to create our [initial vision of the game](https://github.com/jassgone/ECS-189L_finalProject/blob/main/initial%20design.png).

We brainstormed about the difficulties that the main character would have to overcome in the story. The first thing we determined was that we could use the natural environment of the forest to create levels, such as cliffs, mountains, etc. We can also use the fox's greatest enemy in the forest - the bear as the "ultimate boss" he needs to defeat and other animals as enemies. Then, we thought about the possible artificial traps in the forest and decided to use spikes, rolling gears, etc., as obstacles. 

After determining the image needed, we started looking for suitable assets. We found this set of assets in the Unity asset store that fit perfectly with our design inspiration. It contains the character fox, the important elements of the forest - the trees, the rocks, and the animation of a bear. It also contains animations corresponding to the movements we needed to add to the main character, the fox - running, jumping, falling, etc. Another reason why we chose this set of assets is that it is in 2D pixel-art style, which fits our need for our game to be able to follow the feel of retro platformers (like Mario).

To enhance the game feel with animation, for example, we added animations when the player collects fruits in each level, making collecting movement more attractive and thus achieving the effect of increasing the player's satisfaction and feeling of achievement. 

We tried to add more things to the animation and visuals to make our game more intriguing and juicy, but some effects were not possible because of time constraints. For example, adding disappearing animations for collected fruits, adding animations for enemy deaths, etc.

[Contributors: Olivia Qian, Agam Bhullar, and Jaspreet Singh]

## Input

The Super Fox game is a platform game, and therefore, the input handling is critical to the game experience. For basic movements such as run and jump, we rely on simple keystrokes. For instance, the "right" and "left" arrow keys are used to move the Fox character in the respective directions, while the "up" key is used for the jump action. The sensitivity and responsiveness of these controls have been carefully calibrated to ensure an optimal gaming experience.

The Fox character can also interact with the game environment, such as collecting cherries and killing opponents by jumping over them. This required creating more sophisticated input handling methods. For example, we implemented a collision detection system(box collider 2D) to check if the Fox has landed on an opponent's head or touched a cherry. If a collision is detected, the relevant game logic is executed.

[Contributors: Jaspreet Singh]

## Game Logic

There were two main game logic areas. They were the stomp mechanic and the level completion system.

1. The stomp mechanic: If the player jumps on an enemies head, this process leads to the playing of a specialized audio queue and a jump. This was implemented using the pubsub pattern in [StompManager.cs](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/StompManager.cs#L1). The player is automatically subscribed to this class in its `Start` function, where it provides a delegate to the `Jump` action. In the `EnemyDeath.cs` classes, any time an enemy death is triggered with the `OnTriggerEnter2D` function when the player's foot contacts the enemy's head, we also publish to the `StompManager` class instructing the jump and the stomp sound effect.

2. The level completion system. For this, the player needs to collect all the fruits and defeat the boss (the bear) in order to progress to the next level. This was implemented using a boolean value in [Finish.cs](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/Finish.cs#L12) called `levelCompleted`. Essentially, when all the criteria is met, the goal is that the value of this boolean changes to true allowing progress to the next level. If the criteria is not met, we play an error sound effect and desplay a message instructing the player on what needs to be done. How do we check for these criteria though, without doing it every frame? Once again, we used the pubsub pattern in [FinishPublisher.cs](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/FinishPublisher.cs#L1). This exposed a function inside `Finish.cs` which checks the state of the level, and changes the boolean accordingly. Both the `ItemCollector.cs` and `EnemyDeath.cs` become publishers, and can pass messages to the `Finish.cs` to tell it that it should re-check the state of the level, and possibly enable the finish line.

[Contributors: Ameya Naik]

# Sub-Roles
  Game Feel             : Jaspreet Singh <br>
  Gameplay Testing      : Agam Bhullar <br>
  Press Kit and Trailer : Olivia Qian <br>
  Narrative Design      : Alan Chuang <br>
  Audio                 : Ameya Naik <br>

## Cross-Platform
For the release of Super Fox, we targeted two main platforms: Windows PC and MacOS

Windows PC:
Targeting the Windows platform was the most straightforward process as our game development environment (Unity) natively supports building games for Windows. During the development process, we encountered an issue related to varying screen resolutions and sizes on different Windows devices. We managed to overcome this by implementing a dynamic resolution system that adjusts the game view based on the player's device resolution.

MacOS:
Unity also supports MacOS, but we had to ensure the game's performance was optimized for this platform. The MacOS release was surprisingly seamless, as we found fewer hardware compatibility issues than anticipated. Also a major fact that most of the game was built using a MacOS, running on this platform was not a challenge that had to be faced.


## Audio

**List your assets including their sources and licenses.**

For audio, we used a combination of sfx from freesound.org and music from the Unity Asset Store. All the tracks and their liscences can be found in the [README.md](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/World2/Music%20tracks/README.md) located in the `Music tracks` folder.

For the scripts [SoundManager.cs](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/SoundManager.cs#L1) and [SoundClip.cs](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/SoundClip.cs#L1), these were essentially used almost as is from our four excercises. These allowed us an easy way to play any audio at any time from any script.

[Contributors: Ameya Naik]

**Describe the implementation of your audio system.**

The implementation code wise of the audio system was generally fairly simple. First, we used the five tracks from the assets store and paired each one with a scene, two of them going to menu music and the other three going to level music. The way we were able to have the sound manager persist through different scenes was by a [DontDestroyOnLoad](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/StartMenu.cs#LL9C4-L9C4). This ensures that when we load into the beginning of the game, the sound manager is always loaded and stays loaded through all the levels. In order to change the music, the code which switches tracks is executed before a level switch [here](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/StartMenu.cs#L15) and [here](https://github.com/jassgone/ECS-189L_finalProject/blob/7d0df97dd4df57461b3bb5cd255cbd796f97e183/Super%20Fox/Assets/Scripts/Finish.cs#LL52C1-L52C1). All sfx was also played when relevant, using the `PlaySoundEffect` method.

[Contributors: Ameya Naik]

**Document the sound style.** 

The sound style for music is that of a retro-ish video game. The menu music and level 1 have fairly neutral sounding music which is upbeat. Levels 2 and 3 have slightly more suspenseful music to go with the increased difficulty. For sfx, care was taken to select tracks which seemed retro, but were generally clean and not overbearing.

[Contributors: Ameya Naik]

## Gameplay Testing

Gameplay testing is an essential part of game development. It allows us to find and fix bugs, balance game mechanics, and improve the overall player experience. Throughout the development of Super Fox, we conducted multiple rounds of gameplay testing. We tested the functionality of all features, including running, jumping, collecting cherries, defeating opponents, and level progression.
From the testing, we made several important findings and improvements. For instance, we found that some jumps were too difficult to make, leading to player frustration. We adjusted these parts of the levels to make them more balanced. We also realized that some opponents were placed in spots that made them nearly impossible to defeat without taking damage. We adjusted the positions of these opponents to make the game fairer. Also some of our friends were used to remove bias and make some updates.

[Contributors: Agam Bhullar and Jaspreet Singh]

## Narrative Design

The narrative in Super Fox is embedded into the gameplay experience. While it's a platformer game, we've created a simple narrative that helps to immerse players into the game world. The Fox character is on a journey to gather all the cherries in the advanced forest(worlds) while avoiding or defeating obstacles. Each level represents a different part of the said forest, and the increased difficulty in the Fox's journey getting more challenging as it goes deeper into the forest, analagous to getting deeper or advancing in life.

To incorporate the narrative into the game, we used a mix of visual storytelling and gameplay systems. The visual assets were chosen to reflect the narrative setting, with each level having a unique look that corresponds to indicate a different mess you get into. The gameplay systems, like collecting cherries and defeating opponents, are tied into the narrative, representing the challenges the Fox faces on its journey and saying there always is a way(wink wink).

[Contributors:Agam Bhullar, Jaspreet Singh, and Alan Chuang]

## Press Kit and Trailer

**Include links to your presskit materials and trailer.**
[Trailer](https://youtu.be/mmAPyFJ5Dew) -- Published on Youtube; 

[Music](https://www.youtube.com/watch?v=mRN_T6JkH-c&list=PPSV) in the trailer;

[Press kit](https://tekuteki.itch.io/super-fox) -- published on itch.io;

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**
I made this trailer using a video recording of the game. In the trailer, I chose videos of different difficulty levels in the game, trying to pique the player's interest by contrasting the difficulty before and after in the levels. These levels are also the parts of the game that we put the most effort into, such as the movement of gear obstacles, the way the ultimate enemy is defeated, etc.  

The press kit is published on itch.io. I chose itch.io because of its reputation in the game community and also because of its ease of use. In the press kit, I included the link to the trailer, the link to our github page, a short description of the game, the release date and the price. I believe that to keep the information as short and clear as possible in the press kit it important because a press kit is supposed to provide information to the players. In the press kit, I chose screenshots of the most engaging and challenging parts of each level, hoping to stimulate the viewer's interest in this way as much as possible along with the information provided.

[Contributior: Olivia Qian]



## Game Feel

The goal of the game feel sub-role is to make sure the player's interactions with the game are satisfying and impactful. To this end, we have introduced a number of features. When the Fox collects a cherry, we've created a simple animation to make the collection process feel more rewarding. Similarly, when the Fox kills an opponent by jumping over them, we've added a visual effect to emphasize the action.We also spent a considerable amount of time perfecting the physics of the Fox's jump. Getting the speed and landing feel right was an iterative process that involved numerous rounds of testing and adjusting. The aim was to make the jump feel responsive and satisfying for players, which is a critical aspect of game feel as discussed in our course.

[Contributors: Jaspreet Singh and Agam Bhullar]
