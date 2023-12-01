function isSameNumber(number) {
  let numberStr = number.toString();
  let firstNum = numberStr[0];
  let result = true;
  let sum = 0;
  for (var i = 0; i < numberStr.length; i++) {
    if (firstNum != numberStr[i]) {
      result = false;
    }
    sum += Number(numberStr[i]);
  }
  console.log(result);
  console.log(sum);
}
