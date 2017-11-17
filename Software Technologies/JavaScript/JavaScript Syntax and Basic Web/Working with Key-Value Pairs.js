function printValue(input) {
    let resultObj = {};

    for(let i = 0; i < input.length - 1; i++){
        let args = input[i].split(' ');

        if(!(args[0] in resultObj)){
            resultObj[args[0]] = args[1];
        }

        resultObj[args[0]] = args[1];
    }

    let keyToFind = input[input.length - 1];

    if(keyToFind in resultObj){
        console.log(resultObj[keyToFind]);
    } else {
        console.log('None');
    }
}