#include<stdio.h>
#include<string.h>
int n;
bool prime[1000001];
int temp[100000];
int getDigit(int n) {
	if (n < 10) return n * n;
	return (n % 10)*(n % 10) + getDigit(n / 10);
}
bool isHappy(int n) {
	if (n == 4) return false;
	if (n == 1) return true;
	return isHappy(getDigit(n));
}
int main() {
	memset(prime, 1, sizeof(prime));
	scanf("%d", &n);
	int num = 0;
	for (int i = 2; i <= n; i++) {
		if (prime[i]) {
			temp[++num] = i;
		}
		for (int j = 1; j <= num; ++j) {
			if (i*temp[j] > n)
				break;
			prime[i*temp[j]] = false;
			if (i%temp[j] == 0)
				break;
		}
		if (prime[i] && isHappy(i))
			printf("%d\n", i);
	}
	return 0;
}