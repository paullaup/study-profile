#include <iostream>
using namespace std;

class Combination {
    private:
        int dNum;// number of dices
        int cNum;// number of different point sums
        long long int **pPtr; // pointing to a 2D array for each pair of occurrence and sum. Use long int to avoid overflow.
    public:
        Combination(int i = 1) {
        /************** to be finished **************/
            dNum = i;
            cNum = i*6 - (i-1);
            pPtr = new long long int*[cNum];
            for(int i = 0; i<cNum; i++) {
                pPtr[i] = new long long int[2];
                pPtr[i][0] = dNum + i;
                pPtr[i][1] = 0;
            }
            findSum();

        }
        ~Combination() {
            
/************** to be finished **************/
/***********Remember to release memory*******/
            delete pPtr;
            cout << "Memory is released" << endl;
        }

        void printTable() {
            for(int i = 0; i<cNum; i++) {
                cout << pPtr[i][1] << " occurrence(s) of sum " << pPtr[i][0] << endl;
            }
        }

        void findSum() {
            switch(dNum) {
                case 1: findSum1(); break;
                case 2: findSum2(); break;
                case 3: findSum3(); break;
                default: sumDice(dNum, 0);
            }
        }

        void findSum1();
        void findSum2();
        void findSum3();
        void sumDice(int, long);
        
        /************** to be finished **************/
        void sortBySum();
        void sortByOcc();
        void swapByIndex(int i, int j) {
            long long int *temp = pPtr[i];
            pPtr[i] = pPtr[j];
            pPtr[j] = temp;
        }
};

void Combination::findSum1() {
    for(int i = 1; i<=6; i++) {
        pPtr[i - 1][1]++;
    }
}

void Combination::findSum2() {
    for(int i = 1; i<=6; i++) {
        for(int j = 1; j<=6; j++) {
            int sum = i + j;
            pPtr[sum - 2][1]++;
        }
    }
}
void Combination::findSum3() {
    for(int i = 1; i<=6; i++) {
        for(int j = 1; j<=6; j++) {
            for(int k = 1; k<=6; k++) {
                int sum = i + j + k;
                pPtr[sum - 3][1]++;
            }
        }
    }
}

void Combination::sumDice(int remainDiceNum, long sum) {
    if(remainDiceNum == 0) {
        pPtr[sum - dNum][1]++;
        return;
    }
    else {
        for(int i = 1; i<=6; i++) {
            sumDice(remainDiceNum - 1, sum + i);
        }
    }
}

void Combination::sortBySum() {
    for(int i = 0; i<cNum - 1; i++) {
        for(int j = cNum - 1; j>i; j--) {
            if(pPtr[j][0]>pPtr[j - 1][0]) {
                swapByIndex(j, j - 1);
            }
        } 
    }
    printTable();
}
void Combination::sortByOcc() {
    for(int i = 0; i<cNum - 1; i++) {
        for(int j = cNum - 1; j>i; j--) {
            if(pPtr[j][1]>pPtr[j - 1][1]) {
                swapByIndex(j, j - 1);
            }
        } 
    }
    printTable();
}

void display(Combination &com) {
    int n;
    do {
        cout << "~~~~~~~~~~~~~~~~~" << endl;
        cout << "0 exit" << endl;
        cout << "1 sort by sum" << endl;
        cout << "2 sort by occurrence" << endl;
        cout << "~~~~~~~~~~~~~~~~~" << endl;
        cin >> n;
        switch(n) {
        case 0: cout << "Bye!" << endl; break;
        case 1: com.sortBySum(); break;
        case 2: com.sortByOcc(); break;
        }
        cout << endl;
    } while(n != 0);
}

int main() {
    int diceNum;
    cout << "Enter the number of dice:" << endl;
    cin >> diceNum;
    Combination com(diceNum);
    display(com);
    return 0;
}
        