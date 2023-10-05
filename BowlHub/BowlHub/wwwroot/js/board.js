const minutesToHoursMinutes = minutes => `${(Math.floor(minutes / 60)).toString().padStart(2, '0')}:${(minutes % 60).toString().padStart(2, '0')}`;
function updateTime(value, itemId){
    let item = document.body.querySelector(`#${itemId}`)
    item.innerHTML = minutesToHoursMinutes(value)
}

function getCookie(name) {
    let value = "; " + document.cookie;
    let parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}

function updateStartTime(durationTime, maxTime) {
    let startRange = document.body.querySelector("#start-time-input");
    let startViewer = document.body.querySelector("#start-time");

    let total = parseInt(startRange.value) + parseInt(durationTime);
    if (total >= maxTime) { 
        startRange.value = maxTime - durationTime;
    }

    startViewer.innerHTML = minutesToHoursMinutes(startRange.value);
}

function updateDurationTime(startTime, maxTime) {
    let durationRange = document.body.querySelector("#duration-time-input");
    let durationViewer = document.body.querySelector("#duration-time");

    let maxDuration = maxTime - parseInt(startTime);
    if (parseInt(durationRange.value) > maxDuration) {
        durationRange.value = maxDuration;
    }
    
    durationViewer.innerHTML = minutesToHoursMinutes(durationRange.value);
}

async function getTimeInfo(lineId) {
    localStorage.setItem("columnNum", lineId)
    const urlParams = new URLSearchParams(window.location.search);
    const response = await fetch(`/getTimeInfo?id=${urlParams.get('id')}&lineId=${lineId}`)
    if (response.ok === true) {
        const data = (await response.json()).value
        console.log(data)
    }
}

async function addNewReservation() {
    let startTime = +document.body.querySelector("#start-time-input").value
    let endTime = startTime + +document.body.querySelector("#duration-time-input").value
    let reservDate = document.body.querySelector("#reserv-date-input").value
    
    let token = sessionStorage.getItem("accessToken")
    console.log(token)
    let data = {
        boardId: getCookie("boardId"),
        columnNum: +localStorage.getItem("columnNum"),
        fromReservation: startTime,
        tillReservation: endTime,
        dateReservation: reservDate
    }
    const response = await fetch("/addNewReservation", {
        method: "POST",
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json",
            "Authorization": "Bearer " + token
        },
        body: JSON.stringify(data)
    })
    if (response.ok === true) {
        const responseObject = await response.json()
    }
    return false
}