# Unity_3D_Flying_Camera
C# Script Component that gives keyboard control of a Camera Game Object in a 3D Unity project<br/>Feel free to use, copy, distribute, etc.

## Purpose
Written to aid with exploring data visualisations this script allows users to navigate a 3D scene, simply add this Script as a Component of a Camera.<br/>Allows users to reset both position and rotation from the keyboard (its easy to get disorientated if your not using Physics/Colliders/etc).<br/>Might serve as a usefull starting point for FPS or flying game.

## Controls
### Movement
W/S = up/down the z axis<br/>
A/D = up/down the x axis<br/>
PageUp/PageDown = up/down the y axis<br/>
Space(held down) = accelerate movement<br/>
X = reset position
###  Rotation
UpArrow/DownArrow = Rotate around x axis<br/>
LeftArrow/RightArrow = Rotate around y axis<br/>
Z = reset rotation

## Public Fields - Edit directly from Unity UI (no coding required)
Movement Speed - How fast W,A,S,D work<br/>
Movement Max Speed - Limits the affect of the Space bar accelerator<br/>
Rotation Speed - How  fast the arrow keys work<br/>
Reset x/y/z - 3 values that determine where the camera goes when the user presses X (Vector reset)
## Notes & Acknowledgements
My first attempt at Unity coding, guidance taken from:<br/>
https://gist.github.com/RyanBreaker/932dc35302787d2f39df6b614a50c0c9<br/>https://gamedev.stackexchange.com/questions/104693/how-to-use-input-getaxismouse-x-y-to-rotate-the-camera<br/>
The space bar does not accelerate the rotation or movement in the y-axis.
Hope this helps, may well update in due course.

