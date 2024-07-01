#include <iostream>
#include <string>

using namespace std;

class MyClassInt {
    private:
        int val;
    public:
        MyClassInt() {
            val = 0;
        }

        MyClassInt(int v) {
            val = v;
        }

        void operator= (const MyClassInt &myClassInt) {
            val = myClassInt.val;
        }

        friend ostream &operator<< (ostream &cout, const MyClassInt myClassInt) {
            cout << myClassInt.val;
            return cout;
        }

        bool operator> (const MyClassInt myClassInt) {
            return val > myClassInt.val;
        }


};



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
};

void testPartB() {
	MyArray<MyClassInt> arr(5);
	int inputInt, inSize;
	cout << "Input the amount of variables to store in the MyClassInt array: " << endl;
	cin >> inSize;
	cout << "Input the integers: " << endl;
	for (int i = 0; i < inSize; i++) {
		cin >> inputInt;
		arr.pushBack(MyClassInt(inputInt));
	}
	cout << "The max value of the array is: " << arr.getMax() << endl;
}

int main() {
    testPartB();
    return 0;
}