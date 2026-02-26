class Shape {
  calculateArea() {
    console.log("Area calculation not defined.");
  }
}
class Circle extends Shape {
  constructor(radius) {
    super();
    this.radius = radius;
  }

  calculateArea() {
    let area = Math.PI * this.radius * this.radius;
    console.log(`Circle Area: ${area.toFixed(2)}`);
  }
}
class Rectangle extends Shape {
  constructor(length, width) {
    super();
    this.length = length;
    this.width = width;
  }

  calculateArea() {
    let area = this.length * this.width;
    console.log(`Rectangle Area: ${area}`);
  }
}
class Triangle extends Shape {
  constructor(base, height) {
    super();
    this.base = base;
    this.height = height;
  }

  calculateArea() {
    let area = 0.5 * this.base * this.height;
    console.log(`Triangle Area: ${area}`);
  }
}
let shapes = [
  new Circle(5),
  new Rectangle(10, 4),
  new Triangle(6, 8)
];

for (let shape of shapes) {
  shape.calculateArea(); 
}