function multiplyOrDivide(arr) {
    let firstNumber = Number(arr[0]);
    let secondNumber = Number(arr[1]);

    if (firstNumber > secondNumber) {
        return firstNumber / secondNumber;
    } else {
        return firstNumber * secondNumber;
    }
}