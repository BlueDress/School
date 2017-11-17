function addOrRemove(input) {
    let resultArr = [];

    for (let i = 0; i < input.length; i++) {
        let args = input[i].split(' ');
        let command = args[0];
        let index = Number(args[1]);

        if (command == 'add') {
            resultArr.push(index);
        } else {
            resultArr.splice(index, 1);
        }
    }
    for (let i = 0; i < resultArr.length; i++) {
        console.log(resultArr[i]);
    }

}