class Product {
    constructor({ name, price, category = "General", ...extraDetails }) {
        this.name = name;
        this.price = price;
        this.category = category;
        this.extraDetails = { ...extraDetails }; 
    }

    getDetails = () => {
        return `Product: ${this.name} | Price: ₹${this.price} | Category: ${this.category}`;
    }
    applyDiscount(discount = 0) {
        const finalPrice = this.price - discount;
        return `Final Price after ₹${discount} discount: ₹${finalPrice}`;
    }
    cloneProduct() {
        return new Product({ ...this, ...this.extraDetails });
    }
}
const product1 = new Product({
    name: "Smartphone",
    price: 25000,
    category: "Electronics",
    brand: "Samsung",
    warranty: "1 Year"
});

console.log(product1.getDetails());
console.log(product1.applyDiscount(2000));

const product2 = product1.cloneProduct();
console.log(product2.getDetails());