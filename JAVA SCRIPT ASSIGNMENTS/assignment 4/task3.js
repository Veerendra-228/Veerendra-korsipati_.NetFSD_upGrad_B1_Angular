let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

console.log("===== Assignment 3 =====");
let totalCartValue = cart.reduce(
  (total, item) => total + (item.price * item.qty),
  0
);
console.log("Total Cart Value:", totalCartValue);
function increaseQuantity(id) {
  return cart.map(item =>
    item.id === id
      ? { ...item, qty: item.qty + 1 }
      : item
  );
}
console.log("Increase Qty (ID 2):", increaseQuantity(2));
function removeProduct(id) {
  return cart.filter(item => item.id !== id);
}
console.log("Remove Product (ID 3):", removeProduct(3));
let discountedCart = cart.map(item =>
  item.price > 10000
    ? { ...item, price: +(item.price * 0.9).toFixed(2) }
    : item
);
console.log("Discounted Cart (>10000):", discountedCart);
let sortedCart = [...cart].sort(
  (a, b) => (a.price * a.qty) - (b.price * b.qty)
);
console.log("Sorted by Total Item Price:", sortedCart);
let anyExpensive = cart.some(item => item.price > 50000);
console.log("Any Product > 50000:", anyExpensive);
let allInStock = cart.every(item => item.qty > 0);
console.log("All Items In Stock:", allInStock);