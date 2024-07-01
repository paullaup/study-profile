#include <iostream>
#include <iomanip>
using namespace std;

void printTwo(int height) {
    cout << setw(height) << '*' << setw((height - 1)*2) << '*' << endl;
}

void printThree(int height) {
    cout << '*' << setw((height - 1)*2) << '*' << setw((height - 1)*2) << '*' << endl;
}

int main() {
    int height;
    char character;
    cout << "Please input the height (integer):" << endl;
    cin >> height;
    cout << "Do you want to print M or W?:" << endl;
    cin >> character;
    if((character != 'M' && character != 'W') || height <= 1) {
        cout << "Wrong input!";
        return 0;
    }
    int startingSpace, spaceInside, spaceOutside;
    
    (character == 'M')? printTwo(height) : printThree(height);
    for(int i = 1 ; i < height - 1 ; i++) {
        startingSpace = (character == 'W')? i : height - 1 - i;
        spaceInside = (character == 'W')? (height - 2 - i)*2 + 1 : (i - 1)*2 + 1;
        spaceOutside = (character == 'W')? (i - 1)*2 + 1 : 1 + (height - i - 2)*2;
        cout << setw(startingSpace + 1) << '*' << setw(spaceInside + 1) << '*' << setw(spaceOutside + 1) << '*' << setw(spaceInside + 1) << '*' << endl;
    }
    (character == 'W')? printTwo(height) : printThree(height);
    return 0;
}