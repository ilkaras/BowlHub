const minutesToHoursMinutes = minutes => `${(Math.floor(minutes / 60)).toString().padStart(2, '0')}:${(minutes % 60).toString().padStart(2, '0')}`;
function updateTime(value, itemId){
    let item = document.body.querySelector(`#${itemId}`)
    item.innerHTML = minutesToHoursMinutes(value)
}

function getLineId() {
    return document.location.href.split('#')[1];
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

function uploadTimeToInputs(object) {
    let input = document.body.querySelector("#start-time-input")
    input.value = +object.dataset.from
    document.body.querySelector("#duration-time-input").value = +object.dataset.to
    let event = new Event('input', {
        'bubbles': true,
        'cancelable': true
    });
    input.dispatchEvent(event);
}

async function getTimeInfo(lineId, line) {
    const baseUrl = document.location.href.split('#')[0];
    document.location.href = `${baseUrl}#${lineId}`;
    
    for(let l of document.body.querySelectorAll(".bowling-line.selected")){
        l.classList.remove("selected")
    }
    line.classList.add("selected")
    
    localStorage.setItem("columnNum", lineId)
    const date = encodeURIComponent(document.body.querySelector(".date-picker").value)
    const urlParams = new URLSearchParams(window.location.search);
    const response = await fetch(`/getTimeInfo?id=${urlParams.get('id')}&lineId=${lineId}&reservationDate=${date}`)
    if (response.ok === true) {
        const data = (await response.json()).value
        const labeledBusy = data.busy.map(interval => ({ type: 'busy', interval }));
        const labeledFree = data.free.map(interval => ({ type: 'free', interval }));

        const combined = [...labeledBusy, ...labeledFree].sort((a, b) => a.interval[0] - b.interval[0]);
        localStorage.setItem("timeInfo", JSON.stringify(combined))
        const container = document.querySelector("#time-containers")
        container.innerHTML = ""
        combined.forEach(item => {
            container.innerHTML += `
            <div class="bowling-line ${item.type}-time" data-from="${item.interval[0]}" data-to="${item.interval[1]-item.interval[0]}"
            ${item.type === "free" ? 'onclick="uploadTimeToInputs(this)"' : ""}>
                <p>From: <span>${minutesToHoursMinutes(item.interval[0])}</span></p>
                <p>To: <span>${minutesToHoursMinutes(item.interval[1])}</span></p>
            </div>
            `
        });
    }
}

function showPayMenu() {
    const token = getCookie("accessToken")
    const errorContainer = document.body.querySelector(".error-container")
    if (token === undefined || token === null) {
        errorContainer.innerHTML = "You are not authorized! <a href='/auth/userLogin'>Authorize</a>"
        return
    }
    
    document.body.querySelector("main").insertAdjacentHTML("afterend", `
        <div class="pay-menu">
            <div class="wrapper">
                <p class="close-btn disable-selection" onclick="document.body.querySelector('.pay-menu').remove()">&times; Close</p>
                <div class="pay-inputs">
                    <input class="pay-input" type="text" placeholder="card number" maxlength="20">
                    <input class="pay-input" type="text" placeholder="MM:YY" maxlength="5">
                    <input class="pay-input" type="text" maxlength="3" placeholder="CVC">
                    <input class="pay-input" type="button" value="Pay reservation" onclick="addNewReservation()">
                </div>
                <p>Test transaction only. No personal data is stored or retained.</p>
            </div>
        </div>
    `)
}

async function addNewReservation() {
    document.body.querySelector('.pay-menu').remove()
    let startTime = +document.body.querySelector("#start-time-input").value
    let endTime = startTime + +document.body.querySelector("#duration-time-input").value
    let reservDate = document.body.querySelector("#reserv-date-input").value

    let overlap = false;
    const combined = JSON.parse(localStorage.getItem("timeInfo"))
    for (let item of combined) {
        if (item.type === 'busy' && startTime < item.interval[1] && endTime > item.interval[0]) {
            overlap = true;
            break;
        }
    }

    const token = getCookie("accessToken")
    const errorContainer = document.body.querySelector(".error-container")
    if (overlap) {
        errorContainer.innerHTML = "The selected time overlaps with a booked reservation!"
        return
    }
    else if (token === undefined || token === null) {
        errorContainer.innerHTML = "You are not authorized! <a href='/auth/userLogin'>Authorize</a>"
        return
    }
    else {
        errorContainer.innerHTML = null
    }
    
    const data = {
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
        document.location.reload()
    }
}