import Event from "../models/Event.js";
import { getEvents, 
  addEvent, 
  updateEvent, 
  deleteEvent, 
  getEventById 
} from "../services/eventService.js";

// Render events in index.html
export const loadEvents = async () => {
  const eventList = document.getElementById("eventList");
  if (!eventList) return;

  try {
    const events = await getEvents();
    eventList.innerHTML = "";

    events.forEach((event) => {
      eventList.innerHTML += `
      <div class="col-md-6 col-lg-4">
      <div class="card shadow-sm event-card h-100">
      <div class="card-body">
      <h5 class="card-title text-primary">${event.title}</h5>
      <p class="card-text">${event.description}</p>
      <p class="mb-1"><strong>Date:</strong> ${event.date}</p>
      <p class="mb-1"><strong>Location:</strong> ${event.location}</p>
      <p><strong>Seats:</strong> ${event.availableSeats}</p>
      <div class="event-buttons mt-3">
        <button class="btn btn-sm btn-success"
          onclick="editEvent(${event.id})">
          Edit
        </button>
        <button class="btn btn-sm btn-danger"
          onclick="removeEvent(${event.id})">
          Delete
        </button>
      </div>
    </div>
  </div>
</div>
`;  
    });
  } catch (error) {
    console.error(error);
  }
};
export const loadEventForEdit = async () => {
  const params = new URLSearchParams(window.location.search);
  const id = params.get("id");

  if (!id) return;

  const event = await getEventById(id);

  document.getElementById("title").value = event.title;
  document.getElementById("description").value = event.description;
  document.getElementById("date").value = event.date;
  document.getElementById("location").value = event.location;
  document.getElementById("capacity").value = event.capacity;
};

// Handle add event form
export const handleAddEvent = async (e) => {
  e.preventDefault();

  const params = new URLSearchParams(window.location.search);
  const id = params.get("id");

  const title = document.getElementById("title").value;
  const description = document.getElementById("description").value;
  const date = document.getElementById("date").value;
  const location = document.getElementById("location").value;
  const capacity = parseInt(document.getElementById("capacity").value);

  const eventData = new Event(
    id ? id : Date.now(),
    title,
    description,
    date,
    location,
    capacity
  );

  const validation = eventData.validate();
  if (!validation.isValid) {
    alert(validation.message);
    return;
  }

  try {
    if (id) {
      await updateEvent(id, eventData);
      alert("Event updated successfully!");
    } else {
      await addEvent(eventData);
      alert("Event added successfully!");
    }

    window.location.href = "index.html";
  } catch (error) {
    alert("Error saving event.");
  }
};
export const editEvent = (id) => {
  window.location.href = `add-event.html?id=${id}`;
};

window.editEvent = editEvent;

// Delete event
export const removeEvent = async (id) => {
  try {
    await deleteEvent(id);
    loadEvents();
  } catch (error) {
    alert("Error deleting event.");
  }
};

window.removeEvent = removeEvent;