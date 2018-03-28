function splitString(stringToSplit, delimiter) {

    return stringToSplit.split(delimiter).join("\n");
}

console.log(splitString("One-Two-Three-Four-Five", "-"));