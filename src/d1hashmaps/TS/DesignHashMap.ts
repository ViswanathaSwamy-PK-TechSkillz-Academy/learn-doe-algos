import { Bucket } from './Bucket';

export class DesignHashMap {
    private readonly keySpace: number = 2069;
    private readonly buckets: Bucket[];

    constructor() {
        this.buckets = Array.from({ length: this.keySpace }, () => new Bucket());
    }

    put(key: number, value: number): void {
        const hashKey = key % this.keySpace;
        this.buckets[hashKey].update(key, value);
    }

    get(key: number): number {
        const hashKey = key % this.keySpace;
        return this.buckets[hashKey].get(key);
    }

    remove(key: number): void {
        const hashKey = key % this.keySpace;
        this.buckets[hashKey].remove(key);
    }

    printHashMap(): void {
        this.buckets.forEach((bucket, i) => {
            if (bucket['pairs'].length > 0) {
                const pairs = bucket['pairs'].map(pair => `{key: ${pair.key}, value: ${pair.value}}`).join(' ');
                console.log(`Bucket ${i}: ${pairs}`);
            }
        });
    }
}
