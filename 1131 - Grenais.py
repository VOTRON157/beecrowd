grenais = 0
gremio = 0
inter = 0
empates = 0

gols_inter, gols_gremio = [int (i) for i in input().split()]
grenais += 1
if(gols_inter == gols_gremio):
    empates += 1
elif(gols_gremio > gols_inter):
    gremio += 1
elif(gols_inter > gols_gremio):
    inter += 1

while True:
    resposta = int(input("Novo grenal (1-sim 2-nao)\n"))
    if(resposta == 1):
        gols_inter, gols_gremio = [int (i) for i in input().split()]
        grenais += 1
        if(gols_inter == gols_gremio):
            empates += 1
        elif(gols_gremio > gols_inter):
            gremio += 1
        elif(gols_inter > gols_gremio):
            inter += 1
    else:
        print(f"{grenais} grenais")
        print(f"Inter:{inter}")
        print(f"Gremio:{gremio}")
        print(f"Empates:{empates}")
        if(inter > gremio):
            print("Inter venceu mais")
        else:
            print("Gremio vendeu mais")
        break
