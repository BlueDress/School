function modifyGem(arr) {

    let desiredThickness = Number(arr[0]);

    for (let i = 1; i < arr.length; i++) {

        let operationsPerformed = [{ Name: "Cut", Value: 0 }, { Name: "Lap", Value: 0 }, { Name: "Grind", Value: 0 }, { Name: "Etch", Value: 0 }, { Name: "X-ray", Value: 0 }];
        let currentThicknes = Number(arr[i]);

        console.log(`Processing chunk ${currentThicknes} microns`);

        while (true) {

            if (currentThicknes === desiredThickness) {

                break;
            }

            if (currentThicknes === desiredThickness - 1) {

                operationsPerformed.filter(o => o.Name === "X-ray").map(o => o.Value++);
                break;
            }

            if (currentThicknes / 4 >= desiredThickness - 1) {

                currentThicknes = Math.floor(currentThicknes / 4);

                operationsPerformed.filter(o => o.Name === "Cut").map(o => o.Value++);
            }
            else if (currentThicknes * 0.8 >= desiredThickness - 1) {

                currentThicknes = Math.floor(currentThicknes * 0.8);

                operationsPerformed.filter(o => o.Name === "Lap").map(o => o.Value++);
            }
            else if (currentThicknes - 20 >= desiredThickness - 1) {

                currentThicknes = Math.floor(currentThicknes - 20);

                operationsPerformed.filter(o => o.Name === "Grind").map(o => o.Value++);
            }
            else if (currentThicknes - 2 >= desiredThickness - 1) {

                currentThicknes = Math.floor(currentThicknes - 2);

                operationsPerformed.filter(o => o.Name === "Etch").map(o => o.Value++);
            }
        }

        for (let operation of operationsPerformed.filter(o => o.Value != 0)) {

            if (operation.Name === "X-ray") {
                console.log(operation.Name + ' x' + operation.Value);
            }
            else {
                console.log(operation.Name + ' x' + operation.Value);
                console.log("Transporting and washing");
            }
        }

        console.log(`Finished crystal ${desiredThickness} microns`);
    }
}

modifyGem([1000, 4000, 8100])
