function buildDatabase(arr) {

    let database = new Map();

    for (let i = 0; i < arr.length; i++) {

        let tokens = arr[i].split("|").map(t => t.trim());
        let system = tokens[0];
        let component = tokens[1];
        let subComponent = tokens[2];

        if (!database.has(system)) {

            database.set(system, new Map());
        }

        let componentsMap = database.get(system);

        if (!componentsMap.has(component)) {

            componentsMap.set(component, []);
        }

        let subComponentsArr = componentsMap.get(component);
        subComponentsArr.push(subComponent);
    }

    let sortedSystems = [...database.entries()].sort(sortDatabase)

    for (let [system, components] of sortedSystems) {

        console.log(system);
        let sortedComponents = [...components.entries()].sort(sortDatabase);

        for (let [component, subComponents] of sortedComponents) {

            console.log(`|||${component}`);

            for (let i = 0; i < subComponents.length; i++) {

                console.log(`||||||${subComponents[i]}`);
            }
        }
    }

    function sortDatabase(a, b) {

        let firstCriteria = b[1].size - a[1].size;

        if (firstCriteria !== 0) {

            return firstCriteria;
        }

        return a[0].localeCompare(b[0]);
    }
}

buildDatabase(["SULS | Main Site | Home Page", "SULS | Main Site | Login Page", "SULS | Main Site | Register Page", "SULS | Judge Site | Login Page", "SULS | Judge Site | Submittion Page", "Lambda | CoreA | A23", "SULS | Digital Site | Login Page", "Lambda | CoreB | B24", "Lambda | CoreA | A24", "Lambda | CoreA | A25", "Lambda | CoreC | C4", "Indice | Session | Default Storage", "Indice | Session | Default Security"]);
