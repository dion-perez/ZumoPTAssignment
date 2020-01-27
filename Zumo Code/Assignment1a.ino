#include "TurnSensor.h"
#include <Zumo32U4.h>
#include <Wire.h>

// Libs
Zumo32U4Motors motors;
Zumo32U4ButtonA buttonA;
Zumo32U4ButtonB buttonB;
Zumo32U4ButtonC buttonC;
Zumo32U4Buzzer buzzer;
Zumo32U4Encoders encoders;
Zumo32U4LineSensors lineSensors;
Zumo32U4ProximitySensors proxSensors;
LSM303 lsm303;
L3G gyro;

// Global variables
int motorSpeed = 100;
// Populating array with 3 line sensors, since only 3 are needed to check for corridor collision
unsigned int lineSensorsValues[3]; //5 sensors
// User input
int incomingChar;
// Important for later operation with autonymity
bool task2 = false;

void setup() {
  // XBee
  Serial1.begin(9600);
  // USB
  Serial.begin(9600);
  //Setup line sensors, make sure to noT REMOVE THIS AGAIN
  lineSensors.initThreeSensors();
  lineSensors.emittersOn();
  // A for Autonomy, not necessary but useful to stop any accidents from happening
  buttonA.waitForButton();
  
  // Use gyro L + R to flick 90 degrees
  turnSensorSetup();
  delay(500);
  turnSensorReset();
}

void loop() {
  // Call Move Zumo instead of having everything here, because it's very very messy.
  // Cut back from MoveZumo() if it stops working again
  // Moved all user inputs to MoveZumo for neater code
  MoveZumo();
}

void MoveZumo() {
  // User input, lets user decide between manual movement, autonomous movement etc.
  incomingChar = Serial1.read();
  switch (incomingChar) {
    // WASD controls (up, left, back, right)
    case 'w':      
      motors.setSpeeds(motorSpeed, motorSpeed);
      break;
    case 'a':
      turnLeft(20);
      break;
    case 's':
      motors.setSpeeds(-motorSpeed, -motorSpeed);
      break;
    case 'd':
      turnRight(20);
      break;

    // Task 2 go until it finds a line and not fly off of the table
    case '2':
      // Necessary for entering/exiting BoundaryControl for zumo to check boundaries
      task2 = true;
      if (task2 == true)
      {
        Serial1.println("Entering task 2");
        // Check corridors, if zumo hits a wall, stop entirely, else if zumo's corner hits a boundary, turn left/right to compensate
        BoundaryControl();
        Serial1.println("Stopping, returning control to user");
        Serial1.println("Press C if complete");
      }
      break;
      
    // Stop motors, enough of nearly flying off the table.
    case 'x':
      motors.setSpeeds(0,0);
      break;
    // 90 deg left turn
    case 'l':
      turnLeft(90);
      // Repeated code for re-entering BoundaryControl(), 
      // but for some reason putting this in its own function breaks functionality
      task2 = true;
      Serial1.println("Turning left 90 degrees and continuing");
      if (task2 == true)
      {
        // Move zumo by itself
        BoundaryControl();
      }
      Serial1.println("Turning left 90 degrees");
      break;
    // 90 deg right turn
    case 'r':
      turnRight(90);
      task2 = true;
      Serial1.println("Turning right 90 degrees and continuing");
      if (task2 == true)
      {
        // Move zumo by itself
        BoundaryControl();
      }
      break;
    // Confirm
    case 'c':
      // User wishes to continue, so task 2 must be true for zumo to check corridors
      task2 = true;
      Serial1.println("Command recieved. Continuing.");
      if (task2 == true)
      {
        // Move zumo by itself
        BoundaryControl();
      }
  }
}

// Autonomous control, zumo moves by itself
void BoundaryControl()
{
  Serial1.println("Entered task 2");
  // Task 2 boolean set true by user with manual input, either c for confirmation or 2 to start task 2
  // Whilst Zumo hasn't hit a wall, keep moving
  while (task2 == true)
  {
    // Prepare values for line sensors
    lineSensors.read(lineSensorsValues);
    // Begin movement
    motors.setSpeeds(motorSpeed, motorSpeed);
    // When zumo left sensor hits a wall, turn right a bit to compensate
    if (lineSensorsValues[0] > 400)
    {
      motors.setSpeeds(motorSpeed, -motorSpeed);
    } 
    // If zumo hits a wall, stop moving entirely and exit the function ready to turn left/right 90 degrees manually
    else if (lineSensorsValues[1] > 300)
    {
      motors.setSpeeds(0, 0); 
      task2 = false;
    }
    // When zumo right sensor hits a wall, turn left a bit to compensate
    else if (lineSensorsValues[2] > 400)
    {
      motors.setSpeeds(-motorSpeed, motorSpeed);
    }
  }
}

// Code for 90 degree turns
int32_t getAngle() {
  // turnAngle is a variable defined in TurnSensor.cpp
  // This fancy math converts the number into degrees turned since the
  // last sensor reset.
  // e: not actually used yet
  return (((int32_t)turnAngle >> 16) * 360) >> 16;
}

void turnLeft(int degrees) {
  turnSensorReset();
  motors.setSpeeds(-150, 150);
  int angle = 0;
  do {
    delay(1);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  } while (angle < degrees);
  motors.setSpeeds(0, 0);
}

void turnRight(int degrees) {
  turnSensorReset();
  motors.setSpeeds(150, -150);
  int angle = 0;
  do {
    delay(1);
    turnSensorUpdate();
    angle = (((int32_t)turnAngle >> 16) * 360) >> 16;
  } while (angle > -degrees);
  motors.setSpeeds(0, 0);
}
