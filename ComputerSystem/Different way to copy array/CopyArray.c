#include <stdio.h>
#include <stdlib.h>

void printArrayElement(double arr[], int iterateNum);
void copy_arr(double target[], double source[], int iterateNum);
void copy_ptr(double *target, double *source, int iterateNum);
void copy_ptrs(double *target, double *source, double *iterateNum);

int main()
{
    int size = 5;
    double source[5] = {1.1, 2.2, 3.3, 4.4, 5.5};
    double target1[5];
    double target2[5];
    double target3[5];
    double* ptrTarget = malloc(sizeof(size));

    printf("\n%s \n", "Test copy_arr():");
    copy_arr(target1, source, 5);
    printArrayElement(target1, sizeof(target1) / sizeof(target1[0]));

    printf("%s \n", "Test copy_ptr():");
    copy_ptr(target2, source, 5);
    printArrayElement(target2, sizeof(target2) / sizeof(target2[0]));

    printf("%s \n", "Test copy_ptrs():");
    copy_ptrs(target3, source, source + 5);
    printArrayElement(target3, sizeof(target3) / sizeof(target3[0]));

    printf("%s \n", "Test Dynamic Memory Allocation:");
    copy_ptr(ptrTarget, source, size);
    printArrayElement(ptrTarget, size);
}

void printArrayElement(double arr[], int iterateNum) {
    for (int i = 0; i < iterateNum; i++)
        printf("%.2f ", arr[i]);
    printf("\n\n");
}

void copy_arr(double target[], double source[], int iterateNum)
{
    for (int i = 0; i < iterateNum; i++)
        target[i] = source[i];
}

void copy_ptr(double *target, double *source, int iterateNum)
{
    for (int i = 0; i < iterateNum; i++)
        target[i] = source[i];
}

void copy_ptrs(double *target, double *source, double *targetSource)
{
    for (int i = 0; source + i != targetSource; i++)
        target[i] = source[i];
}