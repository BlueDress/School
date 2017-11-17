function printValue(input) {
    let resultObj = {};

    for(let i = 0; i < input.length - 1; i++){
        let args = input[i].split(' ');

        if(!(args[0] in resultObj)){
            resultObj[args[0]] = [];
        }

        resultObj[args[0]].push(args[1]);
    }

    let keyToFind = input[input.length - 1];

    if(keyToFind in resultObj){
        for(value of resultObj[keyToFind]){
            console.log(value);
        }
    } else {
        console.log('None');
    }
}