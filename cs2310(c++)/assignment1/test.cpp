#include <iostream>
#include <string>

void printM(int height) {
    if (height <= 1) {
        std::cout << "Wrong input!" << std::endl;
        return;
    }

    for (int i = 0; i < height; i++) {
        std::string line;
        if (i == height - 1) {
            line = std::string(i, ' ') + "*";
        } else {
            line = std::string(i, ' ') + "*" + std::string(1 + 2*(height-i-2), ' ') + "*";
        }
        std::cout << line << std::endl;
    }
}

void printW(int height) {
    if (height <= 1) {
        std::cout << "Wrong input!" << std::endl;
        return;
    }

    for (int i = 0; i < height; i++) {
        std::string line;
        if (i == height - 1) {
            line = std::string(i, ' ') + "* *";
        } else {
            line = std::string(i, ' ') + "*   " + std::string(2 * (height - i - 1), ' ') + "*";
        }
        std::cout << line << std::endl;
    }
}

int main() {
    int height;
    char option;
    /*

    std::cout << "Please input the height (integer): ";
    std::cin >> height;

    std::cout << "Do you want to print M or W?: ";
    std::cin >> option;

    if (option == 'M') {
        printM(height);
    } else if (option == 'W') {
        printW(height);
    } else {
        std::cout << "Wrong input!" << std::endl;
    */

    printM(3);
    return 0;

    }