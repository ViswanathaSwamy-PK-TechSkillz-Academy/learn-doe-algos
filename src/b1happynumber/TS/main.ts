import { isHappyNumber } from './happyNumberHelper';

function main(): void {
    const inputs: number[] = [1, 5, 19, 25, 7];
    inputs.forEach((input, i) => {
        console.log(`Input Number: ${input}`);
        console.log(`Is it a happy number? ${isHappyNumber(input)}`);
        console.log("-".repeat(50));
    });
}

main();
