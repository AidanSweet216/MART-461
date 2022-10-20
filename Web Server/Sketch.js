function setup() {
	createCanvas(800, 400);
    
}


function draw() {
	background(0,250,200); 
	fill(0);
	textAlign(CENTER);
	text('Click to create a new sprite', width / 2, height / 2);

	
	if (mouse.presses()) {
		
		let s = new Sprite(mouse.x, mouse.y, 30, 30);
		
		s.vel.x = random(-5, 5);
		s.vel.y = random(-5, 5);
		
	}

}



