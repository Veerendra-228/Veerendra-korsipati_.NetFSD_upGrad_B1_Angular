const BASE_URL = "http://localhost:3000/events";

// Get all events
export const getEvents = async () => {
  try {
    const response = await fetch(BASE_URL);
    if (!response.ok) throw new Error("Failed to fetch events");
    return await response.json();
  } catch (error) {
    console.error("Error fetching events:", error);
    throw error;
  }
};

// Get single event by ID
export const getEventById = async (id) => {
  try {
    const response = await fetch(`${BASE_URL}/${id}`);
    if (!response.ok) throw new Error("Event not found");
    return await response.json();
  } catch (error) {
    console.error("Error fetching event:", error);
    throw error;
  }
};

// Add new event
export const addEvent = async (eventData) => {
  try {
    const response = await fetch(BASE_URL, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(eventData),
    });

    if (!response.ok) throw new Error("Failed to add event");
    return await response.json();
  } catch (error) {
    console.error("Error adding event:", error);
    throw error;
  }
};

// Update event
export const updateEvent = async (id, updatedData) => {
  try {
    const response = await fetch(`${BASE_URL}/${id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updatedData),
    });

    if (!response.ok) throw new Error("Failed to update event");
    return await response.json();
  } catch (error) {
    console.error("Error updating event:", error);
    throw error;
  }
};

// Delete event
export const deleteEvent = async (id) => {
  try {
    const response = await fetch(`${BASE_URL}/${id}`, {
      method: "DELETE",
    });

    if (!response.ok) throw new Error("Failed to delete event");
    return true;
  } catch (error) {
    console.error("Error deleting event:", error);
    throw error;
  }
};