import Registration from "../models/Registration.js";
import { addRegistration } from "../services/registrationService.js";
import { getEventById, updateEvent } from "../services/eventService.js";

// Handle registration form
export const handleRegistration = async () => {

  const eventId = document.getElementById("eventId").value;
  const name = document.getElementById("participantName").value;
  const email = document.getElementById("email").value;
  const phone = document.getElementById("phone").value;

  const newRegistration = new Registration(
    Date.now(),
    eventId,
    name,
    email,
    phone
  );

  const validation = newRegistration.validate();
  if (!validation.isValid) {
    alert(validation.message);
    return;
  }

  try {
    // Get event details
    const event = await getEventById(eventId);

    if (event.availableSeats <= 0) {
      alert("No seats available!");
      return;
    }

    // Add registration
    await addRegistration(newRegistration);

    // Decrease seat count
    event.availableSeats -= 1;
    await updateEvent(eventId, event);

    alert("Registration successful!");

    setTimeout(() => {
        window.location.href = "index.html";
    }, 300);
  } catch (error) {
    alert("Error during registration.");
  }
};