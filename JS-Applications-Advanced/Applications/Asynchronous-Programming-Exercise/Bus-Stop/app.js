async function getInfo() {
    const stopId = document.getElementById('stopId').value.trim();
    const stopNameElement = document.getElementById('stopName');
    const busesList = document.getElementById('buses');

    stopNameElement.textContent = ''; // Clear previous stop name
    busesList.innerHTML = ''; // Clear previous bus list

    try {
        const response = await fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopId}`);
        if (!response.ok) {
            throw new Error('Network response was not ok.');
        }

        const data = await response.json();
        const { name, buses } = data[stopId];

        stopNameElement.textContent = `Bus Stop: ${name}`;

        for (const busId in buses) {
            const time = buses[busId];
            const listItem = document.createElement('li');
            listItem.textContent = `Bus ${busId} arrives in ${time} minutes`;
            busesList.appendChild(listItem);
        }
    } catch (error) {
        stopNameElement.textContent = 'Error fetching bus information.';
        console.error('Error:', error);
    }
}