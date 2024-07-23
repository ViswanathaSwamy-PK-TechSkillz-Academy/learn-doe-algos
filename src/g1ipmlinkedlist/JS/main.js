const { LinkedList, reverse } = require('./LinkedList');
const { displayLinkedListWithForwardArrow } = require('./printLinkedList');

function main() {
    const inputs = [
        [1, 2, 3, 4, 5],
        [1, 2, 3, 4, 5, 6],
        [3, 2, 1],
        [10],
        [1, 2],
    ];

    inputs.forEach((input, index) => {
        const inputLinkedList = new LinkedList();
        inputLinkedList.createLinkedList(input);

        process.stdout.write(`${index + 1}. \tInput linked list: `);
        displayLinkedListWithForwardArrow(inputLinkedList.head);

        process.stdout.write("\n\tReversed linked list: ");
        const reversedHead = reverse(inputLinkedList.head);
        displayLinkedListWithForwardArrow(reversedHead);

        console.log("\n" + "-".repeat(100));
    });
}

main();
