function calculateWalkingTime(steps, footprintLength, speed) {
  const distance = (steps * footprintLength) / 1000;
  const rests = Math.floor(distance / 0.5);
  const walkingTimeHours = distance / speed;
  const totalRestTime = rests;

  const totalWalkingTimeInMinutes = walkingTimeHours * 60;
  const totalMinutes = Math.floor(totalWalkingTimeInMinutes + totalRestTime);
  const hours = Math.floor(totalMinutes / 60);
  const minutes = totalMinutes % 60;
  const seconds = Math.floor(
    (totalWalkingTimeInMinutes - Math.floor(totalWalkingTimeInMinutes)) * 60
  );

  return `${hours.toString().padStart(2, "0")}:${minutes
    .toString()
    .padStart(2, "0")}:${seconds.toString().padStart(2, "0")}`;
}
