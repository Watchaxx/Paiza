# 実行時間 10ms
n = int(input())

for _ in [0] * n:
    a = input()

    if a.endswith(("s", "sh", "ch", "o", "x")) == True:
        print(f"{a}es")
    elif a.endswith("f"):
        print(f"{a[:-1]}ves")
    elif a.endswith("fe"):
        print(f"{a[:-2]}ves")
    elif a.endswith("y"):
        if a.endswith(("ay", "iy", "uy", "ey", "oy")) != True:
            print(f"{a[:-1]}ies")
        else:
            print(f"{a}s")
    else:
        print(f"{a}s")
