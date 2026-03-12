export default class Registration {
  constructor(id, eventId, participantName, email, phone) {
    this.id = id;
    this.eventId = eventId;
    this.participantName = participantName;
    this.email = email;
    this.phone = phone;
  }

  // Validate registration data
  validate() {
    if (!this.participantName) {
      return { isValid: false, message: "Name is required." };
    }

    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!this.email || !emailPattern.test(this.email)) {
      return { isValid: false, message: "Invalid email format." };
    }

    const phonePattern = /^[0-9]{10}$/;
    if (!this.phone || !phonePattern.test(this.phone)) {
      return { isValid: false, message: "Phone must be 10 digits." };
    }

    return { isValid: true, message: "Validation successful." };
  }
}