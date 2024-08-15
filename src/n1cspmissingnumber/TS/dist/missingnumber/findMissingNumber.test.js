"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
const node_test_1 = __importStar(require("node:test"));
const findMissingNumber_1 = require("./findMissingNumber");
(0, node_test_1.describe)('findMissingNumber', () => {
    (0, node_test_1.default)('should find the missing number correctly', () => {
        const testCases = [
            { nums: [4, 0, 3, 1], expected: 2 },
            { nums: [8, 3, 5, 2, 4, 6, 0, 1], expected: 7 },
            { nums: [1, 2, 3, 4, 6, 7, 8, 9, 10, 5], expected: 0 },
            { nums: [0], expected: 1 },
            { nums: [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23], expected: 22 },
        ];
        testCases.forEach(({ nums, expected }) => {
            expected((0, findMissingNumber_1.findMissingNumber)(nums)).toBe(expected);
        });
    });
});
