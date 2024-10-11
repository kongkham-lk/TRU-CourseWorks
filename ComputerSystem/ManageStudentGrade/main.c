#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct
{
    char name[50];
    float grade;
} Student;

void printElOfStudent(Student *student, int size)
{
    for (int i = 0; i < size; i++)
    {
        printf("\nStudent %d:\n", i);
        printf("name: %s\n", student[i].name);
        printf("Student: %.2f\n", student[i].grade);
    }
}

int main()
{
    int length = 2;
    printf("\nEnter Number of Student Needed to be recorded: ");
    scanf("%d", &length);

    Student *studentPtr = (Student*)malloc(length * sizeof(Student));
    Student student[length];
    char name[20];
    float grade;
    char ptrIndicator[] = "_Pointer";

    for (int i = 0; i < length; i++)
    {
        printf("Enter Name: ");
        scanf("%s", name);
        printf("Enter Grade: ");
        scanf("%f", &grade);

        strcpy(student[i].name, name);
        strcat(name, ptrIndicator); // added the "_Pointer" to the name
        strcpy(studentPtr[i].name, name);

        student[i].grade = grade;
        studentPtr[i].grade = grade;
    }

    // when indexing point and print value - *(studentPtr + 1) == studentPtr[1]
    // printf("%p", studentPtr + 1);

    // include * in sizeof() -> return the size of studentPtr[0]
    // if not include * -> return the size of pointer. A pointer occupies 8 bytes in memory
    // printf("%lu", sizeof(*studentPtr));

    puts("\n-------- Display Student as Non-Pointer param --------");
    printElOfStudent(student, length);

    puts("\n\n-------- Display Student as Pointer param --------");
    printElOfStudent(studentPtr, length);

    int lastIndex = length; // get prev length as current last indext

    puts("\nLet's try to add an additional student: ");
    printf("Enter Name: ");
    scanf("%s", name);
    printf("Enter Grade: ");
    scanf("%f", &grade);
    strcat(name, ptrIndicator);

    studentPtr = realloc(studentPtr, ++length * sizeof(Student));
    strcpy(studentPtr[lastIndex].name, name);
    studentPtr[lastIndex].grade = grade;

    puts("\n-------- Display Student as Pointer param after add one more student --------");
    printElOfStudent(studentPtr, ++lastIndex);

    free(studentPtr);
}