function solve(arr) {
    let x1 = Number(arr[0]);
    let y1 = Number(arr[1]);
    let x2 = Number(arr[2]);
    let y2 = Number(arr[3]);
    let x3 = Number(arr[4]);
    let y3 = Number(arr[5]);

    let distance12 = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));
    let distance23 = Math.sqrt(Math.pow((x3 - x2), 2) + Math.pow((y3 - y2), 2));
    let distance13 = Math.sqrt(Math.pow((x3 - x1), 2) + Math.pow((y3 - y1), 2));

    let shortestDistance = 0;

    if ((distance12 <= distance13) && (distance23 <= distance13)) {
        shortestDistance = distance12 + distance23;
        console.log('1->2->3: ' + shortestDistance);
    }
    else if ((distance12 <= distance23) && (distance13 < distance23)) {
        shortestDistance = distance13 + distance12;
        console.log('2->1->3: ' + shortestDistance);
    }
    else {
        shortestDistance = distance23 + distance13;
        console.log('1->3->2: ' + shortestDistance);
    }
}

solve([-1, -2, 3.5, 0, 0, 2])