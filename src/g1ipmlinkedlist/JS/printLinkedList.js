function displayLinkedListWithForwardArrow(head) {
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

module.exports = { displayLinkedListWithForwardArrow };
