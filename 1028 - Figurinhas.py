n = int(input())

#
# Função que calcula o MDC entre dois números
#
def mdc(num1, num2):
    resto = None
    while resto != 0:
        resto = num1 % num2
        num1  = num2
        num2  = resto

    return num1

for i in range(n):
    n1, n2 = [int (i) for i in input().split()]
    print(mdc(n1, n2))
