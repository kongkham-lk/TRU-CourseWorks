#include <stdio.h>

void getTotalSaleByCountries(float nums[], float *sum); // compute for the end of each row
void getTotalSaleByYear(float tar[], float ref1[], float ref2[], float ref3[], float ref4[], float ref5[]); // compute for the last row

int main()
{
    // initialize the size of each property type
    int yearSize = 6;
    int countriesSize = 5;

    // initialized array with different property type
    char *year[] = {"", "2022", "2021", "2020", "2019", "2018", "2017", "Total"};
    char *countries[] = {"USA", "Germany", "UK", "Japan", "Rest", "Total"};
    float saleUSA[] = {356.0, 314.0, 263.5, 193.6, 160.2, 120.5};
    float saleGermany[] = {33.6, 37.3, 29.6, 22.2, 19.9, 17.0};
    float saleUK[] = {30.0, 31.9, 26.5, 17.5, 14.5, 11.4};
    float saleJapan[] = {24.4, 23.1, 20.5, 16.0, 13.8, 11.9};
    float saleRest[] = {69.8, 63.5, 46.0, 31.1, 24.5, 17.2};
    float totalSaleByCountries[countriesSize];
    float totalSaleByYear[yearSize + 1];

    // get the total sum of each country
    getTotalSaleByCountries(saleUSA, &totalSaleByCountries[0]);
    getTotalSaleByCountries(saleGermany, &totalSaleByCountries[1]);
    getTotalSaleByCountries(saleUK, &totalSaleByCountries[2]);
    getTotalSaleByCountries(saleJapan, &totalSaleByCountries[3]);
    getTotalSaleByCountries(saleRest, &totalSaleByCountries[4]);

    // get the total sum of each year and the total col as well
    getTotalSaleByYear(totalSaleByYear, saleUSA, saleGermany, saleUK, saleJapan, saleRest);
    getTotalSaleByCountries(totalSaleByCountries, &totalSaleByYear[6]);

    // print sales report to console
    printf("\n%55s\n\n", "Amazon Sales (billions, US $)"); // print title
    for (int i = 0; i < sizeof(*year); i++)                // print year header
        printf("%10s", year[i]);

    for (int i = 0; i < countriesSize; i++)
    {
        printf("\n%-10s", countries[i]); // print country name
        float *target;

        // get the target country's array to display in each row by using ref
        if (i == 0)
            target = saleUSA;
        else if (i == 1)
            target = saleGermany;
        else if (i == 2)
            target = saleUK;
        else if (i == 3)
            target = saleJapan;
        else if (i == 4)
            target = saleRest;

        // print the target country's sale for each row
        for (int i = 0; i < yearSize; i++)
            printf("%10.1f", target[i]);

        printf("%10.1f", totalSaleByCountries[i]); // print the total sale of each country
    }

    printf("\n%-10s", countries[5]);
    for (int i = 0; i < yearSize + 1; i++) // print the total sale of each year
        printf("%10.1f", totalSaleByYear[i]);
        
    printf("\n\n");
}

void getTotalSaleByCountries(float nums[], float *sum)
{
    for (int i = 0; i < sizeof(*nums); i++)
        *sum += nums[i];
}

void getTotalSaleByYear(float tar[], float ref1[], float ref2[], float ref3[], float ref4[], float ref5[])
{
    for (int i = 0; i < 6; i++)
    {
        int sum = 0;
        sum += ref1[i];
        sum += ref2[i];
        sum += ref3[i];
        sum += ref4[i];
        sum += ref5[i];
        tar[i] = sum;
    }
}