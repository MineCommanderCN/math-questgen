var array1 = new Array();
var array2 = new Array();
array1 = [3, 6, 5];
array2 = [4, 8, 12];
if (randSeed % 2 == 0) {
    return array1[randSeed % array1.length];
} else {
    return array2[randSeed % array2.length];
}