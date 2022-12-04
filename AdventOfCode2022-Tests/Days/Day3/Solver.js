function* range(start, end) {
    for (let i = start; i <= end; i++) {
        yield i;
    }
}

function* chunks(arr, n) {
    if (arr.length % n === 0) {
        for (let i = 0; i < arr.length; i += n) {
            yield arr.slice(i, i + n);
        }
    }
    else {
        let max = (arr.length / n) * n;
        for (let i = 0; i < max; i += n) {
            yield arr.slice(i, i + n);
        }
        for (let i = max; i < arr.length; i += Math.max(n, arr.length - i)) {
            yield arr.slice(i, i + Math.max(n, arr.length - i));
        }
    }
  }

let lowerCase = [...range(1, 26)].map((x) => {
    return String.fromCharCode(x + 96);
});
let upperCase = [...range(1, 26)].map((x) => {
    return String.fromCharCode(x + 64);
});

let fullList = lowerCase + upperCase;

fullList = fullList.replace(/,/g,"");

let priority = Object.fromEntries(fullList.split("").map((x) => [x, fullList.indexOf(x) + 1]));

function intersectBags(firstBag, secondBag) {
    let intersection = '';
    firstBag.split('').forEach(character => {
        if (secondBag.split('').includes(character)) {
            intersection = character;
        }
    });
    return intersection;
}

function intersectGroups(firstBag, secondBag, thirdBag) {
    let intersection = '';
    firstBag.split('').forEach(character => {
        if (secondBag.split('').includes(character) && thirdBag.split('').includes(character)) {
            intersection = character;
        }
    });
    return intersection;
}

function solvePartOne(linesArray) {

    let total = 0;

    linesArray.forEach((line) => {
        let firstBag = line.slice(0,line.length/2);
        let secondBag = line.slice(line.length/2, line.length);
        let commonParam = intersectBags(firstBag, secondBag);
        total += priority[commonParam];
    });

    return total;
}

function solvePartTwo(linesArray) {
    let total = 0;
    let groupsOfElves = [...chunks(linesArray, 3)];
    groupsOfElves.forEach(group => {
        let firstBag = group[0];
        let secondBag = group[1];
        let thirdBag = group[2];
        let commonParam = intersectGroups(firstBag, secondBag, thirdBag);
        total += priority[commonParam];
    });

    return total;
}