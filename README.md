# in-class-activities
### W1
Hello World!!


### W2
1. Why are the r, g, and b variables floats instead of ints, bools, or strings?
    The rgb values needed to store numbers with decimals that can be used with operators,
    which the other datatypes cannot do.
    
2. Why is the _bounce variable an int instead of a float, bool, or string?
    Integers contain whole numbers, which _bounce is, so here is no need for decimals.
    Booleans and strings cannot hold operatable numbers.

3. The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?
    Always put a semi-colon at the end of your line!!!!


### W3
Table# 15
private int brightness;

void SetLightDimness(int sanity)
{
    brightness = sanity; //or something, we didn't have to do the body
}


### W4
1. Line 17 is creating a new boolean member variable (that is inaccessible in the inspector) called `_isGrounded` which is initialized to true.
   Line 28 is an if statement checking (using the `GetKeyDown` method of the `Input`) class if Space is pressed AND `_isGrounded` is true.
   Line 32 reassigns `_isGrounded` to false after the logic within the if statement is completed to prevent double jumping. 

2a. We added Rigidbodies to the SoccerBall and the Cat since they both needed to physically collide and interact with other objects (each other and the floor/walls). We checked the In Trigger on the Goal since it didn't have any physical interaction.
 b. I totally mixed up Y/Z Rotation and Y/Z Position. I had to figure out what went wrong with my movement, and I figured it was something in the constraints menu. Additionally, one of my code lines I forgot to put into a method/class, so I had to locate that and put it into the correct method (`MadeGoal`)

 
### W5
Question: What exactly does the gameObject method do? 
Answer: The gameObject method is used to grab the GameObject that the component is in. 



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
