function setValuesToIndexes(input) {
    let resultArr = [];
    resultArr[Number(input[0]) - 1] = 0;

    for(let i = 1; i < input.length; i++){
        let args = input[i].split(" - ").map(Number);

        resultArr[args[0]] = args[1];
    }

    for(let i = 0; i < resultArr.length; i++){
        if(resultArr[i] === undefined){
            console.log('0');
        } else {
            console.log(resultArr[i]);
        }
    }
}