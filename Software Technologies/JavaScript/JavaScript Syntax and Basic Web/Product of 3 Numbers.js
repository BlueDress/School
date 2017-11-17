function productOfThreeNumbers(arr) {
    let negativeNumbersArr = arr.map(Number).filter(x => x < 0);
    let zeroesInArr = arr.map(Number).filter(x => x == 0);

    if(negativeNumbersArr.length % 2 == 1 && zeroesInArr.length == 0){
        return 'Negative';
    } else {
        return 'Positive';
    }
}
