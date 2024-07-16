import { Pair } from './Pair';

export class Bucket {
    private pairs: Pair[];

    constructor() {
        this.pairs = [];
    }

    get(key: number): number {
        const pair = this.pairs.find(pair => pair.key === key);
        return pair ? pair.value : -1;
    }

    update(key: number, value: number): void {
        const index = this.pairs.findIndex(pair => pair.key === key);
        if (index !== -1) {
            this.pairs[index].value = value;
        } else {
            this.pairs.push(new Pair(key, value));
        }
    }

    remove(key: number): void {
        this.pairs = this.pairs.filter(pair => pair.key !== key);
    }
}
