class User {
    #_password;

    constructor(password) {
        this.password = password; 
    }
    set password(newPassword) {
        if (typeof newPassword !== "string") {
            throw new Error("Password must be a string");
        }
        if (newPassword.length < 6) {
            throw new Error("Password must be at least 6 characters long");
        }
        this.#_password = newPassword;
    }
    get password() {
        return this.#_password;
    }
}
try {
    const user1 = new User("abc123");
    console.log(user1.password); 

    user1.password = "newpass"; 
    console.log(user1.password); 

    user1.password = "123"; 
} catch (error) {
    console.log("Error:", error.message);
}