class BankAccount {
  constructor(accountHolder, balance) {
    this.accountHolder = accountHolder;
    this.balance = balance;
  }
  deposit(amount) {
    if (amount > 0) {
      this.balance += amount;
      console.log(`Deposited ${amount}. New balance: ${this.balance}`);
    } else {
      console.log("Deposit amount must be positive.");
    }
  }
  withdraw(amount) {
    if (amount > this.balance) {
      console.log("Insufficient balance. Withdrawal denied.");
    } else if (amount <= 0) {
      console.log("Withdrawal amount must be positive.");
    } else {
      this.balance -= amount;
      console.log(`Withdrew ${amount}. New balance: ${this.balance}`);
    }
  }
  checkBalance() {
    console.log(`Account Holder: ${this.accountHolder}`);
    console.log(`Current Balance: ${this.balance}`);
  }
}
let acc1 = new BankAccount("Rahul", 1000);
acc1.deposit(500);     
acc1.withdraw(200);     
acc1.withdraw(2000);   
acc1.checkBalance();