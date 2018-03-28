function capitalize(input) {

    let words = input.split(" ");

    for (let i = 0; i < words.length; i++) {

        words[i] = words[i].toLowerCase();

        let firstLetter = words[i][0].toUpperCase();
        let restOfTheWord = words[i].substr(1);

        let capitalizedWord = firstLetter.concat(restOfTheWord);

        words[i] = capitalizedWord;
    }

    console.log(words.join(" "));
}

capitalize("Was that Easy? tRY thIs onE for SiZe!");