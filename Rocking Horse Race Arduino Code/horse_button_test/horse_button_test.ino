#include <Bounce2.h>

int hoofPins[] = {2, 8};
int turnPins[] = {15, 18};

int touchThreshold = 3000;

Bounce* frontHoof;
Bounce* backHoof;

bool isFront = false;
bool isBack = false;

unsigned long previousTime = 0;

void setup() {
  frontHoof = new Bounce();
  backHoof = new Bounce();
  frontHoof->attach(hoofPins[1], INPUT_PULLUP);
  backHoof->attach(hoofPins[0], INPUT_PULLUP);
  delay(500);
}

void loop() {
  frontHoof->update();
  backHoof->update();

  if(millis()%1000 == 0) {
    previousTime += 1;
  }
  if(previousTime <= 2) {
    Keyboard.press(KEY_UP_ARROW);
  } else {
    Keyboard.release(KEY_UP_ARROW);
  }

  if(frontHoof->fell() && isFront == false) {
    isFront = true;
    isBack = false;
  }

  if(backHoof->fell() && isBack == false) {
    isBack = true;
    isFront = false;
    previousTime = 0;
  }
  
  if(touchRead(turnPins[0]) > touchThreshold) {
    Keyboard.press(KEY_RIGHT_ARROW);
  } else {
    Keyboard.release(KEY_RIGHT_ARROW);
  }

  if(touchRead(turnPins[1]) > touchThreshold) {
    Keyboard.press(KEY_LEFT_ARROW);
  } else {
    Keyboard.release(KEY_LEFT_ARROW);
  }

}
