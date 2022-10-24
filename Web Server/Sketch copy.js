//let s;
function preLoad()
{
	pink = new Sprite(400, 150, 50, 100);
	//add animation
	pink.addAni('idle','assets/Pink_Monster_Idle_4.png', 4);
	pink.ani.offset.y = 18;
	pink.addAni('moving', 'assets/Pink_Monster_Walk_6.png', 6);
}
function setup() {
	createCanvas(800, 400);
 
}


function draw() {
	background(0,250,200); 
	fill(0);
	textAlign(CENTER);
	text('You are logged in!', width / 2, height / 2);
	if (mouse.x < pink.x - 10) {
		
		pink.ani = 'moving';
		pink.mirror.x = true; 
		pink.vel.x = -2;
	} else if (mouse.x > pink.x + 10) {
		// if mouse is to the right
		pink.ani = 'moving';
		pink.mirror.x = false; 
		pink.vel.x = 2;
	} else {
		
		pink.ani = 'idle';
		pink.vel.x = 0;
	}
}



