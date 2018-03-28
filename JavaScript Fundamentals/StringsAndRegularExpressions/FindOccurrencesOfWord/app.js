function findOccurrences(input, word) {

    let regex = new RegExp(`\\b${word}\\b`,"gi");

    let occurrencesCount = 0;

    while (true) {

        let match = regex.exec(input);

        if (match == null) {

            break;
        }

        occurrencesCount++;
    }

    console.log(occurrencesCount);
}

findOccurrences("There was one. Therefore I bought it. I wouldn't buy it otherwise.", "there")