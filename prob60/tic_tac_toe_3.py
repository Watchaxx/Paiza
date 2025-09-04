# 実行時間 10ms
def judge(c):
    b = False

    if "".join(c) == "OOOOO":
        b = True
        print("O")
    elif "".join(c) == "XXXXX":
        b = True
        print("X")
    return b

def main():
    s = []

    for _ in [0] * 5:
        s.append(input())
    for i in range(5):
        t = []

        for j in range(5):
            t.append(s[j][i])
        if judge(t) == True:
            return
    print("D")

main()
