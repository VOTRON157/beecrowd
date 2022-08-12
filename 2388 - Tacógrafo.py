n = int(input())
count = 0

for i in range(n):
    tempo, velocidade = [int (i) for i in input().split()]
    count += velocidade * tempo
print(count)
