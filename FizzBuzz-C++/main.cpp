#include <iostream>
#include <Windows.h>

int main() {
    SetConsoleOutputCP(CP_UTF8);
    int interval = 0;

    std::cout << "Введите границу: ";
    std::cin >> interval;

    for(int i = 1; i < interval + 1; ++i) {
        if(!(i % 3)) {
            std::cout << "Fizz";
        }
        if(!(i % 5)) {
            std::cout << "Buzz";
        }
        if(i % 3 && i % 5) {
            std::cout << i;
        }
        std::cout << '\n';
    }
}