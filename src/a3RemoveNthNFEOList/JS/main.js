const LinkedList = require('./linked_list');

function removeNthLastNode(head, n) {
    let right = head;
    let left = head;

    // Move the right pointer n steps ahead
    for (let i = 0; i < n; i++) {
        if (right) {
            right = right.next;
        } else {
            return head.next; // If n is larger than the length of the list, remove the head
        }
    }

    // If right pointer has reached the end, remove the head
    if (!right) {
        return head.next;
    }

    // Move both pointers until the right pointer reaches the last node
    while (right.next != null) {
        right = right.next;
        left = left.next;
    }

    // Remove the nth node from the end
    left.next = left.next.next;

    return head;
}

module.exports = { removeNthLastNode };

// Template for printing the linked list with forward arrows
function printListWithForwardArrow(linkedListNode) {
    let temp = linkedListNode;
    let result = "";
    while (temp != null) {
        result += temp.data;
        temp = temp.next;
        if (temp != null) result += " → ";
        // if this is the last node, print null at the end
        else result += " → null";
    }
    return result;
}

// Driver Code
function main() {
    const inputs = [
        [23, 89, 10, 5, 67, 39, 70, 28],
        [34, 53, 6, 95, 38, 28, 17, 63, 16, 76],
        [288, 224, 275, 390, 4, 383, 330, 60, 193],
        [1, 2, 3, 4, 5, 6, 7, 8, 9],
        [69, 8, 49, 106, 116, 112, 104, 129, 39, 14, 27, 12]
    ];

    const n = [4, 1, 6, 9, 11];

    for (let i = 0; i < inputs.length; i++) {
        const inputLinkedList = new LinkedList();
        inputLinkedList.createLinkedList(inputs[i]);
        console.log((i + 1) + ".\tLinked List:\t\t", printListWithForwardArrow(inputLinkedList.head));
        console.log("\tn = " + n[i]);
        let result = removeNthLastNode(inputLinkedList.head, n[i]);
        console.log("\tUpdated Linked List:\t", printListWithForwardArrow(result));
        console.log("-".repeat(100));
    }
}

main();