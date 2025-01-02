#include <iostream>
#include <set>
using namespace std;

bool* notPrimeTable;
set<int>* temp = new set<int>;

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
    if(num == 1) {
        temp = new set<int>;
        return true;
    }
    else if(temp->count(num) > 0) {
        temp = new set<int>;
        return false;
    }
    temp->insert(num);
    return isHappy(sumOfDigitsSquare(num));
}   


bool SieveOfEratosthenes(int max) {
    int size = 0;
    notPrimeTable = new bool[max + 1]();
    for(int i = 2; i < max; i++) {
        if(!notPrimeTable[i]) {
            for(int j = 2 ; j < max && i*j < max; j++) {
                notPrimeTable[i*j] = true;
            }

            bool b = isHappy(i);
            if(b) {
                cout << i << endl;
            }
        }
    }
    delete notPrimeTable;
}



int main() {
    int i;
    cin >> i;
    SieveOfEratosthenes(i);
    return 0;
}