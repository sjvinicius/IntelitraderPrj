export function tokenDecode(token) {
    
    token = localStorage.getItem('tkUserUp').split('.')[1];

    return JSON.parse(window.atob(token));

}