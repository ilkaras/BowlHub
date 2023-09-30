async function getAllPlaces(){
    const response = await fetch("/getAllPlaces", {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })

    if (response.ok === true) {
        const data = (await response.json()).value
        const cardsContainer = document.body.querySelector(".cards-container")
        data.forEach(cardData => {
            cardsContainer.innerHTML += `
            <section class="card">
                <div class="card-header">
                    <h3>${cardData.name}</h3>
                </div>
                <div class="card-body">
                    <div class="card-field">
                        <h3 class="card-field-name">City:</h3>
                        <span class="card-field-content">${cardData.city}</span>
                    </div>
                    <div class="card-field">
                        <h3 class="card-field-name">Address:</h3>
                        <span class="card-field-content">${cardData.address}</span>
                    </div>
                    <div class="card-field">
                        <h3 class="card-field-name">Phone:</h3>
                        <span class="card-field-content">${cardData.adminPhone}</span>
                    </div>
                </div>
                <input type="button" class="card-button" value="Select">
            </section>`
        })
    }
}

getAllPlaces()