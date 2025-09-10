# 実行時間 10ms
n = int(input())

for _ in [0] * n:
    a = input()

    if a.endswith("y"):
        if a.endswith(("ay", "iy", "uy", "ey", "oy")) != True:
            print(f"{a[:-1]}ies")
        else:
            print(f"{a}s")
    else:
        print(f"{a}s")
