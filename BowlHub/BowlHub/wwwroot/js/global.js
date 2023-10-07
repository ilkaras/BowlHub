function getCookie(name) {
    let value = "; " + document.cookie;
    let parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}

function checkAuthorization() {
    return fetch("/auth/checkAuth", {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + getCookie("accessToken")
        }
    })
    .then(response => {
        if (response.status === 401) {
            const logoutBtn = document.body.querySelector('#logoutBtn')
            if (logoutBtn) {
                logoutBtn.remove()
            }
            return Promise.resolve(false);
        }
        if (response.ok === true) {
            const loginBtn = document.body.querySelector('a[href="/auth/login"]')
            const signupBtn = document.body.querySelector('a[href="/auth/signup"]')
            if (loginBtn) {
                loginBtn.remove()
            }

            if (signupBtn) {
                signupBtn.remove()
            }
            return true
        }
    })
    .catch(error => {
        console.log("There was an error:", error);
    });
}

function userLogout() {
    fetch("/auth/logout")
        .then(response => {
            if (response.ok === true) {
                document.location.reload()
            }
        })
}
