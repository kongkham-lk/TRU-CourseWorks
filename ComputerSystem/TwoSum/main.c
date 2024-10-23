#include <stdio.h>
#include <stdlib.h>

int* twoSumLoopTwice(int* nums, int numsSize, int target, int* returnSize) {
    // Use Normal loop (NO Hash Table)
    int diffList[numsSize];
    int targetIndex = -1;
    for (int i = 0; i < numsSize; i++) {
        for (int j = 0; j < i; j++) {
            if (nums[i] == diffList[j]) {
                // Cannot return function's local variable (array var), 
                // since when exit function the array that store on the stack will be free right away.
                // Need to manually allocate a block of mem and return that. 
                int* result = (int*) malloc(2 * sizeof(int));  // Dynamically allocate memory
                result[0] = j;
                result[1] = i;

                // Set returnSize to indicate that two elements are returned
                *returnSize = 2;

                return result;  // Return the allocated array
            }
        }
        int diff = target - nums[i];
        diffList[i] = diff;
    }
    return ((int*) calloc(2, sizeof(int)));
}

int main() {
    int inputs[] = {3,3};
    int inputSize = sizeof(inputs) / sizeof(inputs[0]);
    int target = 6;
    int returnSize;

    // Call the function
    int* result = twoSumLoopTwice(inputs, inputSize, target, &returnSize);

    // Check if result is not NULL and print the result
    if (returnSize > 0 && result != NULL) {
        printf("[%d, %d]\n", result[0], result[1]);
        free(result);  // Free the allocated memory
    } else {
        printf("No solution found.\n");
    }
    return 0;
}