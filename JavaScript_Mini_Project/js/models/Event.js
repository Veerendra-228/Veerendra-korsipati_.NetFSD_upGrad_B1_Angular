export default class Event {
  constructor(id, title, description, date, location, capacity, availableSeats = capacity) {
    this.id = id;
    this.title = title;
    this.description = description;
    this.date = date;
    this.location = location;
    this.capacity = capacity;
    this.availableSeats = availableSeats;
  }

  // Validate event data
  validate() {
    if (!this.title || !this.location) {
      return { isValid: false, message: "Title and Location are required." };
    }

    if (!this.date) {
      return { isValid: false, message: "Date is required." };
    }

    const today = new Date();
    const eventDate = new Date(this.date);

    if (eventDate < today.setHours(0, 0, 0, 0)) {
      return { isValid: false, message: "Date cannot be in the past." };
    }

    if (!this.capacity || this.capacity <= 0) {
      return { isValid: false, message: "Capacity must be a positive number." };
    }

    return { isValid: true, message: "Validation successful." };
  }

  // Check seat availability
  hasAvailableSeats() {
    return this.availableSeats > 0;
  }

  // Decrease available seats after registration
  decreaseSeat() {
    if (this.hasAvailableSeats()) {
      this.availableSeats -= 1;
      return true;
    }
    return false;
  }
}