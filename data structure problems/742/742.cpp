#include <iostream>
#include <cmath>

using namespace std;

int count(string* matrix, int x, int y, int n) {
    int prev = matrix[x][y];
    bool isGray = false;
    int i = 0;
    while(i < n && !isGray) {
        int j = 0;
        while(j < n && !isGray) {
            if(matrix[x+i][y+j] != prev) {
                isGray = true;
            }
            j++;
        }
        i++;
    }
    if(isGray) {
        int topLeft = count(matrix, x, y, n/2);
        int topRight = count(matrix, x + n/2, y, n/2);
        int bottomLeft = count(matrix, x, y + n/2, n/2);
        int bottomRight = count(matrix, x + n/2, y + n/2, n/2);
        return 1 + topLeft + topRight + bottomLeft + bottomRight;
    }
    else {
        return 1;
    }
}

int main() {

    int k;
    string* matrix;
    while(cin >> k) {
        int n = pow(2, k);
        matrix = new string[n];
        for(int i = 0; i < n; i++) {
            cin >> matrix[i];
        }

        cout << count(matrix, 0, 0, n) << endl;
    }

    return 0;

}