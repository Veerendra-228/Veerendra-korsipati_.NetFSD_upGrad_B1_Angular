class Wallet {
    #balance = 0;

    constructor(initialBalance = 0) {
        this.#balance = initialBalance;
    }
    addMoney(amount) {
        if (amount <= 0) {
            console.log("Amount must be greater than 0");
            return;
        }
        this.#balance += amount;
        console.log(`Added ₹${amount}. Current balance: ₹${this.#balance}`);
    }
    spendMoney(amount) {
        if (amount <= 0) {
            console.log("Amount must be greater than 0");
            return;
        }
        if (amount > this.#balance) {
            console.log("Insufficient balance!");
            return;
        }
        this.#balance -= amount;
        console.log(`Spent ₹${amount}. Current balance: ₹${this.#balance}`);
    }
    getBalance() {
        return this.#balance;
    }
}
const myWallet = new Wallet(500);

myWallet.addMoney(200);   
myWallet.spendMoney(300); 
console.log("Balance:", myWallet.getBalance()); 

