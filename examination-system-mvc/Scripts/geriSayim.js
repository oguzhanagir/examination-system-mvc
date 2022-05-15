const startingMinutes = 10;
let time = startingMinutes * 60;

const countDownEl = document.querySelector('#countDown');

setInterval(updateCoutDown, 1000);

function updateCoutDown() {
    const minutes = Math.floor(time / 60);
    let seconds = time % 60;

    seconds = seconds < 10 ? '0' + seconds : seconds;

    countDownEl.innerHTML = `${minutes}:${seconds}`;

    time--;
}

