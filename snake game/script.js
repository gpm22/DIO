let canvas = document.getElementById("snake");
let context = canvas.getContext("2d");
let box = 32;
let snake = [];
let direction = "right";

//Generating random food location
let food = {
  x: Math.floor(Math.random()*15 +1) *box,
  y: Math.floor(Math.random()*15 + 1) *box
}

// initial position
snake[0] = {
  x: 8*box,
  y: 8*box
}

//iniciate the Background
function criarBG() {
  context.fillStyle =  "yellow"; //"lightgreen";
  context.fillRect(0, 0, 16*box, 16*box);
}

//create the snake
function criarCobrinha() {

  //creating the snake image on the screen
  for(i=0; i< snake.length; i++){
    context.fillStyle = "black";
    context.fillRect(snake[i].x, snake[i].y, box, box);
  }

}

//Draw Food on the screen
function drawFood() {
  context.fillStyle = "red";
  context.fillRect(food.x,food.y,box, box);
}

document.addEventListener('keydown', update); //keydown working;


function update (event) {

  //Case with 1 head
  if(event.keyCode == 37 && direction != "right") direction = "left"; //the direction cannot be different from the previous direction
  if(event.keyCode == 38 && direction != "down") direction = "up";
  if(event.keyCode == 39 && direction != "left") direction = "right";
  if(event.keyCode == 40 && direction != "up") direction = "down";

  // Case with 2 heads
  /*if(event.keyCode == 37) direction = "left";
  if(event.keyCode == 38) direction = "up";
  if(event.keyCode == 39) direction = "right";
  if(event.keyCode == 40) direction = "down"; */
}

//iniciate the game
function iniciarJogo() {

  //atravessar paredes
  if(snake[0].x > 15*box && direction ==  "right" ) snake[0].x = 0;
  if(snake[0].y > 15*box && direction ==  "down" ) snake[0].y = 0;
  if(snake[0].x < 0 && direction ==  "left" ) snake[0].x = 16*box;
  if(snake[0].y < 0 && direction ==  "up" ) snake[0].y = 16*box;

  let snakeX = snake[0].x;
  let snakeY = snake[0].y;

  //verifing if has a shock bewtween head and body

  for(i=1; i< snake.length; i++) {
    if(snakeX == snake[i].x && snakeY == snake[i].y) {
      clearInterval(jogo)
      alert("Game Over :(")
    }
  }


  criarBG();
  criarCobrinha();
  drawFood();

  //verifing the new position of the snake
  if(direction == "right") snakeX += box;
  if(direction == "left") snakeX -= box;
  if(direction == "up") snakeY -= box;
  if(direction == "down") snakeY += box;

  //verifing if the head positio is the same of the Food
  if (snakeX != food.x || snakeY != food.y ){
    //remove the last part of saneke
    snake.pop();
  } else {
    food = {
      x: Math.floor(Math.random()*15 +1) *box,
      y: Math.floor(Math.random()*15 + 1) *box
    }
  }

  let newHead = {
    x: snakeX,
    y: snakeY
  }

  //add new head to the snake
  snake.unshift(newHead);
}

let jogo = setInterval(iniciarJogo, 100);
