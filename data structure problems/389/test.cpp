#include <iostream>
using namespace std;

class A {
public:
    int value;
    A() : value(0) {} // Constructor
};

int main() {
    A* arr = new A[5]; // arr points to an array of 5 A objects

    arr[0].value = 10; // Accessing the first A object in the array
    cout << arr[1].value << endl;
    A* a = &arr[1];
    a->value = 5;
    cout << arr[1].value << endl;

    delete[] arr; // Don't forget to free the allocated memory!
    return 0;
}
