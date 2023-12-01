function previousDay(year, month, day) {
  const currentDate = new Date(year, month - 1, day);

  const previousDate = new Date(currentDate.getTime() - 24 * 60 * 60 * 1000);

  const previousYear = previousDate.getFullYear();
  const previousMonth = previousDate.getMonth() + 1;
  const previousDay = previousDate.getDate();

  return `${previousYear}-${previousMonth}-${previousDay}`;
}
