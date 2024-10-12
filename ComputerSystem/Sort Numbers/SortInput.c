#include <stdio.h>

int main() 
{
    int low = 0;
    int med = 0;
    int high = 0;

    printf("Please input an integer 3 times, Low, medium, and high value.\n");
    scanf("%d", &low);
    scanf("%d", &med);
    scanf("%d", &high);

    if (low > med) 
    {
        int temp = 0;
        temp = low;
        low = med;
        med = temp;
    }

    if (med > high) 
    {
        int temp = 0;
        temp = med;
        med = high;
        high = temp;
    }

    if (low > med) 
    {
        int temp = 0;
        temp = low;
        low = med;
        med = temp;
    }

    printf("The sorted value of Low: %d, Medium: %d, and High: %d\n", low, med, high);
}