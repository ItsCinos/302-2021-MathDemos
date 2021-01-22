float valStart = 0;
float valEnd = 500;

float animLength = 3;
float animPlayheadTime = 0;
boolean isTweenPlaying = false;

float previousTimestamp = 0;

void setup(){
 size(500, 500); 
}
void draw(){  
  
 background(128);
 
 float currentTimestamp = millis()/1000.0;
 float dt = currentTimestamp - previousTimestamp;
 previousTimestamp = currentTimestamp;
 
 if(isTweenPlaying) {
   animPlayheadTime += dt;
   if(animPlayheadTime > animLength) isTweenPlaying = false;
 }
 println(animPlayheadTime);
 
 float p = animPlayheadTime / animLength;
 
 //p = p * p; //ease in
 //p = 1 - (1 - p) * (1 - p); //ease out 
 p = p * p * (3 - 2 * p); //smooth-step
 
 float x = lerp(valStart, valEnd, p);
 ellipse(x, height/2.0, 20, 20);
 
}

void mousePressed(){
  animPlayheadTime = 0;
  isTweenPlaying = true;
}
