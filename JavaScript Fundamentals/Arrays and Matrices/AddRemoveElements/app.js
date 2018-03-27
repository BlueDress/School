function addOrRemove(arr) {

    let initialNumber = 1;
    let result = [];

    for (let command of arr) {

        if (command === "add") {

            result.push(initialNumber);
        }
        else {

            result.pop();
        }

        initialNumber++;
    }

    if (result.length === 0) {

        console.log("Empty");
    }
    else {

        console.log(result.join("\n"));
    }
}

addOrRemove(["add", "add", "add", "add"]);
addOrRemove(["add", "add", "remove", "add", "add"]);
addOrRemove(["remove", "remove", "remove", "remove"]);