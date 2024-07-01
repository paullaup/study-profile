#include <iostream>
#include <string>

using namespace std;

template <class T>
class Base{
    private:
        T *arr;
    public:
        void set(T s[]) {
            arr = new T[5];
            arr = s;
        }
        T *getArr() {
            return arr;   
        }
};

class A : public Base<int>{
    public:
        void set(int s[]) {
            Base::set(s);
        }
};

class B : public Base<char>{
    public:
        void set(char s[]) {
            Base::set(s);
        }
};

//from index start to end inclusively
template <class T>
bool isPalin(T arr[], int start, int end) {
    while(end > start) {
        if(arr[start]!=arr[end]) {
            return false;
        }
        end--;
        start++;
    }
    
    return true;
}

template <class T>
void shortestPalin(T arr[]) {
    //check if the last element is include in palindrome
    int start = 0;
    while(start<4) {
        if(isPalin<T>(arr, start, 4)) {
            break;
        }
        start++;
    }

    start--; // last digit not needed
    cout << "The shortest palindrome of the given array is:" << endl;
    for(int i = 0; i<5; i++) {
        cout << arr[i] << ' ';
    }
    for(int i = start; i>=0; i--) {
        cout << arr[i] << ' ';
    } 
}

int main() {
    int choice;
    cout << "1: int; 2: char" << endl;
    cin >> choice;
    A a;
    B b;
    
    
    if(choice==1) {
        int arr[5];
        cout << "Enter 5 integers:" << endl;
        for(int i = 0; i<5; i++) {
            cin >> arr[i];
        }
        a.set(arr);
        shortestPalin<int>(arr);
    }
    else if(choice==2) {
        char arr[5];
        cout << "Enter 5 chars: " << endl;
        for(int i = 0; i<5; i++) {
            cin >> arr[i];
        }
        b.set(arr);
        shortestPalin<char>(arr);
    }
    
    
    
    return 0;
}