def summa(num1, num2):
    num1 += 1
    num2 -= 1
    if num2 > 0:
        return summa(num1, num2)
    else:
        return num1
num1 = int(input("Введите 1 число: "))
num2 = int(input("Введите 2 число: "))
print("Результат произвидения :", summa(num1, num2))