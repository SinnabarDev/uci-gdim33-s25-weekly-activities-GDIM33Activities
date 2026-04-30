# GDIM 33 In-Class Activities

## W1

### Activity 1

1. [Inspo Board Google Drawing](https://docs.google.com/drawings/d/1iIsWhYMUuojkydBVqBoVylSC1UAXbz6EESBCh6M2yuc/edit?usp=sharing)

2. What patterns are emerging from your inspiration sources- are there any particular gameplay mechanics, genres, or non-game-related aesthetics you’re consistently interested in?
   Some gameplay mechanics emerging from my images are rougelike mechanics of earning point to to level up and getting rewards. The genre I seem to be interested in is pinball. The aesthic that is similar throughout many of the images is cozy cavern.
3. Chat with at least one of your table mates about what they’re interested in building. How are your personal styles and interests similar?
   My teammate wants to create a cute adventutre experience where the player roams the worlds and meets cute cozy characters. Me and my tablemates have the same idea of making a game with a cozy 2D aesthetics with top down viewpoint.
4. Chat with your table's LA about their taste in games. How are their tastes similar to yours?
   When I spoke to the learning assistant, Elijah, about their taste in games they found my taste in rougelike too be addictivite and gambling oriented. On a higher level I was prompted to think about the feeling and vibes of my mood board which is gambling and dopemine high activities. There taste are not very similar but they have expereience the dopamine in mobile gacha games.

### Activity 2

[Breakdown Google Drawing](https://docs.google.com/drawings/d/1ACQqPf3u75INzvXrJxLd3f8samZ2pGGmS_WhqeirIk0/edit?usp=sharing)

## W2

Commited and Pushed to Github Repo

## W3

### Activity 1

[Updated Breakdown Google Drawing](https://docs.google.com/drawings/d/1hyft17UKS-b2Kp7RHTY_xo-L3twOELWk3xWb3Otlxco/edit?usp=sharing)

### Activity 2

1. Why is it advantageous to save the event name for the explore-to-dialogue state transitions as Scene variable ("clickNpcEventName")?
   A scene variable can be accessed from other graphs on the other gameobjects in the scene.

2. Describe how using at least one Debug.Log() node helped you test your Graphs at an intermediate step.
   I used the Debug.Log() node to show which nodes were firing in the graphs steps or reaching the final step. This helped me to figure out that my trigger event node in the walrus was targeting "this" instead of gamecontroller for the custom event.

3. Is the Set Cursor Lock State relevant to your Vertical Slice? Why or why not?
   This is somewhat relevant to my Vertical Slice project as my pinball game will have a state where the mouse cursor needs to be active to interact with the UI elements that will generate gameobjects to use a items and powerups and stored inside an inventory UI.

4. Is the concept of a "game state" relevant to your Vertical Slice? Why or why not?
   The concept of game state is relvant to my Vertical Slice project as it will allow me to transition from active play pinball board to non-active play where the player is using rougelike elements and gameobjects to incoperate to the next active play state.

## W4

### Activity 1

[Itch.io Build](https://sinnabardev.itch.io/gdim33-verticalslice)

Playtesters: Jeremiah Yang, Ke-Chieh Chang, Jingyi Cheng, Brandon Tsay

1. My goals in this playtesting is for the players to interact with the base pinball system with "smooth" physics and score some points reaching the shopUI screen.

2. During playtesting players had trouble identifying the feedback for the pluger and how long to charge it therefore I need a visual indicator to show how long the plunger is pulled. Player found that the physics felt natural and good for unity build. Players also commented that the game felt a little bland as the board of the pinball arena lack visual elements to keep the player engaged. Player also wants to see more unique elements such as modifiers that multiply the ball.

### Activity 2

1. Assuming this activity is completed by a programmer, could a writer add more dialogue to this setup without writing any code? Why or why not?
   A writter can add more dialouge to this setup without much coding because the system uses scriptable object like dialouge to store each line. Writter are working on the text data and context only.
2. What limit is there to the number of dialogue nodes that the writer could create without writing any code?
   I suppose the limit is the amount of graphs that act similar to scriptable objects and the 4 player choices branching out the choices.
3. In your own words, describe the purpose of the "Regenerate Nodes" button.
   The Regenerate Nodes button rescans or refreshes the node library that Unity offers. Regenerate Nodes also checks for new node based scripts that are in the project. Allowing for custiom events and component nodes made from C# scripts.

## W5

### Activity 1

1. Write scriptable object code with your data points.
   - Create RewardTypes based on the modifier desired.
   - Create String Title Name.
   - Create String Text Description.
   - Create sprite icon field.
   - Create int value for rarity.
   - All fields will be passed to a container or prefab.
   - The title name will be a text field to define the object to the player.
   - Sprite will be passed to the container.
   - Description will be passed to container.
   - RewardType will be read from the coin machine code.
   - Amount/modifier will be read from the coin machine code.
2. Create ui/Coin generation manger.
   - UI will be probaly a button with CoinMachine sprite.
   - Component with script coinmanager/generator.
   - 3 container gameobjects to hold instaite coin game child.
   - Coins need to have visual and be button on click().
3. Make other code or interactions read the code.
   - Coin Machine will store a list of scriptable objects and generate from this pool.
   - An array will spawn 3 scriptable objects at RAND.
   - There will be a way to input and apply reward type read from the scriptable object selected.
   - gameObjects are then destroyed.
   - Coin Machine will read the graph and scene variables in graphs that the modifiers target.

### Activity 2

1. I created a C# script for scriptableobjects called coinModifier which store the reaward type and descriptor fields mostly textual. I also created some objects coinmodifiers storing data aroung 6 scriptableobjects to test the spawn generation with. The UI I made with a simple button and the onclick was able to call generate() creating 1 coin but the array was suppose to spawn 3, maybe it is overlapping or needs to have a horizontal layout.
