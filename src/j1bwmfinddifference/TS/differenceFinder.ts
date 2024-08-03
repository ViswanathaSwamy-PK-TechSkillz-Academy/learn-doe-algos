// File: differenceFinder.ts

export function extraCharacterIndex(str1: string, str2: string): number {
    let result = 0;

    for (let i = 0; i < str1.length; i++) {
        result ^= str1.charCodeAt(i);
    }

    for (let i = 0; i < str2.length; i++) {
        result ^= str2.charCodeAt(i);
    }

    return str1.length > str2.length
        ? str1.indexOf(String.fromCharCode(result))
        : str2.indexOf(String.fromCharCode(result));
}
