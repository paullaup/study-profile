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
};

class MyClassArr {
    private:
        MyArray<int> *mArray;
        int len;
    public:
        MyClassArr() {
            mArray = nullptr;
            len = 0;
        }

        MyClassArr(int arr[], int l) {
            mArray = new MyArray<int>(l);
            for(int i = 0; i<l; i++) {
                mArray->pushBack(arr[i]);
            }
            len = l;
        }

        MyClassArr(const MyClassArr &a) {
            mArray = new MyArray<int>(a.len);
            for(int i = 0; i<a.len; i++) {
                mArray->pushBack((*a.mArray)[i]);
            }
            len = a.len;
        }

        void operator= (const MyClassArr &a) {
            mArray = new MyArray<int>(a.len);
            for(int i = 0; i<a.len; i++) {
                mArray->pushBack((*a.mArray)[i]);
            }
            len = a.len;
        }

        friend ostream &operator<< (ostream &cout, const MyClassArr &a) {
            for(int i = 0; i<a.len; i++) {
                cout << (*a.mArray)[i] << ' ';
            }
            return cout;
        }

        bool operator> (const MyClassArr &a) {
            int minLen = (len<a.len)? len : a.len;
            for(int i = 0; i<minLen; i++) {
                if((*mArray)[i] > (*a.mArray)[i]) {
                    return true;
                }
                else if((*mArray)[i] < (*a.mArray)[i]) {
                    return false;
                }
            }
            if(len>a.len) {
                return true;
            }
            else {
                return false;
            }
        }

};

void testPartC() {
	MyArray<MyClassArr> arr(5);
	// Your code
    int height, width, num;
    int *temp;
    MyClassArr *myClassArr;
    cout << "Input the amount of variables to store in the MyClassArr array:" << endl;
    cin >> height;
    for(int i = 0; i<height; i++) {
        cout << "Input the size of MyArray " << i+1 << ':' << endl;;
        cin >> width;
        temp = new int[width];
        cout << "Input array " << i+1 << ':' << endl;
        for(int i = 0; i<width; i++) {
            cin >> num;
            temp[i] = num;
        }
        myClassArr = new MyClassArr(temp, width);
        arr.pushBack(*myClassArr);
    }
    cout << "The max value of the array is: " << arr.getMax();
}

int main() {
	testPartC();
	return 0;
}