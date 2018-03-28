function findNames(input) {

    let regex = /\b_([A-Za-z0-9]+)\b/g;

    let matches = [];

    while (true) {

        let result = regex.exec(input);

        if (result == null) {

            break;
        }

        matches.push(result[1]);
    }

    console.log(matches.join(","));
}

findNames("__invalidVariable _evenMoreInvalidVariable _validVariable");
