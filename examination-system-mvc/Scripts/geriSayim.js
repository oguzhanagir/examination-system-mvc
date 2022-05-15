const startingMinutes = 1;
let time = startingMinutes * 60;

const countDownEl = document.querySelector('#countDown');



let countStart = setInterval(() => {
    if (time <= 0) {
        clearInterval(countStart);
        window.location.href = "~/Student/Index";
    }
    else {
        time--;

        const minute = Math.floor(time / 60) % 60;
        const second = Math.floor(time % 60);
        countDownEl.innerHTML = `Sınav Süresi : ${format(minute)} : ${format(second)} `
    }
}, 1000);

function format(a) {
    return a < 10 ? `0${a}` : a;
}