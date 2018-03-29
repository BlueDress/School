function calculateJuiceBottles(arr) {

    let juiceQuantity = {};
    let juiceBottles = {};

    for (let i = 0; i < arr.length; i++) {

        let tokens = arr[i].split("=>").map(t => t.trim());
        let juice = tokens[0];
        let quantity = Number(tokens[1]);

        if (!juiceQuantity.hasOwnProperty(juice)) {

            juiceQuantity[juice] = 0;
        }

        juiceQuantity[juice] += quantity;

        if (juiceQuantity[juice] >= 1000) {

            if (!juiceBottles.hasOwnProperty(juice)) {

                juiceBottles[juice] = 0;
            }

            juiceBottles[juice] += Math.floor(juiceQuantity[juice] / 1000);

            juiceQuantity[juice] = juiceQuantity[juice] % 1000;
        }
    }

    for (let juice in juiceBottles) {

        console.log(`${juice} => ${juiceBottles[juice]}`);
    }
}

calculateJuiceBottles(["Peach => 432", "Qrange => 2000", "Peach => 1432", "Banana => 450", "Peach => 600", "Strawberry => 549"]);