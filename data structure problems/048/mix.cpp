class ListNode {
    public:
        int data;
        ListNode* next;
        ListNode() {
            data = 0;
            next = nullptr;
        }
        ListNode(int d, ListNode* n) {
            this->data = d;
            this->next = n;
        }
};

class LinkedList {
    public:
        ListNode* first;
        ListNode* last;
        LinkedList() {
            first = nullptr;
            last = nullptr;
        }

        void append(int num) {
            if(first == nullptr) {
                first = new ListNode(num, nullptr);
                last = first;
                return;
            }
            if(first == last) {
                ListNode* temp = new ListNode(num, nullptr);
                first->next = temp;
                last = temp;
                return;
            }
            ListNode* temp = new ListNode(num, nullptr);
            last->next = temp;
            last = temp;
            
        }

        bool search(int num) {
            ListNode* current = first;
            while(current != nullptr) {
                if(current->data == num) {
                    return true;
                }
                current = current->next;
            }
            return false;
        }
};

#include <iostream>
#include <cmath>

using namespace std;



bool isPrime(int num) {
    if(num <= 1) {
        return false;
    }
    if(num == 2) {
        return true;
    }
    for(int i = 2; i <= sqrt(num); i++) {
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
        if(!records.search(num)) {
            return false;
        }
        num = sumOfDigitsSquare(num);
        records.append(num);
    }
    return true;
}


int main() {
    int n;
    do {
        cin >> n;
    } while(n < 10 || n > 1000000);
    for(int i = 1; i<=n; i++) {
        if(isPrime(i) && isHappy(i)) {
            cout << i << endl;
        }
    }

    return 0;
}