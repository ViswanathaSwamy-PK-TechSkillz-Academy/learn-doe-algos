import { LinkedListNode } from './LinkedListNode';

function displayLinkedListWithForwardArrow(head: LinkedListNode | null) {
    let temp = head;
    while (temp !== null) {
        process.stdout.write(temp.data.toString());
        temp = temp.next;
        if (temp !== null) {
            process.stdout.write(" → ");
        } else {
            process.stdout.write(" → null");
        }
    }
    console.log();
}

export { displayLinkedListWithForwardArrow };
