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

1. Create animation clips and Animator setup.
   - Create Idle animation.
   - Create Walk/Move animation.
   - Create Attack animation.
   - Create Hit/Collision reaction animation.
   - Create Death/Disable animation if needed.
   - Create an Animator Controller and assign it.
2. Create movement and collision animation script.
   - Reference Animator animator.
   - Reference Rigidbody2D if movement is physics-based.
   - Track movement velocity or direction.
   - Detect if object is currently moving.
3. Game logic and npc interact with Animator states.
   - Enemy patrol logic updates movement animation automatically.
   - Stop movement when attacking.
   - Collision with walls flips sprite direction.
   - Taking damage triggers Hit animation trigger.
   - Health reaching zero triggers Death animation.

### Activity 2

1. I created a C# script for scriptableobjects called coinModifier which store the reaward type and descriptor fields mostly textual. I also created some objects coinmodifiers storing data aroung 6 scriptableobjects to test the spawn generation with. The UI I made with a simple button and the onclick was able to call generate() creating 1 coin but the array was suppose to spawn 3, maybe it is overlapping or needs to have a horizontal layout.

## W6

### Activity 1
1. what is NEW
   -  rouge-like coin machine
   -  coin scriptable objects with modifiers
   -  npc
2. [Itch.io Build](https://sinnabardev.itch.io/gdim-33-vertical-slice-2)
3. your playtesting goal(s)
   - Playability?
   - Can the players interact with rouge like elements?
   - Will the players build out there stats to improve gameplay?
4. Notes: The hold bar takes too long to hold and feels tedious after a while for the player the hold should scale. The ball spawn can be slightly delayed making the player spawn multiple balls. The rougelike coins feel unpolished in response.

### Activity 2
1. Why does the Multiply setting of the Blend node make the resulting color darker and less saturated than the input colors?
The Multiply blend node darkend the resulting color as it takes the first color and the second blend color multiplying the color data effectively apporaching the 1 values in the RBG channels.
2. If we use Multiply to combine Alpha values, will the resulting value be more or less translucent than either of the original values, and why?
Mathematically it would be more translucent as the value of the alpha is between 0 and 1 meaning the maximum numbers being multiply will be 1 but if numbers are less that 1 then the resulting value is lower.
3. When we created the SampleTexture2D node, Unity auto-created the UV0 Node for us to get the UV coordinates for sampling the texture. Where does the shader get these UV values from?
The texture sampling node is ultilizing UV Map to connect the location of the input texture which is the Shiba texture hooked up to the material.
4. You just learned that you can manipulate colors with math. Does that sound interesting or exciting to you?
I orginally maniplute colors with math using RGB 255 values but this add more complexity to it with positional data, transulcency, and materials, I am both excited and fearful.

## W7

### Activity 1
1. For our vertex color shader in step (2), where did the data for the Vertex Color node come from?
The shiba model mesh asset in the project contains the data for color in 2145 vertices.The vertex color node is taking the object space : postion, normal, annd tangent from the mesh geometry then through fragment to output color at that vertex.
2. Since vertex color is stored as data in each vertex of the mesh, why is the color on our shiba from step (3) blended at the edges of different regions of color?
The color that are blended between the edges of the shiba, are data in between the vertices as this is a combination of the vertices color data. 
3. Why is the shiba from step (3), which is colored with vertex color, less detailed than the shiba we rendered with a texture in last week’s activity? Given that vertex color generally results in a less detailed color application than applying a texture, what can you imagine vertex color is useful for?
The shiba is not using pixel by pixel color data to map the mesh, instead it is using the blend of vertices color data to interpolate the color by blending in between the ploygons of the mesh model.
4. Based on the color of the shiba in step (4), does anything look wrong with the mesh’s vertex normals?
Based on the color of the shiba from this step it seems that the normal of the shiba is backwards reflecting the color with the light source.
5. We used the color output of a shader to visualize a mesh’s vertex normal values in step (4). Name one other piece of vertex data (or any kind of data) you can imagine testing with a debug shader like this, and describe why that might be useful.
Using debugger shader for the models mesh vertecies can be applied to show inconsisticies in the mechs polygon map as some surfaces maybe be stretched and this is not apparient in UV unwrappen flatten map. It is also able to visualize the seams in colors.
6. Why is there an error in the lighting in step (4) on the back of the Shiba?
The dot product is calculating in opposite directions between the light direction and inverted normal giving us a negative product and results in black instead of white.
7. Why do you think we set the Blend Mode to Additive for the fire effect in Step (5)?
I think we change the blend mode to additive as to keep the brightness of the fire effect consistant. The alpha mode would have made is a bit less apparent with traparency and multiply would darken the color and effect.

## W8

### Activity 1
1. what is NEW
   -  New animations and sprite
   -  NPC roaming pattern
   -  Added some rougelike element and new coin modifiers
   -  WIP tile map
2. [Itch.io Build](https://sinnabardev.itch.io/gdim-33-vertical-slice-2)
3. your playtesting goal(s)
   - Can the player reach the other states before losing interest?
   - Can the players interact with rouge like elements such as npc and coin modifiers?
   - Will the players build out there stats to improve gameplay?
4. Notes: Player was able to start with the controls once glossing over the instructions. Balls that spawn multiple out of bound threw of the players immersion. Player was not able to recognize the second state as interactable immediately closing it. Improvement is needed to telegraph that this is another state that requires some attention.

### Activity 2B : lighting 2D sprite + 2d shiny animation
1. How is the Fraction node used to animate the shine effect?
The fraction node takes in the value of the time delta from the time node and adds it to the UV node value which increases the values moing the UV for the sample 2D texture for the ShineTex.
2. Why does the Shine texture for the ShinySprite shader need to be BLACK by default? Consider that we're using the Add Node to combine it with the original texture...
We do not want the node to add the values of two white base color value or else instead of shining the effect will flash. The black texture avoids washing out the RGB values in the original texture.
3. Why isn't the building texture we used in the ShaderGraph applied to all of the Sprites that use the ShinySprite shader?
The texture we applied of the building does not get applied because of invalid UV cooridinates dafaulting to the white mode.
4. Why do we multiply fraction(time * ShineSpeed) with the speed variable inside the fraction instead of outside- as in fraction(time)*speed? If you're not sure, try modifying your graph to multiply the Fraction node with ShineSpeed instead of multiplying Time with ShineSpeed, and see what happens.
Well mathimatically the shinespeed is a float value which we can set if we are doubling the speed and the fraction in inside instead of outside then the fraction will be doubled making the UV skip over textures.