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

[Contributors: Agam Bhullar]

## Animation and Visuals


## Input

The Super Fox game is a platform game, and therefore, the input handling is critical to the game experience. For basic movements such as run and jump, we rely on simple keystrokes. For instance, the "right" and "left" arrow keys are used to move the Fox character in the respective directions, while the "up" key is used for the jump action. The sensitivity and responsiveness of these controls have been carefully calibrated to ensure an optimal gaming experience.

The Fox character can also interact with the game environment, such as collecting cherries and killing opponents by jumping over them. This required creating more sophisticated input handling methods. For example, we implemented a collision detection system(box collider 2D) to check if the Fox has landed on an opponent's head or touched a cherry. If a collision is detected, the relevant game logic is executed.

[Contributors: Jaspreet Singh]

## Game Logic


# Sub-Roles
  Game Feel             : Jaspreet Singh <br>
  Gameplay Testing      : Agam Bhullar <br>
  Press Kit and Trailer : Olivia Qian <br>
  Narrative Design      : Alan Chuang <br>
  Audio                 : Ameya Naik <br>

## Cross-Platform
For the release of Super Fox, we targeted three main platforms: Windows PC and MacOS

Windows PC:
Targeting the Windows platform was the most straightforward process as our game development environment (Unity) natively supports building games for Windows. During the development process, we encountered an issue related to varying screen resolutions and sizes on different Windows devices. We managed to overcome this by implementing a dynamic resolution system that adjusts the game view based on the player's device resolution.

MacOS:
Unity also supports MacOS, but we had to ensure the game's performance was optimized for this platform. The MacOS release was surprisingly seamless, as we found fewer hardware compatibility issues than anticipated. Also a major fact that most of the game was built using a MacOS, running on this platform was not a challenge that had to be faced.


## Audio

**List your assets including their sources and licenses.**

**Describe the implementation of your audio system.**

**Document the sound style.** 

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

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**



## Game Feel

The goal of the game feel sub-role is to make sure the player's interactions with the game are satisfying and impactful. To this end, we have introduced a number of features. When the Fox collects a cherry, we've created a simple animation to make the collection process feel more rewarding. Similarly, when the Fox kills an opponent by jumping over them, we've added a visual effect to emphasize the action.We also spent a considerable amount of time perfecting the physics of the Fox's jump. Getting the speed and landing feel right was an iterative process that involved numerous rounds of testing and adjusting. The aim was to make the jump feel responsive and satisfying for players, which is a critical aspect of game feel as discussed in our course.

[Contributors: Jaspreet Singh and Agam Bhullar]
