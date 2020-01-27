# ZumoPTAssignment
Programming Things assignment code and GUI, up to task 4 done
# Zumo Assignment, Programming Things

In this report, I will cover what I have achieved with regards to the various objectives outlined in the assignment brief, as well as how I approached the key issues that I came up against. Furthermore, I would also like to acknowledge open source code that I used allowing me to use gyro sensors to turn angles comfortably.

## Task 1: Manual Control of the Zumo
Manual control of the Zumo proved to be relatively simple, as this only required communication of a 'ping-pong' nature with the Zumo. Most of this functionality was available from lectures and seminars provided to us. Implementing this into my own code was relatively straightforward, and was done through Zumo and XBee's provided 'Serial1' libraries and methods.

Using the incoming byte as the Serial1's read meant that as the user, I could send characters back and forth from a GUI that was created in C#. Further C# functionality allowed for simple use of either the specified keyboard keys (WASD, LR, C or X to stop) or for me to click the GUI if necessary. The Zumo is freely able to be controlled and can navigate the corridor with ease in this mode.

## Task 2: Autonomous Control of the Zumo
Task 2 proved to be considerably more difficult than Task 1, unfortunately. The code was available, generally speaking, in Zumo's included libraries. The Zumo is able to move by itself and to an extent, is able to detect black borders drawn on a white grid. However, this functionality is not always reliable and is prone to errors.

The code utilizes 3 separate line sensors built into the Zumo device itself, with the left and right sensors being used to turn right and left respectively (so as to avoid collision errors or flying off of the surface), with the middle sensor being used to detect a wall or corner where the device may otherwise stop as per the specification.

When the left and right sensors work, the device operates smoothly, and can autonomously begin the course at an angle, repositioning itself when necessary to avoid leaving the boundaries of the course, and then stopping when it reaches a corner. However, I had numerous issues with the looping of this specific functionality, even with instructions in the code as simple as turn left slightly, or turn right. I was unsure how to get this to work 100% reliably, so as it stands in the final version, the Zumo either gets stuck in a loop of spinning around the course indefinitely, requiring manual repositioning and a reset, or works as required and can navigate the course freely. I am not entirely certain when or why this happens, and my entire process basically can be summarised as trial & error. Modify code, upload, test, repeat.

Ultimately, I am not entirely satisfied with this functionality.

## Task 3: Turning Corners
Despite what I may have said about Task 2, once the Zumo does actually reach the corner/a wall, it will stop as required and prompt the user for further input, with the GUI outputting that the corner has been reached. At this point, the user can regain control of the device to perform manual turns of the corner. Further details with regards to this functionality are included in Task 4.

## Task 4: The Zumo turns autonomously around a corner
This functionality operates as intended, allowing the user to press 'L' or 'R' to turn the device 90 degrees, as the specification requires. This functionality has been implemented by using separate header and .cpp files for the TurnSensors. 

It is at this point I would like to credit: [https://github.com/pvcraven/zumo_32u4_examples/tree/master/TurnExample](https://github.com/pvcraven/zumo_32u4_examples/tree/master/TurnExample) for this code, since the functionality allows for the Zumo to turn 90 degrees in an absolute manner, which I was originally doing through a lot of trial and error by modifying the motor speeds to certain intervals, and it didn't always have the desired results (turning too fast, turning too far, moving in some instances etc.)

## Conclusion
In conclusion, I believe I have struggled on this assignment, and that I could have implemented a bit more functionality if I was more versed with the Zumo's functionality and code. Additionally, I should have also dedicated more time to the project (story of my life), however, I am proud of what I have managed to make the device do when it works properly. I believe I have become more well-versed in the Arduino IDE and could perform a similar project to a better standard in the future

It has been interesting working in the Arduino environment and making two different environments talk to each other through the XTCU XBee devices. In the future I think it'd be really cool if I was able to accomplish the rest of the tasks and even add in extra functionality; making the Zumo remember the path it has travelled and so forth would have been really cool to work on.
