#include <iostream>
#include <cmath>
#include "LinkedList.cpp"

using namespace std;



bool isPrime(int num) {
    if(num == 1) {
        return false;
    }
    if(num == 2) {
        return true;
    }
    for(int i = 2; i < sqrt(num); i++) {
        if(num % i == 0) {
            return false;
        }
    }
    return true;
}

int sumOfDigitsSquare(int num) {
    int sum = 0;
    int digit;
    while(num>0) {
        digit = num % 10;
        sum += digit * digit;
        num /= 10;
    }
    return sum;
}

bool isHappy(int num) {
    LinkedList records;
    while(num != 1) {
        records.append(num);
        num = sumOfDigitsSquare(num);
        if(records.search(num)) {
            return false;
        }
    }
    return true;
}


int main() {
    int n;
    cin >> n;
    for(int i = 1; i<=n; i++) {
        if(isPrime(i) && isHappy(i)) {
            cout << i << endl;
        }
    }
    set<int> 

    return 0;
}