# ECS-189L_finalProject

To Run properly, go to file
Under file go to Build settings
Under Build settings go to Add Open Scenes to add all scenes/levels

[Reference code for role explanation](https://github.com/M2neko/Due_Tonight)

# Summary
"Super Fox" is an exciting 2D platformer game, inspired by classic titles like Super Mario. Set in a vibrant detailed world, players control a fox character, guiding it through various challenging landscapes filled with obstacles.

As the fox, players are tasked with going through these levels by running and jumping over obstacles, dodging or defeating enemies, and leaping over voids. The fox has the ability to defeat opponents by jumping over them. However, failure to execute this correctly results in the fox's demise, causing the level to restart from the beginning. Players need to time their movements precisely to ensure survival and progress.

# Gameplay explanation
Core game mechanics: The basic action includes running, jumping.

Goals: Player needs to run and collect cherries and dodge opponents to get to the next level untill the game ends.

## Controls:
  ### Keyboard:
    '⬅️''➡️' for movement.
    '⬆️' for jump.


# Main Roles
  Input                 : Jaspreet Singh <br>
  Movement/Physics      : Agam Bhullar <br>
  Animation and Visuals : Olivia Qian `<br>`
  User Interface        : Alan Chuang `<br>`
  Game Logic            : Ameya Naik `<br>`
  
# Input
The Super Fox game is a platform game, and therefore, the input handling is critical to the game experience. For basic movements such as run and jump, we rely on simple keystrokes. For instance, the "right" and "left" arrow keys are used to move the Fox character in the respective directions, while the "up" key is used for the jump action. The sensitivity and responsiveness of these controls have been carefully calibrated to ensure an optimal gaming experience.

The Fox character can also interact with the game environment, such as collecting cherries and killing opponents by jumping over them. This required creating more sophisticated input handling methods. For example, we implemented a collision detection system(box collider 2D) to check if the Fox has landed on an opponent's head or touched a cherry. If a collision is detected, the relevant game logic is executed.

[Contributors: Jaspreet Singh]

# Movement/Physics
The Super Fox game, in essence, is a physics-based platformer game, and as such, we had to ensure the movement and physics within the game felt realistic and satisfying. For the running movement, we used a simple velocity function that updates the Fox's x position based on player input and a fixed speed variable(moveSpeed). This method provided a smooth and responsive movement. 
For jumping, we used the built-in physics engine of the game development platform. We assigned a rigidbody component to the Fox character, which enabled us to apply a force to the character when the player presses the up key. This force propels the Fox upwards, and then gravity pulls it back down, creating a natural-looking jump arc. The jump was adjusted based on a fixed variable jumforce which was tweaked to make the move feel natural.

[Contributors: Agam Bhullar]
  
# Sub-Roles
  Game Feel             : Jaspreet Singh `<br>`
  Gameplay Testing      : Agam Bhullar `<br>`
  Press Kit and Trailer : Olivia Qian `<br>`
  Narrative Design      : Alan Chuang `<br>`
  Audio                 : Ameya Naik `<br>`
  
# Game Feel
The goal of the game feel sub-role is to make sure the player's interactions with the game are satisfying and impactful. To this end, we have introduced a number of features. When the Fox collects a cherry, we've created a simple animation to make the collection process feel more rewarding. Similarly, when the Fox kills an opponent by jumping over them, we've added a visual effect to emphasize the action.We also spent a considerable amount of time perfecting the physics of the Fox's jump. Getting the speed and landing feel right was an iterative process that involved numerous rounds of testing and adjusting. The aim was to make the jump feel responsive and satisfying for players, which is a critical aspect of game feel as discussed in our course.

[Contributors: Jaspreet Singh and Agam Bhullar]

# Gameplay Testing
Gameplay testing is an essential part of game development. It allows us to find and fix bugs, balance game mechanics, and improve the overall player experience. Throughout the development of Super Fox, we conducted multiple rounds of gameplay testing. We tested the functionality of all features, including running, jumping, collecting cherries, defeating opponents, and level progression.
From the testing, we made several important findings and improvements. For instance, we found that some jumps were too difficult to make, leading to player frustration. We adjusted these parts of the levels to make them more balanced. We also realized that some opponents were placed in spots that made them nearly impossible to defeat without taking damage. We adjusted the positions of these opponents to make the game fairer. Also some of our friends were used to remove bias and make some updates.

[Contributors: Agam Bhullar and Jaspreet Singh]
