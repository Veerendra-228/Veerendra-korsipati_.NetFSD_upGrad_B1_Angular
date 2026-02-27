// Data
let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

console.log("===== Task 1 =====");
let titles = books.map(book => book.title);
console.log("Book Titles:", titles);
let totalInventoryValue = books.reduce(
  (total, book) => total + (book.price * book.stock),
  0
);
console.log("Total Inventory Value:", totalInventoryValue);
let costlyBooks = books.filter(book => book.price > 500);
console.log("Books Above ₹500:", costlyBooks);
let increasedPrices = books.map(book => ({
  ...book,
  price: +(book.price * 1.05).toFixed(2)
}));
console.log("Price Increased by 5%:", increasedPrices);
let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log("Sorted by Price:", sortedBooks);
function removeBookById(id) {
  return books.filter(book => book.id !== id);
}
console.log("After Removing ID 2:", removeBookById(2));
let anyOutOfStock = books.some(book => book.stock === 0);
console.log("Any Book Out of Stock:", anyOutOfStock);
let groupedByPrice = books.reduce((acc, book) => {
  let range;

  if (book.price <= 400) {
    range = "Low (<=400)";
  } else if (book.price <= 600) {
    range = "Medium (401-600)";
  } else {
    range = "High (>600)";
  }

  acc[range] = acc[range] || [];
  acc[range].push(book);
  return acc;
}, {});

console.log("Grouped by Price Range:", groupedByPrice);
let discountBooks = books.map(book =>
  book.price > 600
    ? { ...book, price: +(book.price * 0.9).toFixed(2) }
    : book
);

console.log("Discount Applied (>600):", discountBooks);
let invoice = books
  .map(book => `${book.title} - ₹${book.price} x ${book.stock}`)
  .join("\n");

console.log("Invoice:\n" + invoice);