# 実行時間 10ms
import sys

for _ in [0] * 5:
    s = input()

    if s == "OOOOO":
        print("O")
        sys.exit()
    elif s == "XXXXX":
        print("X")
        sys.exit()
print("D")
