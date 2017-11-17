function  stringifyJSON(input) {
    let person = {};

    for(let i = 0; i < input.length; i++){
        let args = input[i].split(' -> ');

        if(!Number(args[1])) {
            person[args[0]] = args[1];
        } else {
            person[args[0]] = Number(args[1]);
        }
    }

    console.log(JSON.stringify(person));
}
