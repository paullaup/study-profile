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
    while(num>0) {
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
    if(num == 1) {
        //happyCache = (temp->size() > happyCache->size())? temp : happyCache;
        happyCache->insert(temp->begin(), temp->end());
        temp->clear();
        return true;
    }
    else if(temp->count(num) > 0) {
        //unhappyCache = (temp->size() > unhappyCache->size())? temp : unhappyCache;
        unhappyCache->insert(temp->begin(), temp->end());
        temp->clear();
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
}



int main() {

    // long long int max;
    // cin >> max;
    // cout << 7 << endl;
    // for(int i = 10; i <= max; i++) {
        
    SieveOfEratosthenes(20);
    // }
    // int i;
    // cin >> i;
    // SieveOfEratosthenes(i);
    //bool b = isHappy(17);



    return 0;
}