#include <iostream>
#include <set>
using namespace std;

bool* notPrimeTable;
set<int>* happyCache = new set<int>;
set<int>* unhappyCache = new set<int>;
set<int>* temp = new set<int>;

int sumOfDigitsSquare(int num) {
    int sum = 0;
    int digit;
    while(num > 0) {
        digit = num % 10;
        sum += digit * digit;
        num /= 10;
    }
    return sum;
}

bool isHappy(int num) {
    if(happyCache->count(num) > 0) {
        return true;
    }
    if(unhappyCache->count(num) > 0) {
        return false;
    }
    if(temp->count(num) > 0) {
        for (int n : *temp) {
            unhappyCache->insert(n);
        }
        temp->clear();
        return false;
    }
    temp->insert(num);
    bool result = isHappy(sumOfDigitsSquare(num));
    if (result) {
        for (int n : *temp) {
            happyCache->insert(n);
        }
    } else {
        for (int n : *temp) {
            unhappyCache->insert(n);
        }
    }

    temp->erase(num);
    return result;
}

int main() {
    for(int i = 2; i < 20; i++) {
        cout << i << " " << isHappy(i) << endl;
    }

    return 0;
}
