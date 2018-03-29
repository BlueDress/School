function storeHeroInventory(arr) {

    let inventories = [];

    for (let i = 0; i < arr.length; i++) {

        let tokens = arr[i].split("/").map(t => t.trim());
        let name = tokens[0];
        let level = Number(tokens[1]);
        let items = tokens[2].split(", ");

        let inventory = { name: name, level: level, items: items };

        inventories.push(inventory);
    }

    console.log(JSON.stringify(inventories));
}

storeHeroInventory(["Isacc / 25 / Apple, GravityGun", "Derek / 12 / BarrelVest, DestructionSword", "Hes / 1 / Desolator, Sentinel, Antara"]);
