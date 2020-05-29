#include<stdio.h>

int main(){
    int rowA, colA;
    int rowB, colB;

    printf("行列Aの行数:");
    scanf("%d", &rowA);
    printf("行列Aの列数:");
    scanf("%d", &colA);
    printf("============\n");
    printf("行列Bの行数:");
    scanf("%d", &rowB);
    printf("行列Bの列数:");
    scanf("%d", &colB);

    int i, j, k;
    int matrixA[rowA][colA];
    int matrixB[rowB][colB];
    int matrixC[rowA][colB];

    printf("==== 行列A ====\n");
    for(i = 0; i < rowA; i++) {
        for(j = 0; j < colA; j++) {
            printf("%d行%d列の値:", i + 1, j + 1);
            scanf("%d", &matrixA[i][j]);
        }
    }

    printf("==== 行列B ====\n");
    for(i = 0; i < rowB; i++) {
        for(j = 0; j < colB; j++) {
            printf("%d行%d列の値:", i + 1, j + 1);
            scanf("%d", &matrixB[i][j]);
        }
    }

    printf("行列A = \n");
    for(i = 0; i < rowA; i++) {
        printf("|");
        for(j = 0; j < colA; j++) {
            printf("%3d", matrixA[i][j]);
        }
        printf("|\n");
    }

    printf("行列B = \n");
    for(i = 0; i < rowB; i++) {
        printf("|");
        for(j = 0; j < colB; j++) {
            printf("%3d", matrixB[i][j]);
        }
        printf("|\n");
    }

    for(i = 0; i < rowA; i++) {
        for(j = 0; j < colB; j++) {
            matrixC[i][j] = 0; //代入前に初期化
            for(k = 0; k < colA; k++) {
                matrixC[i][j] += matrixA[i][k] * matrixB[k][j];
            }
        }
    }

    printf("===== result =====\n");
    for(i = 0; i < rowA; i++) {
        printf("|");
        for(j = 0; j < colB; j++) {
            printf("%5d", matrixC[i][j]);
        }
        printf("|\n");
    }

    return 0;
}