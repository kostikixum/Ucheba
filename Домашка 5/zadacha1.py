def exp(number, degree):
    if (degree == 1):
        return (number)
    if (degree != 1):
        return (number * exp(number, degree - 1))
number = int(input("Введите число: "))
degree = int(input("Введите его степень: "))
print("Результат возведения в степень равен :", exp(number, d