#include <iostream>
#include <string>

using namespace std;

template<class T>
class MyArray {
    private:
        T *pAddress;
        int mSize;
        int mCapacity;
    public:
        MyArray(int capacity) {
            mCapacity = capacity;
            pAddress = new T[mCapacity];
            mSize = 0;
        }

        MyArray(const MyArray<T> &a) {
            mSize = a.mSize;
            mCapacity = a.mCapacity;
            pAddress = new T[mCapacity];
            for(int i = 0; i<mSize; i++) {
                pAddress[i] = a.pAddress[i];
            }
        }

        ~MyArray() {
            delete [] pAddress;
        }

        void pushBack(const T &val) {
            if(mCapacity == mSize) {
                cout << "Inserting new value failed: the array is full." << endl;
            }
            else {
                pAddress[mSize++] = val;
            }
        }

        T getMax() {
            T max = pAddress[0];
            for(int i = 1; i<mSize; i++) {
                if(pAddress[i]>max) {
                    max = pAddress[i];
                }
            }
            return max;
        }

        void operator= (const MyArray<T> &a) {
            mSize = a.mSize;
            mCapacity = a.mCapacity;
            pAddress = new T[mCapacity];
            for(int i = 0; i<mSize; i++) {
                pAddress[i] = a.pAddress[i];
            }
        }

        T operator[] (int index) {
            return pAddress[index];
        }

        void print() {
            for(int i = 0; i<mSize; i++) {
                cout << pAddress[i] << " ";
            }
        }
};

void testPartA() {
    
	MyArray<int> arr1(5);
	int inputInt, inSize;
	cout << "Input the amount of variables to store in the int array: " << endl;
	cin >> inSize;
	cout << "Input the integers: " << endl;
	for (int i = 0; i < inSize; i++) {
		cin >> inputInt;
		arr1.pushBack(inputInt);
	}
	cout << "The max value of the array is: " << arr1.getMax() << endl;

	MyArray<char> arr2(5);
    // Your code
    cout << "Input the amount of variables to store in the char array:" << endl;
    int size;
    char c;
    cin >> size;
    cout << "Input the chars:" << endl;
    for(int i = 0; i<size; i++) {
        cin >> c;
        arr2.pushBack(c);
    }
    cout << "The max value of the array is: " << arr2.getMax() << endl;
    
}

int main() {
    testPartA();
    return 0;
}