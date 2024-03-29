// PPlab1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <conio.h>
#include <windows.h>

const int n = 3;
int a[n][n] = { 1, -2, 0, 4, 6, 2, -3, 4, -2 };
int b[n][n] = { 0, 2, 0, 1, 1, 1, 5, -3, 10 };
int c[n][n];

DWORD WINAPI ThreadFunc(PVOID pvParam)
{
	int num;
	int i;
	int j;
	num = (*((int*)pvParam));
	for (i = 0; i < n; ++i)
	{
		c[num][i] = 0;
		for (j = 0; j < n; ++j)
		{
			c[num][i] += a[num][j] * b[j][i];
		}
	}

	DWORD dwResult = 0;

	return dwResult;
}

int main(int argc, char** argv)
{
	int i;
	int j;
	int x[n];

	DWORD dwThreadId[n - 1];
	DWORD dw;

	HANDLE hThread[n - 1];

	// create child threads
	for (i = 1; i < n; ++i)
	{
		x[i] = i;
		hThread[i - 1] = CreateThread(NULL, 0, ThreadFunc, (PVOID)& x[i], 0, &dwThreadId[i - 1]);
		if (!hThread)
		{
			printf("main precess: thread %d not execute!", i);
		}
	}

	// full first string of result matrix
	x[0] = 0;
	ThreadFunc((PVOID)&x[0]);

	// waiting of ending child threads
	dw = WaitForMultipleObjects(n - 1, hThread, TRUE, INFINITE);

	// output result of al threads calculations
	for (i = 0; i < n; ++i)
	{
		fprintf(stdout, "\n");
		for (j = 0; j < n; ++j)
		{
			printf("%d ", c[i][j]);
		}
	}

	_getch();

	return 0;
}
