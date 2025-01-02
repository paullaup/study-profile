#include <iostream>
#include <cmath>
#include <unordered_set>

using namespace std;

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
    unordered_set<int> set;
    while(num != 1) {
        if(num == 4) {
            return false;
        }
        if(set.find(num) != set.end()) {
            return false;
        }
        set.insert(num);
        num = sumOfDigitsSquare(num);
    }
    set.clear();
    return true;
}

// bool isHappy(int num) {
//     int tortoise = num;
//     int hare = sumOfDigitsSquare(num);
//     while(tortoise != hare) {
//         tortoise = sumOfDigitsSquare(tortoise);
//         hare = sumOfDigitsSquare(sumOfDigitsSquare(hare));
//     }
//     return tortoise == 1;
// }

bool isPrime(int num, int divisor) {
    if(num % divisor == 0) {
        return false;
    }
    if(divisor > sqrt(num)) {
        return true;
    }
    return isPrime(num, divisor+2);
}

bool isPrime(int num) {
    if(num <= 1) {
        return false;
    }
    if(num == 2 || num == 3) {
        return true;
    }
    return isPrime(num, 3);
}


int main() {
    
    int n;
    do {
        cin >> n;
    } while(n < 10 || n > 1000000);
    int* primeCache = new int[n];
    for(int i = 1; i<=n; i++) {




        if(isPrime(i) && isHappy(i)) {
            cout << i << endl;
        }
    }
    

    return 0;
}
